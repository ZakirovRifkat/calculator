using System;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace calc
{
    public partial class Form1 : Form
    {
        bool isClickSolution = false;
        bool isEmptyTextBox = true;
        int numberOfLeftBrackets;
        int numberOfRightBrackets;

        public Form1()
        {
            InitializeComponent();
            //StartCheckTextBoxAsync();
        }

        private void One_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += "1";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += ".";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += "-";
        }

        private void Multyply_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            
            input.Text += "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            input.Text += "/";
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (!isEmptyTextBox)
            {
                if (input.Text[^1] == ')')
                {
                    numberOfRightBrackets--;
                }
                else if (input.Text[^1] == '(')
                {
                    numberOfLeftBrackets--;
                }
                input.Text = input.Text.Remove(input.Text.Length - 1);
                if (isClickSolution)
                {
                    input.Text = "";
                }
            }
            else
            {
                input.Text = "";
            }
        }

        private void LeftBracket_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            numberOfLeftBrackets++;
            input.Text += "(";
        }

        private void RightBracket_Click(object sender, EventArgs e)
        {
            CheckClickSolution();
            numberOfRightBrackets++;
            input.Text += ")";
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            if (numberOfLeftBrackets == numberOfRightBrackets)
            {
                isClickSolution = true;
                string binaryExpression = input.Text;
                if (!isEmptyTextBox)
                {
                    char[] symbols = { '+', '-', '*', '/', '(', ')' };
                    string[] numbers = binaryExpression.Split(symbols);
                    numbers = numbers.Where(x => x != "").ToArray();
                    string[] decimalNumbers = new string[numbers.Length];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        decimalNumbers[i] = BinaryToDecimal(numbers[i]);
                    }

                    string decimalExpression = RebuildExpression(binaryExpression, decimalNumbers);
                    decimalExpression = decimalExpression.Replace(',', '.');

                    DataTable dt = new DataTable();
                    try
                    {
                        string decimalSolution = Convert.ToString(dt.Compute(decimalExpression, ""));
                        if (decimalSolution == "не число" || decimalSolution == "∞")
                        {
                            decimalSolution = "∞";
                            input.Text = decimalSolution;
                        }
                        else
                        {
                            input.Text = RemoveExtraZeros(DecimalToBinary(decimalSolution));
                        }
                    }
                    catch (Exception exeption)
                    {
                        MessageBox.Show(exeption.Message,
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        input.Text = "";
                    }
                }
                else 
                {
                    input.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Не хватает скобок!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
            }

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            isEmptyTextBox = input.Text == "";
            CheckDoubleSign();
            CheckFirstSign();
            CheckNumberOfBrackets();
            CheckCorrectBrackets();
            CheckDoubleDots();
        }

        private void CheckDoubleSign()
        {
            string str = input.Text;
            string[] operators = new string[] {
                "++", "+-", "+*", "+/", "+.",
                "--", "-+", "-*", "-/", "-.",
                "**", "*/", "*.",
                "//", "/+",  "/*", "/.",
                "..", ".+", ".-", ".*", "./"
            };
            foreach (string op in operators)
            {
                if (str.Contains(op))
                {
                    MessageBox.Show("Введено два знака!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    input.Text = input.Text.Remove(input.Text.Length - 1);
                    break;
                }
            }
        }

        private void CheckFirstSign()
        {
            string str = input.Text;
            char[] operators = new char[] { '*', '/', '.' };
            if (isEmptyTextBox == false)
            {
                foreach (char op in operators)
                {
                    if (str[0] == op)
                    {
                        MessageBox.Show("Некорректный ввод первого знака!",
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        input.Text = input.Text.Remove(input.Text.Length - 1);
                        break;
                    }
                }
            }
        }

        private void CheckNumberOfBrackets()
        {
            if (isEmptyTextBox)
            {
                numberOfLeftBrackets = 0;
                numberOfRightBrackets = 0;
            }
            if (numberOfRightBrackets > numberOfLeftBrackets)
            {
                MessageBox.Show("Проблема со скобками!",
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                numberOfRightBrackets = numberOfRightBrackets -1;
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
        }

        private void CheckCorrectBrackets()
        {
            string str = input.Text;
            string[] brackets = new string[] {
                "+)", "-)", "*)","/)",
                 "(*","(/",
                ".)",").", ".(", "(.",
                "()",")(", "1(", "0("
            };
            foreach (string bracket in brackets)
            {
                if (str.Contains(bracket))
                {
                    MessageBox.Show("Проблема со скобками!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    if (input.Text[^1] == ')')
                    {
                        numberOfRightBrackets--;
                    }
                    else if (input.Text[^1] == '(')
                    {
                        numberOfLeftBrackets--;
                    }
                    input.Text = input.Text.Remove(input.Text.Length - 1);
                    break;
                }
            }
            if (str.Contains(")1") || str.Contains(")0"))
            {
                MessageBox.Show("Проблема со скобками!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
        }

        private void CheckClickSolution()
        {
            if (isClickSolution == true)
            {
                isClickSolution = false;
                input.Text = "";
            }
        }

        private void CheckDoubleDots()
        {
            string str = input.Text;
            char[] symbols = { '+', '-', '*', '/', '(', ')' };
            string[] numbers = str.Split(symbols);
            numbers = numbers.Where(x => x != "").ToArray();
            foreach (string number in numbers)
            {
                int countDots = number.Count(c => c == '.');
                if (countDots > 1)
                {
                    MessageBox.Show("Две точки в числе!",
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                    input.Text = str.Remove(str.Length - 1);
                    break;
                }
            }
        }

        private static string BinaryToDecimal(string binaryNumber)
        {
            string[] parts = binaryNumber.Split('.');
            string integerPart = parts[0];
            double decimalFractionalPart = 0;

            int decimalIntegerPart = Convert.ToInt32(integerPart, 2);

            if (parts.Length == 2)
            {
                string fractionalPart = parts[1];
                double currentPower = -1;
                foreach (char c in fractionalPart)
                {
                    int digit = Convert.ToInt32(c.ToString());
                    decimalFractionalPart += digit * Math.Pow(2, currentPower);
                    currentPower--;
                }
            }
            double decimalNumber = decimalIntegerPart + decimalFractionalPart;
            return decimalNumber.ToString();
        }

        private static string DecimalToBinary(string decimalNumber)
        {

            string sign = "";
            if (decimalNumber[0] == '-')
            {
                sign = "-";
            }
            string[] a = decimalNumber.Split('-');
            a = a.Where(x => x != "").ToArray();
            decimalNumber = a[0];
            double number = Convert.ToDouble(decimalNumber);
            int integerPart = (int)number;
            double fractionalPart = number - integerPart;

            string binaryIntegerPart = Convert.ToString(integerPart, 2);

            string binaryFractionalPart = "";
            for (int i = 0; i < 5; i++)
            {
                fractionalPart *= 2;
                int bit = (int)fractionalPart;
                binaryFractionalPart += bit.ToString();
                fractionalPart -= bit;
            }
            string binaryNumber = sign + binaryIntegerPart + "." + binaryFractionalPart;
            return binaryNumber;
        }

        public static string RebuildExpression(string binaryExpression, string[] decimalNumbers)
        {
            binaryExpression += '_';
            int indexOfNumber = 0;
            for (int i = 0; i < binaryExpression.Length;)
            {
                if (binaryExpression[i] == '1' || binaryExpression[i] == '0')
                {
                    int k = 0;
                    int startIndex = i;
                    while (
                        binaryExpression[startIndex + k] == '0' ||
                        binaryExpression[startIndex + k] == '1' ||
                        binaryExpression[startIndex + k] == '.'
                        )
                    {
                        k++;
                    }
                    int endIndex = startIndex + k;
                    binaryExpression = binaryExpression[..startIndex] + decimalNumbers[indexOfNumber] + binaryExpression[endIndex..];
                    i = i + decimalNumbers[indexOfNumber].Length - 1;
                    indexOfNumber++;
                }
                i++;
            }
            binaryExpression = binaryExpression.TrimEnd('_');
            return binaryExpression;
        }

        private static string RemoveExtraZeros(string str)
        {
            while (str[^1] == '0')
            {
                str = str.Remove(str.Length - 1);
            }
            if (str[^1] == '.')
            {
                str = str.Remove(str.Length - 1);
            }
            return str;
        }

    }
}



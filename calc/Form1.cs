using System.Data;
using System.Runtime.CompilerServices;

namespace calc
{
    public partial class Form1 : Form
    {
        bool isClickSolution = false;

        public Form1()
        {
            InitializeComponent();
            StartCheckTextBoxAsync();
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
            if (!isClickSolution)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
            else
            {
                input.Text = "";
            }
        }

        private void LeftBracket_Click(object sender, EventArgs e)
        {
            input.Text += "(";
        }

        private void RightBracket_Click(object sender, EventArgs e)
        {
            input.Text += ")";
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            isClickSolution = true;
            string binaryExpression = input.Text;
            char[] symbols = { '+', '-', '*', '/', '(', ')' };
            string[] numbers = binaryExpression.Split(symbols);
            numbers = numbers.Where(x => x != "").ToArray();
            string[] decimalNumbers = new string[numbers.Length];
            string decimalSolution = "";
            input.Text = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                decimalNumbers[i] = BinaryToDecimal(numbers[i]);
            }

            string decimalExpression = RebuildExpression(binaryExpression, decimalNumbers);

            decimalExpression = decimalExpression.Replace(',', '.');
            input.Text = decimalExpression;
            DataTable dt = new DataTable();
            try
            {
                decimalSolution = Convert.ToString(dt.Compute(decimalExpression, ""));
                if (decimalSolution == "не число" || decimalSolution == "∞")
                {
                    decimalSolution = "😊";
                    input.Text = decimalSolution;
                }
                else
                {

                    input.Text = DecimalToBinary(decimalSolution);
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

        private async Task CheckTextBoxAsync()
        {
            string s="";
            string[] operators = new string[] {
                    "++", "+-", "+*", "+/", "+.",
                    "--", "-+", "-*", "-/", "-.",
                    "**", "*+", "*-", "*/", "*.",
                    "//", "/+", "/-", "/*", "/.",
                    "..", ".+", ".-", ".*", "./"
            };
            while (true)
            {
                s = input.Text;
                
                foreach (string op in operators)
                {
                    if (s.Contains(op))
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
                await Task.Delay(100);
            }
        }
        private async void StartCheckTextBoxAsync() {
            await CheckTextBoxAsync();
        }

        private void CheckClickSolution()
        {
            if (isClickSolution == true)
            {
                isClickSolution = false;
                input.Text = "";
            }
        }

        private string BinaryToDecimal(string binaryNumber)
        {
            // разбиваем число на целую и дробную части
            string[] parts = binaryNumber.Split('.');

            string integerPart = parts[0];
            string fractionalPart = "";
            double decimalFractionalPart = 0;
            // переводим целую часть из двоичной системы в десятичную
            int decimalIntegerPart = Convert.ToInt32(integerPart, 2);
            Console.WriteLine(parts[0]);


            if (parts.Length == 2)
            {
                Console.WriteLine(parts[1]);
                fractionalPart = parts[1];
                // переводим дробную часть из двоичной системы в десятичную
                double currentPower = -1;
                foreach (char c in fractionalPart)
                {
                    int digit = Convert.ToInt32(c.ToString());
                    decimalFractionalPart += digit * Math.Pow(2, currentPower);
                    currentPower--;
                }
            }
            // складываем целую и дробную части для получения итогового значения в десятичной системе счисления
            double decimalNumber = decimalIntegerPart + decimalFractionalPart;
            return decimalNumber.ToString();
        }

        private string DecimalToBinary(string decimaNumber)
        {
            double number = Convert.ToDouble(decimaNumber);
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
            string binaryNumber = binaryIntegerPart + "." + binaryFractionalPart;
            return binaryNumber;
        }

        public static string RebuildExpression(string binaryExpression, string[] decimalNumbers)
        {
            Console.WriteLine(binaryExpression);
            string decimalExpression = binaryExpression;
            binaryExpression = binaryExpression + '_';
            int k = 0;
            int startIndex = 0;
            int endIndex = 0;
            int j = 0;
            for (int i = 0; i < binaryExpression.Length;)
            {
                if (binaryExpression[i] == '1' || binaryExpression[i] == '0')
                {
                    k = 0;
                    startIndex = i;
                    Console.WriteLine($"start index = {startIndex}");
                    while (
                        binaryExpression[startIndex + k] == '0' ||
                        binaryExpression[startIndex + k] == '1' ||
                        binaryExpression[startIndex + k] == '.'
                        )
                    {
                        k++;
                    }
                    endIndex = startIndex + k;
                    Console.WriteLine($"end index = {endIndex}");
                    binaryExpression = binaryExpression.Substring(0, startIndex) + decimalNumbers[j] + binaryExpression.Substring(endIndex);
                    i = i + decimalNumbers[j].Length - 1;
                    j++;
                    Console.WriteLine($"expression = {binaryExpression}");


                }
                i++;
                Console.WriteLine("i in end = {0}", i);
                Console.WriteLine("");
            }
            binaryExpression = binaryExpression.TrimEnd('_');
            Console.WriteLine($"final expression = {binaryExpression}");
            return binaryExpression;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



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
            сheckTextBoxAsync();
        }

        private void one_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "-";
        }

        private void multyply_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "*";
        }

        private void division_Click(object sender, EventArgs e)
        {
            checkClickSolution();
            input.Text += "/";
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
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

        private void leftBracket_Click(object sender, EventArgs e)
        {
            input.Text += "(";
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            input.Text += ")";
        }
        private void solution_Click(object sender, EventArgs e)
        {
            isClickSolution = true;
            string binaryExpression = input.Text;
            string decimalExpression = "";
            string decimalSolution = "";
            char[] symbols = { '+', '-', '*', '/', '(', ')' };
            string[] binaryNumbers = binaryExpression.Split(symbols);
            string[] decimalNumbers = Array.Empty<string>();
            for(int i = 0; i < binaryNumbers.Length - 1; i++) 
            {
                decimalNumbers[i] = BinaryToDecimal(binaryNumbers[i]);
                decimalExpression = binaryExpression.Replace(binaryNumbers[i], decimalNumbers[i]);
            }

            DataTable dt = new DataTable();
            try
            {
                decimalSolution = Convert.ToString(dt.Compute(decimalExpression, ""));
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message,
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            input.Text = decimalToBinary(decimalSolution);
        }

        private async Task сheckTextBoxAsync()
        {
            while (true)
            {
                await Task.Delay(3000);
                if (false)
                {
                    //MessageBox.Show("Вы идиот!",
                    //"Предупреждение",
                    //MessageBoxButtons.OK,
                    //MessageBoxIcon.Warning
                    //);
                    //input.Text = input.Text.Remove(input.Text.Length - 1);
                }
            }
        }

        private void checkClickSolution()
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

        private string decimalToBinary(string decimaNumber)
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
    }
}



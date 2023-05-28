using System.Data;

namespace calc
{
    public partial class Form1 : Form
    {
        bool isClickSolution = false;

        public Form1()
        {
            InitializeComponent();
            CheckTextBoxAsync();
        }

        private async Task CheckTextBoxAsync()
        {
            while (true)
            {
                await Task.Delay(3000); // Приостанавливаем выполнение на 1 секунду
                if (input.Text[input.Text.Length - 1] == '(')
                {
                    if (input.Text[input.Text.Length - 2] == '1' || input.Text[input.Text.Length - 2] == '0')
                    {
                        //MessageBox.Show("Вы идиот!",
                        //"Предупреждение",
                        //MessageBoxButtons.OK,
                        //MessageBoxIcon.Warning);
                        //input.Text = input.Text.Remove(input.Text.Length - 1);
                    }
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
            input.Text += ",";
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

        private void solution_Click(object sender, EventArgs e)
        {
            isClickSolution = true;
            string expression = input.Text.ToString();
            string solution = "";
            DataTable dt = new DataTable();
            try
            {
                solution = Convert.ToString(dt.Compute(expression, ""));
            }
            catch (Exception exeption) 
            {
                MessageBox.Show(exeption.Message, 
                    "Предупреждение", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                    );
            }
            input.Text = solution;
        }


        private void allClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = input.Text.Remove(input.Text.Length - 1);
        }

        private void leftBracket_Click(object sender, EventArgs e)
        {
            input.Text += "(";
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            input.Text += ")";
        }
    }

}

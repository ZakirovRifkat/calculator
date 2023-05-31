namespace calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            one = new Button();
            zero = new Button();
            solution = new Button();
            minus = new Button();
            division = new Button();
            plus = new Button();
            multyply = new Button();
            input = new TextBox();
            dot = new Button();
            allClear = new Button();
            clear = new Button();
            rightBracket = new Button();
            leftBracket = new Button();
            SuspendLayout();
            // 
            // one
            // 
            one.BackColor = Color.FromArgb(237, 237, 237);
            one.FlatAppearance.BorderColor = Color.FromArgb(237, 237, 237);
            one.FlatAppearance.BorderSize = 0;
            one.FlatStyle = FlatStyle.Flat;
            one.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            one.ForeColor = Color.FromArgb(64, 64, 64);
            one.Location = new Point(0, 160);
            one.Name = "one";
            one.Size = new Size(75, 75);
            one.TabIndex = 0;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += One_Click;
            // 
            // zero
            // 
            zero.BackColor = Color.FromArgb(239, 239, 235);
            zero.FlatAppearance.BorderColor = Color.FromArgb(239, 239, 235);
            zero.FlatAppearance.BorderSize = 0;
            zero.FlatStyle = FlatStyle.Flat;
            zero.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            zero.ForeColor = Color.FromArgb(64, 64, 64);
            zero.Location = new Point(0, 235);
            zero.Name = "zero";
            zero.Size = new Size(75, 75);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += Zero_Click;
            // 
            // solution
            // 
            solution.BackColor = Color.FromArgb(230, 46, 137);
            solution.FlatAppearance.BorderColor = Color.FromArgb(230, 46, 137);
            solution.FlatAppearance.BorderSize = 0;
            solution.FlatStyle = FlatStyle.Flat;
            solution.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            solution.ForeColor = Color.WhiteSmoke;
            solution.Location = new Point(75, 310);
            solution.Name = "solution";
            solution.Size = new Size(150, 75);
            solution.TabIndex = 2;
            solution.Text = "=";
            solution.UseVisualStyleBackColor = false;
            solution.Click += Solution_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(137, 78, 217);
            minus.FlatAppearance.BorderColor = Color.FromArgb(137, 78, 217);
            minus.FlatAppearance.BorderSize = 0;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            minus.ForeColor = Color.WhiteSmoke;
            minus.Location = new Point(225, 235);
            minus.Name = "minus";
            minus.Size = new Size(75, 75);
            minus.TabIndex = 3;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += Minus_Click;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(145, 85, 225);
            division.FlatAppearance.BorderColor = Color.FromArgb(145, 85, 225);
            division.FlatAppearance.BorderSize = 0;
            division.FlatStyle = FlatStyle.Flat;
            division.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            division.ForeColor = Color.WhiteSmoke;
            division.Location = new Point(225, 85);
            division.Name = "division";
            division.Size = new Size(75, 75);
            division.TabIndex = 4;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += Division_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(133, 71, 217);
            plus.FlatAppearance.BorderColor = Color.FromArgb(133, 71, 217);
            plus.FlatAppearance.BorderSize = 0;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            plus.ForeColor = Color.WhiteSmoke;
            plus.Location = new Point(225, 310);
            plus.Name = "plus";
            plus.Size = new Size(75, 75);
            plus.TabIndex = 5;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += Plus_Click;
            // 
            // multyply
            // 
            multyply.BackColor = Color.FromArgb(141, 82, 221);
            multyply.BackgroundImageLayout = ImageLayout.Stretch;
            multyply.FlatAppearance.BorderColor = Color.FromArgb(141, 82, 221);
            multyply.FlatAppearance.BorderSize = 0;
            multyply.FlatStyle = FlatStyle.Flat;
            multyply.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            multyply.ForeColor = Color.White;
            multyply.Location = new Point(225, 160);
            multyply.Name = "multyply";
            multyply.Size = new Size(75, 75);
            multyply.TabIndex = 6;
            multyply.Text = "*";
            multyply.UseVisualStyleBackColor = false;
            multyply.Click += Multyply_Click;
            // 
            // input
            // 
            input.BackColor = Color.FromArgb(33, 33, 33);
            input.BorderStyle = BorderStyle.None;
            input.CausesValidation = false;
            input.Dock = DockStyle.Top;
            input.Font = new Font("Courier New", 56F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = Color.White;
            input.ImeMode = ImeMode.NoControl;
            input.Location = new Point(0, 0);
            input.Name = "input";
            input.ReadOnly = true;
            input.RightToLeft = RightToLeft.No;
            input.Size = new Size(297, 85);
            input.TabIndex = 7;
            input.TextAlign = HorizontalAlignment.Right;
            input.TextChanged += Input_TextChanged;
            // 
            // dot
            // 
            dot.BackColor = Color.FromArgb(241, 241, 241);
            dot.FlatAppearance.BorderColor = Color.FromArgb(241, 241, 241);
            dot.FlatAppearance.BorderSize = 0;
            dot.FlatStyle = FlatStyle.Flat;
            dot.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dot.ForeColor = Color.FromArgb(64, 64, 64);
            dot.ImeMode = ImeMode.NoControl;
            dot.Location = new Point(0, 310);
            dot.Name = "dot";
            dot.Size = new Size(75, 75);
            dot.TabIndex = 8;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += Dot_Click;
            // 
            // allClear
            // 
            allClear.BackColor = Color.FromArgb(235, 234, 235);
            allClear.FlatAppearance.BorderColor = Color.FromArgb(235, 234, 235);
            allClear.FlatAppearance.BorderSize = 0;
            allClear.FlatStyle = FlatStyle.Flat;
            allClear.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            allClear.ForeColor = Color.FromArgb(64, 64, 64);
            allClear.Location = new Point(0, 85);
            allClear.Name = "allClear";
            allClear.Size = new Size(113, 75);
            allClear.TabIndex = 9;
            allClear.Text = "AC";
            allClear.UseVisualStyleBackColor = false;
            allClear.Click += AllClear_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.FromArgb(234, 232, 232);
            clear.FlatAppearance.BorderColor = Color.FromArgb(234, 232, 232);
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            clear.ForeColor = Color.FromArgb(64, 64, 64);
            clear.Location = new Point(112, 85);
            clear.Name = "clear";
            clear.Size = new Size(113, 75);
            clear.TabIndex = 10;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += Clear_Click;
            // 
            // rightBracket
            // 
            rightBracket.BackColor = Color.FromArgb(237, 237, 234);
            rightBracket.FlatAppearance.BorderColor = Color.FromArgb(237, 237, 234);
            rightBracket.FlatAppearance.BorderSize = 0;
            rightBracket.FlatStyle = FlatStyle.Flat;
            rightBracket.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            rightBracket.ForeColor = Color.FromArgb(64, 64, 64);
            rightBracket.Location = new Point(149, 160);
            rightBracket.Name = "rightBracket";
            rightBracket.Size = new Size(75, 150);
            rightBracket.TabIndex = 11;
            rightBracket.Text = ")";
            rightBracket.UseVisualStyleBackColor = false;
            rightBracket.Click += RightBracket_Click;
            // 
            // leftBracket
            // 
            leftBracket.BackColor = Color.FromArgb(237, 237, 237);
            leftBracket.FlatAppearance.BorderColor = Color.FromArgb(237, 237, 237);
            leftBracket.FlatAppearance.BorderSize = 0;
            leftBracket.FlatStyle = FlatStyle.Flat;
            leftBracket.Font = new Font("Source Code Pro Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            leftBracket.ForeColor = Color.FromArgb(64, 64, 64);
            leftBracket.Location = new Point(74, 160);
            leftBracket.Name = "leftBracket";
            leftBracket.Size = new Size(75, 150);
            leftBracket.TabIndex = 12;
            leftBracket.Text = "(";
            leftBracket.UseVisualStyleBackColor = false;
            leftBracket.Click += LeftBracket_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(297, 385);
            Controls.Add(leftBracket);
            Controls.Add(rightBracket);
            Controls.Add(clear);
            Controls.Add(allClear);
            Controls.Add(dot);
            Controls.Add(input);
            Controls.Add(multyply);
            Controls.Add(plus);
            Controls.Add(division);
            Controls.Add(minus);
            Controls.Add(solution);
            Controls.Add(zero);
            Controls.Add(one);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(313, 424);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one;
        private Button zero;
        private Button solution;
        private Button minus;
        private Button division;
        private Button plus;
        private Button multyply;
        private TextBox input;
        private Button dot;
        private Button allClear;
        private Button clear;
        private Button rightBracket;
        private Button leftBracket;
    }
}
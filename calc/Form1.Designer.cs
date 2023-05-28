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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(one, "one");
            one.ForeColor = Color.FromArgb(64, 64, 64);
            one.Name = "one";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // zero
            // 
            resources.ApplyResources(zero, "zero");
            zero.ForeColor = Color.FromArgb(64, 64, 64);
            zero.Name = "zero";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // solution
            // 
            resources.ApplyResources(solution, "solution");
            solution.ForeColor = Color.FromArgb(64, 64, 64);
            solution.Name = "solution";
            solution.UseVisualStyleBackColor = true;
            solution.Click += solution_Click;
            // 
            // minus
            // 
            resources.ApplyResources(minus, "minus");
            minus.ForeColor = Color.FromArgb(64, 64, 64);
            minus.Name = "minus";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // division
            // 
            resources.ApplyResources(division, "division");
            division.ForeColor = Color.FromArgb(64, 64, 64);
            division.Name = "division";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // plus
            // 
            resources.ApplyResources(plus, "plus");
            plus.ForeColor = Color.FromArgb(64, 64, 64);
            plus.Name = "plus";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // multyply
            // 
            resources.ApplyResources(multyply, "multyply");
            multyply.ForeColor = Color.FromArgb(64, 64, 64);
            multyply.Name = "multyply";
            multyply.UseVisualStyleBackColor = true;
            multyply.Click += multyply_Click;
            // 
            // input
            // 
            input.BackColor = SystemColors.ButtonFace;
            input.BorderStyle = BorderStyle.FixedSingle;
            input.CausesValidation = false;
            resources.ApplyResources(input, "input");
            input.ForeColor = Color.FromArgb(64, 64, 64);
            input.Name = "input";
            input.ReadOnly = true;
            // 
            // dot
            // 
            resources.ApplyResources(dot, "dot");
            dot.ForeColor = Color.FromArgb(64, 64, 64);
            dot.Name = "dot";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // allClear
            // 
            resources.ApplyResources(allClear, "allClear");
            allClear.ForeColor = Color.FromArgb(64, 64, 64);
            allClear.Name = "allClear";
            allClear.UseVisualStyleBackColor = true;
            allClear.Click += allClear_Click;
            // 
            // clear
            // 
            resources.ApplyResources(clear, "clear");
            clear.ForeColor = Color.FromArgb(64, 64, 64);
            clear.Name = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // rightBracket
            // 
            resources.ApplyResources(rightBracket, "rightBracket");
            rightBracket.ForeColor = Color.FromArgb(64, 64, 64);
            rightBracket.Name = "rightBracket";
            rightBracket.UseVisualStyleBackColor = true;
            rightBracket.Click += rightBracket_Click;
            // 
            // leftBracket
            // 
            resources.ApplyResources(leftBracket, "leftBracket");
            leftBracket.ForeColor = Color.FromArgb(64, 64, 64);
            leftBracket.Name = "leftBracket";
            leftBracket.UseVisualStyleBackColor = true;
            leftBracket.Click += leftBracket_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
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
            Name = "Form1";
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
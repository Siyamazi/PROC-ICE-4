namespace calculater
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
            texDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnEquals = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnTimes = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // texDisplay
            // 
            texDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            texDisplay.Location = new Point(33, 52);
            texDisplay.Multiline = true;
            texDisplay.Name = "texDisplay";
            texDisplay.Size = new Size(268, 33);
            texDisplay.TabIndex = 0;
            texDisplay.TextChanged += texDisplay_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(33, 137);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 47);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(107, 137);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 47);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(180, 137);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 47);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(33, 190);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 45);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(107, 190);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 45);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(180, 190);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 45);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(33, 241);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 42);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(107, 241);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 42);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(180, 241);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 42);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(33, 289);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 37);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Lime;
            btnEquals.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(107, 291);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(139, 41);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ButtonHighlight;
            btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(252, 241);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(49, 91);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(252, 206);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(49, 29);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button14_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(252, 171);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(49, 29);
            btnTimes.TabIndex = 15;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(252, 137);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(49, 29);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 0, 0);
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(33, 91);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 40);
            btnClear.TabIndex = 17;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ButtonFace;
            lbl1.Location = new Point(52, 29);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 453);
            Controls.Add(lbl1);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnTimes);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEquals);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(texDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnTimes;
        private Button btnDivide;
        private Button btnClear;
        private Button button2;
        private Label lbl1;
    }
}

namespace WinFormsApp4
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
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n9 = new Button();
            n8 = new Button();
            n7 = new Button();
            n6 = new Button();
            n5 = new Button();
            n4 = new Button();
            n3 = new Button();
            n0 = new Button();
            clear = new Button();
            equal = new Button();
            sub = new Button();
            add = new Button();
            mul = new Button();
            div = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(32, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // n1
            // 
            n1.BackColor = SystemColors.ActiveCaptionText;
            n1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n1.ForeColor = Color.White;
            n1.Location = new Point(32, 118);
            n1.Name = "n1";
            n1.Size = new Size(94, 58);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = SystemColors.ActiveCaptionText;
            n2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n2.ForeColor = Color.White;
            n2.Location = new Point(132, 118);
            n2.Name = "n2";
            n2.Size = new Size(94, 58);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n9
            // 
            n9.BackColor = SystemColors.ActiveCaptionText;
            n9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n9.ForeColor = Color.White;
            n9.Location = new Point(232, 246);
            n9.Name = "n9";
            n9.Size = new Size(94, 58);
            n9.TabIndex = 4;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // n8
            // 
            n8.BackColor = SystemColors.ActiveCaptionText;
            n8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n8.ForeColor = Color.White;
            n8.Location = new Point(132, 246);
            n8.Name = "n8";
            n8.Size = new Size(94, 58);
            n8.TabIndex = 5;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n7
            // 
            n7.BackColor = SystemColors.ActiveCaptionText;
            n7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n7.ForeColor = Color.White;
            n7.Location = new Point(32, 246);
            n7.Name = "n7";
            n7.Size = new Size(94, 58);
            n7.TabIndex = 6;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n6
            // 
            n6.BackColor = SystemColors.ActiveCaptionText;
            n6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n6.ForeColor = Color.White;
            n6.Location = new Point(232, 182);
            n6.Name = "n6";
            n6.Size = new Size(94, 58);
            n6.TabIndex = 7;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n5
            // 
            n5.BackColor = SystemColors.ActiveCaptionText;
            n5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n5.ForeColor = Color.White;
            n5.Location = new Point(132, 182);
            n5.Name = "n5";
            n5.Size = new Size(94, 58);
            n5.TabIndex = 8;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n4
            // 
            n4.BackColor = SystemColors.ActiveCaptionText;
            n4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n4.ForeColor = Color.White;
            n4.Location = new Point(32, 182);
            n4.Name = "n4";
            n4.Size = new Size(94, 58);
            n4.TabIndex = 9;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n3
            // 
            n3.BackColor = SystemColors.ActiveCaptionText;
            n3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n3.ForeColor = Color.White;
            n3.Location = new Point(232, 118);
            n3.Name = "n3";
            n3.Size = new Size(94, 58);
            n3.TabIndex = 10;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n0
            // 
            n0.BackColor = SystemColors.ActiveCaptionText;
            n0.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            n0.ForeColor = Color.White;
            n0.Location = new Point(132, 310);
            n0.Name = "n0";
            n0.Size = new Size(94, 58);
            n0.TabIndex = 11;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.WindowFrame;
            clear.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Location = new Point(32, 310);
            clear.Name = "clear";
            clear.Size = new Size(94, 58);
            clear.TabIndex = 12;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.WindowFrame;
            equal.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            equal.ForeColor = SystemColors.ButtonHighlight;
            equal.Location = new Point(232, 310);
            equal.Name = "equal";
            equal.Size = new Size(94, 58);
            equal.TabIndex = 13;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.WindowFrame;
            sub.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            sub.ForeColor = SystemColors.ButtonHighlight;
            sub.Location = new Point(332, 182);
            sub.Name = "sub";
            sub.Size = new Size(94, 58);
            sub.TabIndex = 14;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += sub_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.WindowFrame;
            add.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(332, 118);
            add.Name = "add";
            add.Size = new Size(94, 58);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // mul
            // 
            mul.BackColor = SystemColors.WindowFrame;
            mul.Font = new Font("B Zar", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            mul.ForeColor = SystemColors.ButtonHighlight;
            mul.Location = new Point(332, 246);
            mul.Name = "mul";
            mul.Size = new Size(94, 58);
            mul.TabIndex = 16;
            mul.Text = "x";
            mul.UseVisualStyleBackColor = false;
            mul.Click += mul_Click;
            // 
            // div
            // 
            div.BackColor = SystemColors.WindowFrame;
            div.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            div.ForeColor = SystemColors.ButtonHighlight;
            div.Location = new Point(332, 310);
            div.Name = "div";
            div.Size = new Size(94, 58);
            div.TabIndex = 17;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(add);
            Controls.Add(sub);
            Controls.Add(equal);
            Controls.Add(clear);
            Controls.Add(n0);
            Controls.Add(n3);
            Controls.Add(n4);
            Controls.Add(n5);
            Controls.Add(n6);
            Controls.Add(n7);
            Controls.Add(n8);
            Controls.Add(n9);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n9;
        private Button n8;
        private Button n7;
        private Button n6;
        private Button n5;
        private Button n4;
        private Button n3;
        private Button n0;
        private Button clear;
        private Button equal;
        private Button sub;
        private Button add;
        private Button mul;
        private Button div;
    }
}
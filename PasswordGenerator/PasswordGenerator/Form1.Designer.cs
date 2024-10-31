namespace PasswordGenerator
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
            label1 = new Label();
            label2 = new Label();
            txtPasswordLength = new TextBox();
            chkUppercase = new CheckBox();
            chkLowerCase = new CheckBox();
            chkNumbers = new CheckBox();
            chkSymbols = new CheckBox();
            Generated = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 131);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 34);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 211);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 2;
            label2.Text = "Text Length";
            // 
            // txtPasswordLength
            // 
            txtPasswordLength.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordLength.Location = new Point(421, 199);
            txtPasswordLength.Name = "txtPasswordLength";
            txtPasswordLength.Size = new Size(177, 39);
            txtPasswordLength.TabIndex = 4;
            txtPasswordLength.KeyPress += txtPasswordLength_KeyPress;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.CheckAlign = ContentAlignment.MiddleRight;
            chkUppercase.Cursor = Cursors.Hand;
            chkUppercase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkUppercase.Location = new Point(421, 250);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(159, 25);
            chkUppercase.TabIndex = 5;
            chkUppercase.Text = "Include UpperCase";
            chkUppercase.TextAlign = ContentAlignment.MiddleCenter;
            chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            chkLowerCase.AutoSize = true;
            chkLowerCase.CheckAlign = ContentAlignment.MiddleRight;
            chkLowerCase.Cursor = Cursors.Hand;
            chkLowerCase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkLowerCase.Location = new Point(421, 281);
            chkLowerCase.Name = "chkLowerCase";
            chkLowerCase.Size = new Size(159, 25);
            chkLowerCase.TabIndex = 6;
            chkLowerCase.Text = "Include LowerCase";
            chkLowerCase.TextAlign = ContentAlignment.MiddleCenter;
            chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.CheckAlign = ContentAlignment.MiddleRight;
            chkNumbers.Cursor = Cursors.Hand;
            chkNumbers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkNumbers.Location = new Point(421, 312);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(148, 25);
            chkNumbers.TabIndex = 7;
            chkNumbers.Text = "Include Numbers";
            chkNumbers.TextAlign = ContentAlignment.MiddleCenter;
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.CheckAlign = ContentAlignment.MiddleRight;
            chkSymbols.Cursor = Cursors.Hand;
            chkSymbols.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkSymbols.Location = new Point(421, 343);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(143, 25);
            chkSymbols.TabIndex = 8;
            chkSymbols.Text = "Include Symbols";
            chkSymbols.TextAlign = ContentAlignment.MiddleCenter;
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // Generated
            // 
            Generated.ForeColor = SystemColors.ActiveCaptionText;
            Generated.Location = new Point(393, 395);
            Generated.Name = "Generated";
            Generated.Size = new Size(75, 23);
            Generated.TabIndex = 9;
            Generated.Text = "Generated";
            Generated.UseVisualStyleBackColor = true;
            Generated.Click += Generated_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(Generated);
            Controls.Add(chkSymbols);
            Controls.Add(chkNumbers);
            Controls.Add(chkLowerCase);
            Controls.Add(chkUppercase);
            Controls.Add(txtPasswordLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPasswordLength;
        private CheckBox chkUppercase;
        private CheckBox chkLowerCase;
        private CheckBox chkNumbers;
        private CheckBox chkSymbols;
        private Button Generated;
    }
}

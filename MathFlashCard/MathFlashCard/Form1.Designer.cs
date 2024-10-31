namespace MathFlashCard
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            panel1 = new Panel();
            lblSelect = new Label();
            lblWrongRight = new Label();
            lbloption1 = new Label();
            lbloption2 = new Label();
            lbloption3 = new Label();
            lbloption4 = new Label();
            lbloption5 = new Label();
            lbloption6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(254, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(218, 175);
            lbl1.TabIndex = 0;
            lbl1.Text = "11";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(249, 173);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(146, 175);
            lbl2.TabIndex = 1;
            lbl2.Text = "5";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(43, 184);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(107, 128);
            lbl3.TabIndex = 2;
            lbl3.Text = "x";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(9, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 10);
            panel1.TabIndex = 3;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelect.Location = new Point(101, 393);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(294, 50);
            lblSelect.TabIndex = 4;
            lblSelect.Text = "Select an answer";
            // 
            // lblWrongRight
            // 
            lblWrongRight.AutoSize = true;
            lblWrongRight.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWrongRight.Location = new Point(140, 351);
            lblWrongRight.Name = "lblWrongRight";
            lblWrongRight.Size = new Size(204, 32);
            lblWrongRight.TabIndex = 5;
            lblWrongRight.Text = "Select an answer";
            // 
            // lbloption1
            // 
            lbloption1.AutoSize = true;
            lbloption1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption1.Location = new Point(43, 454);
            lbloption1.Name = "lbloption1";
            lbloption1.Size = new Size(62, 50);
            lbloption1.TabIndex = 6;
            lbloption1.Text = "21";
            lbloption1.Click += lbloption_Click;
            // 
            // lbloption2
            // 
            lbloption2.AutoSize = true;
            lbloption2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption2.Location = new Point(199, 454);
            lbloption2.Name = "lbloption2";
            lbloption2.Size = new Size(62, 50);
            lbloption2.TabIndex = 7;
            lbloption2.Text = "21";
            lbloption2.Click += lbloption_Click;
            // 
            // lbloption3
            // 
            lbloption3.AutoSize = true;
            lbloption3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption3.Location = new Point(355, 454);
            lbloption3.Name = "lbloption3";
            lbloption3.Size = new Size(62, 50);
            lbloption3.TabIndex = 8;
            lbloption3.Text = "21";
            lbloption3.Click += lbloption_Click;
            // 
            // lbloption4
            // 
            lbloption4.AutoSize = true;
            lbloption4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption4.Location = new Point(43, 545);
            lbloption4.Name = "lbloption4";
            lbloption4.Size = new Size(62, 50);
            lbloption4.TabIndex = 9;
            lbloption4.Text = "21";
            lbloption4.Click += lbloption_Click;
            // 
            // lbloption5
            // 
            lbloption5.AutoSize = true;
            lbloption5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption5.Location = new Point(199, 545);
            lbloption5.Name = "lbloption5";
            lbloption5.Size = new Size(62, 50);
            lbloption5.TabIndex = 10;
            lbloption5.Text = "21";
            lbloption5.Click += lbloption_Click;
            // 
            // lbloption6
            // 
            lbloption6.AutoSize = true;
            lbloption6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbloption6.Location = new Point(355, 545);
            lbloption6.Name = "lbloption6";
            lbloption6.Size = new Size(62, 50);
            lbloption6.TabIndex = 11;
            lbloption6.Text = "21";
            lbloption6.Click += lbloption_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LawnGreen;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(110, 393);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 12;
            label1.Text = "Wanna play again?";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 640);
            Controls.Add(label1);
            Controls.Add(lbloption6);
            Controls.Add(lbloption5);
            Controls.Add(lbloption4);
            Controls.Add(lbloption3);
            Controls.Add(lbloption2);
            Controls.Add(lbloption1);
            Controls.Add(lblWrongRight);
            Controls.Add(lblSelect);
            Controls.Add(panel1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "FlashCards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Panel panel1;
        private Label lblSelect;
        private Label lblWrongRight;
        private Label lbloption1;
        private Label lbloption2;
        private Label lbloption3;
        private Label lbloption4;
        private Label lbloption5;
        private Label lbloption6;
        private Label label1;
    }
}

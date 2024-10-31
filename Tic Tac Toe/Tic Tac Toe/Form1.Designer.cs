namespace Tic_Tac_Toe
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
            panel1 = new Panel();
            btn9 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn1 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn3);
            panel1.Location = new Point(41, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 477);
            panel1.TabIndex = 0;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(511, 307);
            btn9.Name = "btn9";
            btn9.Size = new Size(234, 140);
            btn9.TabIndex = 9;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(255, 307);
            btn8.Name = "btn8";
            btn8.Size = new Size(234, 140);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(511, 161);
            btn6.Name = "btn6";
            btn6.Size = new Size(234, 140);
            btn6.TabIndex = 7;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(255, 161);
            btn5.Name = "btn5";
            btn5.Size = new Size(234, 140);
            btn5.TabIndex = 6;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(3, 15);
            btn1.Name = "btn1";
            btn1.Size = new Size(234, 140);
            btn1.TabIndex = 5;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(3, 307);
            btn7.Name = "btn7";
            btn7.Size = new Size(234, 140);
            btn7.TabIndex = 4;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(3, 161);
            btn4.Name = "btn4";
            btn4.Size = new Size(234, 140);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(255, 15);
            btn2.Name = "btn2";
            btn2.Size = new Size(234, 140);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 80.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(511, 15);
            btn3.Name = "btn3";
            btn3.Size = new Size(234, 140);
            btn3.TabIndex = 1;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(847, 517);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn9;
        private Button btn8;
        private Button btn6;
        private Button btn5;
        private Button btn1;
        private Button btn7;
        private Button btn4;
        private Button btn2;
        private Button btn3;
    }
}

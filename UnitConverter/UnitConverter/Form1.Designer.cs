namespace UnitConverter
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
            label1 = new Label();
            txtAmount = new TextBox();
            panel1 = new Panel();
            type = new Label();
            cbType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lstFrom = new ListBox();
            lstTo = new ListBox();
            Convert = new Button();
            panel2 = new Panel();
            txtCovertedAmount = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(224, 56);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(173, 23);
            txtAmount.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(99, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 118);
            panel1.TabIndex = 2;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Location = new Point(83, 162);
            type.Name = "type";
            type.Size = new Size(30, 15);
            type.TabIndex = 3;
            type.Text = "type";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(131, 159);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 4;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 218);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 218);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 6;
            label3.Text = "To";
            // 
            // lstFrom
            // 
            lstFrom.FormattingEnabled = true;
            lstFrom.ItemHeight = 15;
            lstFrom.Location = new Point(83, 246);
            lstFrom.Name = "lstFrom";
            lstFrom.Size = new Size(131, 139);
            lstFrom.TabIndex = 7;
            // 
            // lstTo
            // 
            lstTo.FormattingEnabled = true;
            lstTo.ItemHeight = 15;
            lstTo.Location = new Point(376, 246);
            lstTo.Name = "lstTo";
            lstTo.Size = new Size(131, 139);
            lstTo.TabIndex = 8;
            // 
            // Convert
            // 
            Convert.Location = new Point(259, 386);
            Convert.Name = "Convert";
            Convert.Size = new Size(75, 23);
            Convert.TabIndex = 9;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCovertedAmount);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(565, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 205);
            panel2.TabIndex = 3;
            // 
            // txtCovertedAmount
            // 
            txtCovertedAmount.Location = new Point(18, 108);
            txtCovertedAmount.Name = "txtCovertedAmount";
            txtCovertedAmount.Size = new Size(173, 23);
            txtCovertedAmount.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(32, 46);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 0;
            label4.Text = "Converted Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(Convert);
            Controls.Add(lstTo);
            Controls.Add(lstFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbType);
            Controls.Add(type);
            Controls.Add(txtAmount);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "UnitConverter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Panel panel1;
        private Label type;
        private ComboBox cbType;
        private Label label2;
        private Label label3;
        private ListBox lstFrom;
        private ListBox lstTo;
        private Button Convert;
        private Panel panel2;
        private TextBox txtCovertedAmount;
        private Label label4;
    }
}

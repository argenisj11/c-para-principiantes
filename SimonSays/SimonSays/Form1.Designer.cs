namespace SimonSays
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            label1 = new Label();
            timerDisplay = new System.Windows.Forms.Timer(components);
            LbScore = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(54, 23);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(706, 49);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Green;
            btn0.Location = new Point(140, 89);
            btn0.Name = "btn0";
            btn0.Size = new Size(264, 165);
            btn0.TabIndex = 1;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Blue;
            btn2.Location = new Point(140, 260);
            btn2.Name = "btn2";
            btn2.Size = new Size(264, 165);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Red;
            btn1.Location = new Point(410, 89);
            btn1.Name = "btn1";
            btn1.Size = new Size(264, 165);
            btn1.TabIndex = 3;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gold;
            btn3.Location = new Point(410, 260);
            btn3.Name = "btn3";
            btn3.Size = new Size(264, 165);
            btn3.TabIndex = 4;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 467);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 5;
            label1.Text = "Score";
            // 
            // timerDisplay
            // 
            timerDisplay.Tick += timerDisplay_Tick;
            // 
            // LbScore
            // 
            LbScore.AutoSize = true;
            LbScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbScore.Location = new Point(401, 467);
            LbScore.Name = "LbScore";
            LbScore.Size = new Size(19, 21);
            LbScore.TabIndex = 6;
            LbScore.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(LbScore);
            Controls.Add(label1);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Simion Says";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btn0;
        private Button btn2;
        private Button btn1;
        private Button btn3;
        private Label label1;
        private System.Windows.Forms.Timer timerDisplay;
        private Label LbScore;
    }
}

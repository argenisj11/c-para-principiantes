namespace filehander
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
            cbosystemDrives = new ComboBox();
            txtSystemDetails = new TextBox();
            label1 = new Label();
            btncratedirectory = new Button();
            textnewdirectory = new TextBox();
            txtsubdirectory = new TextBox();
            btnsubdirectorycreate = new Button();
            label2 = new Label();
            label3 = new Label();
            cbodirectoryfiles = new ComboBox();
            Show = new Button();
            panel1 = new Panel();
            btnCopydirectory = new Button();
            txtdirectorycopidestination = new TextBox();
            label6 = new Label();
            txtDirectorycopysource = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtNewFile = new TextBox();
            btnNewFile = new Button();
            label7 = new Label();
            txtselectedFile = new TextBox();
            Open = new Button();
            label8 = new Label();
            openFileDialog1 = new OpenFileDialog();
            txtRenemaFile = new TextBox();
            btnRename = new Button();
            label9 = new Label();
            txtwrite = new TextBox();
            label10 = new Label();
            btnwrite = new Button();
            btnReed = new Button();
            label11 = new Label();
            txtreed = new TextBox();
            btnFiend = new Button();
            label12 = new Label();
            txtfiend = new TextBox();
            Update = new Button();
            label13 = new Label();
            txtupdate = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbosystemDrives
            // 
            cbosystemDrives.FormattingEnabled = true;
            cbosystemDrives.Location = new Point(12, 21);
            cbosystemDrives.Name = "cbosystemDrives";
            cbosystemDrives.Size = new Size(342, 23);
            cbosystemDrives.TabIndex = 0;
            cbosystemDrives.SelectedIndexChanged += cbosystemDrives_SelectedIndexChanged;
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(12, 80);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(342, 239);
            txtSystemDetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(378, 12);
            label1.Name = "label1";
            label1.Size = new Size(183, 17);
            label1.TabIndex = 2;
            label1.Text = "New Directory (Include Path)";
            // 
            // btncratedirectory
            // 
            btncratedirectory.Location = new Point(823, 10);
            btncratedirectory.Name = "btncratedirectory";
            btncratedirectory.Size = new Size(75, 23);
            btncratedirectory.TabIndex = 3;
            btncratedirectory.Text = "Create";
            btncratedirectory.UseVisualStyleBackColor = true;
            btncratedirectory.Click += btncratedirectory_Click;
            // 
            // textnewdirectory
            // 
            textnewdirectory.Location = new Point(588, 11);
            textnewdirectory.Name = "textnewdirectory";
            textnewdirectory.Size = new Size(211, 23);
            textnewdirectory.TabIndex = 4;
            // 
            // txtsubdirectory
            // 
            txtsubdirectory.Location = new Point(588, 65);
            txtsubdirectory.Name = "txtsubdirectory";
            txtsubdirectory.Size = new Size(211, 23);
            txtsubdirectory.TabIndex = 7;
            // 
            // btnsubdirectorycreate
            // 
            btnsubdirectorycreate.Location = new Point(823, 64);
            btnsubdirectorycreate.Name = "btnsubdirectorycreate";
            btnsubdirectorycreate.Size = new Size(75, 23);
            btnsubdirectorycreate.TabIndex = 6;
            btnsubdirectorycreate.Text = "Create";
            btnsubdirectorycreate.UseVisualStyleBackColor = true;
            btnsubdirectorycreate.Click += btnsubdirectorycreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(378, 66);
            label2.Name = "label2";
            label2.Size = new Size(205, 17);
            label2.TabIndex = 5;
            label2.Text = "New SubDirectory (Include Path)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(378, 127);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 8;
            label3.Text = "Show directory files";
            // 
            // cbodirectoryfiles
            // 
            cbodirectoryfiles.FormattingEnabled = true;
            cbodirectoryfiles.Location = new Point(539, 121);
            cbodirectoryfiles.Name = "cbodirectoryfiles";
            cbodirectoryfiles.Size = new Size(260, 23);
            cbodirectoryfiles.TabIndex = 9;
            // 
            // Show
            // 
            Show.Location = new Point(823, 120);
            Show.Name = "Show";
            Show.Size = new Size(75, 23);
            Show.TabIndex = 10;
            Show.Text = "show";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopydirectory);
            panel1.Controls.Add(txtdirectorycopidestination);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDirectorycopysource);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(378, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 166);
            panel1.TabIndex = 11;
            // 
            // btnCopydirectory
            // 
            btnCopydirectory.Location = new Point(339, 12);
            btnCopydirectory.Name = "btnCopydirectory";
            btnCopydirectory.Size = new Size(138, 41);
            btnCopydirectory.TabIndex = 12;
            btnCopydirectory.Text = "Copy";
            btnCopydirectory.UseVisualStyleBackColor = true;
            btnCopydirectory.Click += btnCopydirectory_Click;
            // 
            // txtdirectorycopidestination
            // 
            txtdirectorycopidestination.Location = new Point(233, 113);
            txtdirectorycopidestination.Name = "txtdirectorycopidestination";
            txtdirectorycopidestination.Size = new Size(211, 23);
            txtdirectorycopidestination.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(23, 114);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 14;
            label6.Text = "Destination";
            label6.Click += label6_Click;
            // 
            // txtDirectorycopysource
            // 
            txtDirectorycopysource.Location = new Point(233, 71);
            txtDirectorycopysource.Name = "txtDirectorycopysource";
            txtDirectorycopysource.Size = new Size(211, 23);
            txtDirectorycopysource.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(23, 23);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 12;
            label4.Text = "Copy Directory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 72);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 12;
            label5.Text = "Source";
            // 
            // txtNewFile
            // 
            txtNewFile.Location = new Point(238, 350);
            txtNewFile.Name = "txtNewFile";
            txtNewFile.Size = new Size(211, 23);
            txtNewFile.TabIndex = 14;
            // 
            // btnNewFile
            // 
            btnNewFile.Location = new Point(492, 351);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(75, 23);
            btnNewFile.TabIndex = 13;
            btnNewFile.Text = "Create";
            btnNewFile.UseVisualStyleBackColor = true;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(28, 351);
            label7.Name = "label7";
            label7.Size = new Size(145, 17);
            label7.TabIndex = 12;
            label7.Text = "New File(Include Path)";
            // 
            // txtselectedFile
            // 
            txtselectedFile.Location = new Point(238, 383);
            txtselectedFile.Name = "txtselectedFile";
            txtselectedFile.Size = new Size(211, 23);
            txtselectedFile.TabIndex = 17;
            // 
            // Open
            // 
            Open.Location = new Point(492, 384);
            Open.Name = "Open";
            Open.Size = new Size(75, 23);
            Open.TabIndex = 16;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(28, 384);
            label8.Name = "label8";
            label8.Size = new Size(101, 17);
            label8.TabIndex = 15;
            label8.Text = "Select New File";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRenemaFile
            // 
            txtRenemaFile.Location = new Point(238, 415);
            txtRenemaFile.Name = "txtRenemaFile";
            txtRenemaFile.Size = new Size(211, 23);
            txtRenemaFile.TabIndex = 20;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(492, 416);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(75, 23);
            btnRename.TabIndex = 19;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(28, 416);
            label9.Name = "label9";
            label9.Size = new Size(82, 17);
            label9.TabIndex = 18;
            label9.Text = "Rename File";
            // 
            // txtwrite
            // 
            txtwrite.Location = new Point(45, 507);
            txtwrite.Multiline = true;
            txtwrite.Name = "txtwrite";
            txtwrite.Size = new Size(159, 65);
            txtwrite.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(80, 477);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 22;
            label10.Text = "Write";
            // 
            // btnwrite
            // 
            btnwrite.Location = new Point(80, 591);
            btnwrite.Name = "btnwrite";
            btnwrite.Size = new Size(75, 23);
            btnwrite.TabIndex = 23;
            btnwrite.Text = "Write";
            btnwrite.UseVisualStyleBackColor = true;
            btnwrite.Click += btnwrite_Click;
            // 
            // btnReed
            // 
            btnReed.Location = new Point(301, 591);
            btnReed.Name = "btnReed";
            btnReed.Size = new Size(75, 23);
            btnReed.TabIndex = 26;
            btnReed.Text = "Reed";
            btnReed.UseVisualStyleBackColor = true;
            btnReed.Click += btnReed_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(301, 477);
            label11.Name = "label11";
            label11.Size = new Size(37, 17);
            label11.TabIndex = 25;
            label11.Text = "Reed";
            // 
            // txtreed
            // 
            txtreed.Location = new Point(266, 507);
            txtreed.Multiline = true;
            txtreed.Name = "txtreed";
            txtreed.Size = new Size(159, 65);
            txtreed.TabIndex = 24;
            // 
            // btnFiend
            // 
            btnFiend.Location = new Point(527, 591);
            btnFiend.Name = "btnFiend";
            btnFiend.Size = new Size(75, 23);
            btnFiend.TabIndex = 29;
            btnFiend.Text = "Fiend";
            btnFiend.UseVisualStyleBackColor = true;
            btnFiend.Click += btnFiend_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(527, 477);
            label12.Name = "label12";
            label12.Size = new Size(34, 17);
            label12.TabIndex = 28;
            label12.Text = "Find";
            label12.Click += label12_Click;
            // 
            // txtfiend
            // 
            txtfiend.Location = new Point(492, 507);
            txtfiend.Multiline = true;
            txtfiend.Name = "txtfiend";
            txtfiend.Size = new Size(159, 65);
            txtfiend.TabIndex = 27;
            // 
            // Update
            // 
            Update.Location = new Point(731, 591);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 32;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(731, 477);
            label13.Name = "label13";
            label13.Size = new Size(50, 17);
            label13.TabIndex = 31;
            label13.Text = "Update";
            // 
            // txtupdate
            // 
            txtupdate.Location = new Point(696, 507);
            txtupdate.Multiline = true;
            txtupdate.Name = "txtupdate";
            txtupdate.Size = new Size(159, 65);
            txtupdate.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 657);
            Controls.Add(Update);
            Controls.Add(label13);
            Controls.Add(txtupdate);
            Controls.Add(btnFiend);
            Controls.Add(label12);
            Controls.Add(txtfiend);
            Controls.Add(btnReed);
            Controls.Add(label11);
            Controls.Add(txtreed);
            Controls.Add(btnwrite);
            Controls.Add(label10);
            Controls.Add(txtwrite);
            Controls.Add(txtRenemaFile);
            Controls.Add(btnRename);
            Controls.Add(label9);
            Controls.Add(txtselectedFile);
            Controls.Add(Open);
            Controls.Add(label8);
            Controls.Add(txtNewFile);
            Controls.Add(btnNewFile);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(Show);
            Controls.Add(cbodirectoryfiles);
            Controls.Add(label3);
            Controls.Add(txtsubdirectory);
            Controls.Add(btnsubdirectorycreate);
            Controls.Add(label2);
            Controls.Add(textnewdirectory);
            Controls.Add(btncratedirectory);
            Controls.Add(label1);
            Controls.Add(txtSystemDetails);
            Controls.Add(cbosystemDrives);
            Name = "Form1";
            Text = "FileHander";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbosystemDrives;
        private TextBox txtSystemDetails;
        private Label label1;
        private Button btncratedirectory;
        private TextBox textnewdirectory;
        private TextBox txtsubdirectory;
        private Button btnsubdirectorycreate;
        private Label label2;
        private Label label3;
        private ComboBox cbodirectoryfiles;
        private Button Show;
        private Panel panel1;
        private TextBox txtdirectorycopidestination;
        private Label label6;
        private TextBox txtDirectorycopysource;
        private Label label4;
        private Label label5;
        private Button btnCopydirectory;
        private TextBox txtNewFile;
        private Button btnNewFile;
        private Label label7;
        private TextBox txtselectedFile;
        private Button Open;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private TextBox txtRenemaFile;
        private Button btnRename;
        private Label label9;
        private TextBox txtwrite;
        private Label label10;
        private Button btnwrite;
        private Button btnReed;
        private Label label11;
        private TextBox txtreed;
        private Button btnFiend;
        private Label label12;
        private TextBox txtfiend;
        private Button Update;
        private Label label13;
        private TextBox txtupdate;
    }
}

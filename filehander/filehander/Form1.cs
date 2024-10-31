using System.Reflection.PortableExecutable;
using System.Windows.Forms;

namespace filehander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemdrives();
        }

        private void PopulateSystemdrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cbosystemDrives.Items.Add(drive);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbosystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cbosystemDrives.SelectedItem.ToString();
                DriveInfo diskinfo = new DriveInfo(disk);
                var drivedetails = $@"
                drive:{disk} drive
                total size: {diskinfo.TotalSize}
                free spece avialable: {diskinfo.AvailableFreeSpace}
                format: {diskinfo.DriveFormat}
                type: {diskinfo.DriveType}

                ";
                txtSystemDetails.Text = drivedetails;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void btncratedirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textnewdirectory.Text))
                {
                    throw new Exception("please enter a path for the directory");
                }
                if (!Directory.Exists(textnewdirectory.Text))
                {
                    Directory.CreateDirectory(textnewdirectory.Text);
                    MessageBox.Show("directory create");
                }
                else
                {

                    MessageBox.Show("please, enter de new path of the new directory ");
                }
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void btnsubdirectorycreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textnewdirectory.Text))
                {
                    throw new Exception("Make sure you have include a directory path on new directory ");

                }
                if (string.IsNullOrEmpty(textnewdirectory.Text))
                {
                    throw new Exception("Make sure you have include a directory path on new  sub directory ");
                }
                var directorypath = textnewdirectory.Text;

                var subdirinfo = new DirectoryInfo(directorypath);
                subdirinfo.CreateSubdirectory(txtsubdirectory.Text);
                MessageBox.Show("SubDirectory Has Been Created");







            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }

        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textnewdirectory.Text))
                {
                    throw new Exception("Make sure you have include a directory path on new directory ");

                }
                var directory = textnewdirectory.Text;
                var directoryinfo = new DirectoryInfo(directory);
                if (!directoryinfo.Exists)
                    throw new Exception("directory not exists");

                var subdirectories = directoryinfo.GetDirectories();
                foreach (var subdir in subdirectories)
                {
                    if (!cbodirectoryfiles.Items.Contains(subdir.Name))
                        cbodirectoryfiles.Items.Add(subdir.Name);
                }

                var files = directoryinfo.GetFiles("*");
                foreach (var file in files)
                {
                    if (!cbodirectoryfiles.Items.Contains(file.Name))
                        cbodirectoryfiles.Items.Add(file.Name);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCopydirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDirectorycopysource.Text) || string.IsNullOrEmpty(txtdirectorycopidestination.Text))
                    throw new Exception("source or destination fileds should have values ");
                var soueceDirectory = new DirectoryInfo(txtDirectorycopysource.Text);
                var destinationDirectory = new DirectoryInfo(txtdirectorycopidestination.Text);
                copy(soueceDirectory, destinationDirectory);
                MessageBox.Show("directory copy success");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void copy(DirectoryInfo source, DirectoryInfo destination)
        {

            try
            {
                if (!source.Exists)
                    throw new Exception("source directory dosen't exist");
                if (!destination.Exists)
                    destination.Create();
                var files = source.GetFiles();
                foreach (var file in files)
                {

                    file.CopyTo(Path.Combine(destination.FullName, file.Name));
                }
                var directorys = source.GetDirectories();
                foreach (var directory in directorys)
                {
                    string destianationcopy = Path.Combine(destination.FullName, directory.Name);
                    copy(directory, new DirectoryInfo(destianationcopy));
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                {
                    throw new Exception("please enter a path for the File");
                }
                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File create");
                }
                else
                {

                    MessageBox.Show("please, enter de new path of the new File ");
                }
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtselectedFile.Text = openFileDialog1.FileName;
                    txtRenemaFile.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                var source = txtselectedFile.Text;
                var destination = txtRenemaFile.Text;
                var sourcefileinfo = new FileInfo(source);
                if (sourcefileinfo.Exists)
                {
                    sourcefileinfo.MoveTo(destination);
                    MessageBox.Show("file has been Renamed");
                }
                else
                {
                    MessageBox.Show("Error when trying rename file. Is the path correct ");

                }

            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtselectedFile.Text))
                    throw new Exception("Make sure you selected the file. ");
                if (!File.Exists(txtselectedFile.Text))
                {
                    throw new Exception("selected file dosen't exist");
                }

                FileStream fs = new FileStream(txtselectedFile.Text, FileMode.Create, FileAccess.Write);
                StreamWriter ws = new StreamWriter(fs);
                ws.WriteLine(txtwrite.Text);
                ws.Flush();
                fs.Close();
                MessageBox.Show("your content has been wrote");



            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }

        }

        private void btnReed_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtselectedFile.Text))
                    throw new Exception("Make sure you selected the file. ");
                if (!File.Exists(txtselectedFile.Text))
                {
                    throw new Exception("selected file dosen't exist");
                }

                FileStream fs = new FileStream(txtselectedFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader ws = new StreamReader(fs);
                txtreed.Text = ws.ReadToEnd();

                fs.Close();
                MessageBox.Show("Reed");



            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void btnFiend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtselectedFile.Text))
                    throw new Exception("Make sure you selected the file. ");
                if (!File.Exists(txtselectedFile.Text))
                {
                    throw new Exception("selected file dosen't exist");
                }

                FileStream fs = new FileStream(txtselectedFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader ws = new StreamReader(fs);
                var content = ws.ReadToEnd();
                int i = content.IndexOf(txtfiend.Text.Trim(), 0);
                if (i > -1)
                {
                    MessageBox.Show("the string is present in the file ");
                }
                else
                {
                    MessageBox.Show("the string wasn't found in the file");
                }




            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtselectedFile.Text))
                    throw new Exception("Make sure you selected the file. ");
                if (!File.Exists(txtselectedFile.Text))
                {
                    throw new Exception("selected file dosen't exist");

                }

                var path = txtselectedFile.Text;
                var sw = File.AppendText(path);
                sw.WriteLine(txtupdate.Text);
                sw.Close();

                MessageBox.Show("file contents appended successfully ");



            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }

        }
    }
}

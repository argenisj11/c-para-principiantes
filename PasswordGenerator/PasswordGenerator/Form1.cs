namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        static string Uppercaselist = "ABCDEFJGHIJKLMNOPQRSTUVXYZ";
        static string Lowercaselisst = Uppercaselist.ToLower();
        static string numberslist = "123456789";
        static string sysmbolslist = "!#$%&/()=?°¡";

        string allcharslist = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtPasswordLength.Text = "20";
        }

        private void buildlist()
        {
            allcharslist = "";
            if (chkUppercase.Checked)
                allcharslist += Uppercaselist;
            if (chkLowerCase.Checked)
                allcharslist += Lowercaselisst;
            if (chkNumbers.Checked)
                allcharslist += numberslist;
            if (chkSymbols.Checked)
                allcharslist += sysmbolslist;
            if (string.IsNullOrEmpty(allcharslist))
            {
                allcharslist = Uppercaselist + Lowercaselisst + numberslist + sysmbolslist;
            }
        }
        private string GeneratePassword(int length)
        {
            string NewPassword = "";
            if (length <= 6)
            {
                throw new Exception("You needs to have more than 6 caracteres");
            }
            for (int i = 0; i < length; i++)
            {
                NewPassword += GetRandomchar();
            }

            return NewPassword;
        }

        private string GetRandomchar()
        {
            return allcharslist.ToCharArray()[(int)Math.Floor(_random.NextDouble() * allcharslist.Length)].ToString();
        }

        private void Generated_Click(object sender, EventArgs e)
        {
            try
            {
                buildlist();
                textBox1.Text = GeneratePassword(int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPasswordLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& (e.KeyChar!='.'))
            {
                e.Handled = true;
            }
        }
    }
}

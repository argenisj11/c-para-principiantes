namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    { 
        private bool iscircle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
            {
                return; 
            }
            settex((Button)sender);
            checkResult(((Button)sender).Text);
        }

        private void checkResult(string player)
        {
            bool thereIsAWinner=false;
            if (!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                thereIsAWinner = true;
            }
            if (!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn2.Text) && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn3.Text) && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn3.Text) && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn4.Text) && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                thereIsAWinner = true;
            }

            if (!string.IsNullOrEmpty(btn7.Text) && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                thereIsAWinner = true;
            }

            if (thereIsAWinner)
            {
                SetWinner(player);
            }

        }
        private void SetWinner(String player)
        {
            var response =   MessageBox.Show($"player {player} won! wanna play again?","Tic Tac Toe",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                reset();
            }
            else
            {
                this.Close();
            }
        }

        private void settex(Button btn)
        {
            btn.Text = iscircle ? "O" : "X";
            iscircle = !iscircle;
            btn.Enabled = false;
        }

        private void reset()
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty; 
            btn3.Text = string.Empty; 
            btn4.Text = string.Empty; 
            btn5.Text = string.Empty; 
            btn6.Text = string.Empty; 
            btn7.Text = string.Empty; 
            btn8.Text = string.Empty; 
            btn9.Text = string.Empty;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

    }
}

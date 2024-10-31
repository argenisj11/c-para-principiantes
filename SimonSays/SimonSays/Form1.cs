using System.Media;
using System.Reflection;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        List<int> _Simonsays = new List<int>();
        List<int> _selectedSimonSays = new List<int>();
        Random random = new Random();
        int _CurrentDislpayIndex = 0;
        SoundPlayer _Player = new SoundPlayer();
        int _score = 0;


        public Form1()
        {
            InitializeComponent();
            timerDisplay.Interval = 1000;
            LbScore.Text = string.Empty;
        }

        private void AddNewSimonValue()
        {
            _Simonsays.Add(GenerateNewSimonvalue());

        }

        private int GenerateNewSimonvalue()
        {
            return random.Next(0, 4);
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            ResetSelectedValue();
            if (_CurrentDislpayIndex == _Simonsays.Count())
            {
                timerDisplay.Stop();
            }
            else
            {
                DisplaySelectedValue(_Simonsays[_CurrentDislpayIndex], false);
                _CurrentDislpayIndex++;
            }
        }
        private void AddNew()
        {
            AddNewSimonValue();
            timerDisplay.Start();
        }
        private void ResetSelectedValue()
        {
            if (_CurrentDislpayIndex > 0)
            {
                DisplaySelectedValue(_Simonsays[_CurrentDislpayIndex - 1], true);
            }
        }
        private void DisplaySelectedValue(int value, bool reset)
        {
            var SoundEfecct = string.Empty;

            switch (value)
            {
                case 0:
                    btn0.BackColor = reset ? Color.Green : Color.LightGreen;
                    SoundEfecct = "simonSound1.wav";
                    break;
                case 1:
                    btn1.BackColor = reset ? Color.Red : Color.LightCoral;
                    SoundEfecct = "simonSound2.wav";
                    break;
                case 2:
                    btn2.BackColor = reset ? Color.Blue : Color.LightBlue;
                    SoundEfecct = "simonSound3.wav";
                    break;
                case 3:
                    btn3.BackColor = reset ? Color.Gold : Color.Yellow;
                    SoundEfecct = "simonSound4.wav";
                    break;

                default:
                    break;
            }

            if (!reset)
            {
                _Player.SoundLocation = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Resource\\{SoundEfecct}";
                _Player.Play();

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;
            var btn = (Button)sender;
            int selectedindex = int.Parse( btn.Name.Substring(3, 1));
            DisplaySelectedValue(selectedindex, false);
            _selectedSimonSays.Add(selectedindex);
            if(_Simonsays.Count() == _selectedSimonSays.Count())
            {
                if (AreListEqual())
                {
                    _selectedSimonSays.Clear();
                    _CurrentDislpayIndex = 0;
                    _score++;
                    LbScore.Text = _score.ToString();
                    AddNew(); 

                }
                else
                {
                   var respose = MessageBox.Show(this, "Wrong! Wanna Play Again?", "Game Over", MessageBoxButtons.YesNo);
                    if (respose==DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {

            }
            DisplaySelectedValue(selectedindex, false);
        }
        private bool AreListEqual()
        {
            for (int i = 0; i < _Simonsays.Count(); i++)
            {
                if (_Simonsays[i] != _selectedSimonSays[i])
                    return false;
                
                
            }
            return true;
        }
        private void Reset()
        {
            _selectedSimonSays.Clear();
            _Simonsays.Clear();
            _CurrentDislpayIndex = 0;
            _score= 0;
            LbScore.Text = string.Empty;
        }
    }
}

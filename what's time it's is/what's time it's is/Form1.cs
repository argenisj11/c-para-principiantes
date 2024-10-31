using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace what_s_time_it_s_is
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime1.Text = DateTime.Now.ToString("HH:mm");
            lblseg1.Text = DateTime.Now.ToString("ss");
            lbldate1.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblday1.Text = DateTime.Now.ToString("dddd");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var Easterndate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lbltime2.Text = Easterndate.ToString("HH:mm");
            lblseg2.Text = Easterndate.ToString("ss");
            lbldate2.Text = Easterndate.ToString("MMM dd yyyy");
            lblday2.Text = Easterndate.ToString("dddd");

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            var Easterndate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lbltime3.Text = Easterndate.ToString("HH:mm");
            lblseg3.Text = Easterndate.ToString("ss");
            lbldate3.Text = Easterndate.ToString("MMM dd yyyy");
            lblday3.Text = Easterndate.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            var Easterndate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lbltime4.Text = Easterndate.ToString("HH:mm");
            lblseg4.Text = Easterndate.ToString("ss");
            lbldate4.Text = Easterndate.ToString("MMM dd yyyy");
            lblday4.Text = Easterndate.ToString("dddd");
        }
    }
}

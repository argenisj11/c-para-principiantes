namespace MemoryGame
{
    public partial class Form1 : Form
    {
        List<Icon>_Icons = new List<Icon>();
        public Form1()
        {
            InitializeComponent();
            showcards(true);
        }

        private void showcards(bool showcards)
        {

            pnlcover1.Visible = !showcards;
            pnlcover2.Visible = !showcards;
            pnlcover3.Visible = !showcards;
            pnlcover4.Visible = !showcards;
            pnlcover5.Visible = !showcards;
            pnlcover6.Visible = !showcards;
            pnlcover7.Visible = !showcards;
            pnlcover8.Visible = !showcards;
            pnlcover9.Visible = !showcards;
            pnlcover10.Visible = !showcards;
            pnlcover11.Visible = !showcards;
            pnlcover12.Visible = !showcards;
            pnlcover13.Visible = !showcards;
            pnlcover14.Visible = !showcards;
            pnlcover15.Visible = !showcards;
            pnlcover16.Visible = !showcards;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            showcards(false);
            timer1.Dispose();
        }
    }
}

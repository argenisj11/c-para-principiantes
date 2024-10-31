using System.Security.AccessControl;

namespace MathFlashCard
{
    public partial class Form1 : Form
    {
        private int _number1, _number2;
        private Random random = new Random();
        private OperationEnum _Operation;
        private int _resul;

        public Form1()
        {
            InitializeComponent();
            initScreen();
        }

        private void initScreen()
        {
            label1.Visible = false;
            lblWrongRight.Text = string.Empty;
            lblSelect.Visible = true;
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            lbloption5.Visible = true;
            lbloption6.Visible = true;
            setnumbers();
            setoperation();
            setanswers();
        }

        private void setnumbers()
        {


            _number1 = random.Next(1, 20);

            _number2 = random.Next(1, 20);

            lbl1.Text = _number1.ToString();
            lbl2.Text = _number2.ToString();

        }

        private void setoperation()
        {

            var enumvalues = Enum.GetValues(typeof(OperationEnum));
            _Operation = (OperationEnum)enumvalues.GetValue(random.Next(enumvalues.Length));

            lbl3.Text = _Operation.GetSymbol();



        }


        private void setanswers()
        {
            _resul = _Operation.getResul(_number1, _number2);

            var values = new List<int>()
            {
            _resul+1,_resul+2,_resul-3, _resul ,_resul-1,_resul-2
            };

            var options = new List<int>()
            {
                1,2,3,4,5,6
            };
            for (int i = 0; i < 6; i++)
            {
                var randomlabel = options[random.Next(0, options.Count())];
                var randomvalues = values[random.Next(0, values.Count())];
                values.Remove(randomvalues);
                options.Remove(randomlabel);
                setOptions(randomlabel, randomvalues);


            }

        }

        private void setOptions(int randomlabel, int randomvalues)
        {
            switch (randomlabel)
            {
                case 1:
                    lbloption1.Text = randomvalues.ToString();
                    break;
                case 2:
                    lbloption2.Text = randomvalues.ToString();
                    break;
                case 3:
                    lbloption3.Text = randomvalues.ToString();
                    break;
                case 4:
                    lbloption4.Text = randomvalues.ToString();
                    break;
                case 5:
                    lbloption5.Text = randomvalues.ToString();
                    break;
                case 6:
                    lbloption6.Text = randomvalues.ToString();
                    break;
            }
        }

        private void lbloption_Click(object sender, EventArgs e)
        {
            if (sender is not Label)
                return;

            var selectedvalue = int.Parse(((Label)sender).Text);

            if (selectedvalue == _resul)
            {
                lblWrongRight.Text = "Correct";
                lblWrongRight.ForeColor = Color.Green;
                label1.Visible = true;
            }
            else
            {
                lblWrongRight.Text = "Wrong!";
                lblWrongRight.ForeColor = Color.Red;
                ((Label)sender).Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            initScreen();
        }
    }

}

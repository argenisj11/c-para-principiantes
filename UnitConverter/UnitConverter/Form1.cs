using System.Diagnostics;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private ConvertedService _convertedService;
        public Form1()
        {
            InitializeComponent();

            _convertedService = new ConvertedService();
            cbType.DataSource = Enum.GetValues(typeof(typeEnum));
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valor = (typeEnum)cbType.SelectedItem;
            switch (valor)
            {
                case typeEnum.Mass:
                    lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
                    break;
                case typeEnum.Temperature:
                    lstFrom.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    break;
                case typeEnum.Time:
                    lstFrom.DataSource = Enum.GetValues(typeof(timeEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(timeEnum));
                    break;

            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            txtCovertedAmount.Text = "";
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                return;
            }
            if (lstFrom.SelectedItem==lstTo.SelectedItem)
            {
                txtCovertedAmount.Text = txtAmount.Text;
                
            }

            var type = (typeEnum)cbType.SelectedItem;
            double amount = double.Parse(txtAmount.Text);
            double convertedAmount=0;

            switch(type) 
            {
                case typeEnum.Mass:

                    convertedAmount = _convertedService.ConvertMassUnit((MassEnum)lstFrom.SelectedItem, (MassEnum)lstTo.SelectedItem,amount);
                    break;
                case typeEnum.Temperature:
                    convertedAmount = _convertedService.ConvertTemperatureUnit((TemperatureEnum)lstFrom.SelectedItem, (TemperatureEnum)lstTo.SelectedItem, amount);
                    break;
                case typeEnum.Time:
                    convertedAmount = _convertedService.ConvertTimeUnit((timeEnum)lstFrom.SelectedItem, (timeEnum)lstTo.SelectedItem, amount);
                    break;



            }
            txtCovertedAmount.Text=convertedAmount.ToString();
        }
    }
}

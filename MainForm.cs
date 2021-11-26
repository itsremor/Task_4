using System;
using System.Globalization;
using System.Windows.Forms;

namespace Task_4
{
    public partial class MainForm : Form
    {
        private string _type = "ComputerNetwork";
        private string _title;
        private int _numberStations;
        private double _averageDistance;
        private double _speed;

        public MainForm()
        {
            InitializeComponent();
            TypeComboBox.Items.Add(_type);
            TypeComboBox.Items.Add("SpeedComputerNetwork");
            TypeComboBox.SelectedIndex = 0;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _type = TypeComboBox.SelectedItem.ToString();
            if (_type == "ComputerNetwork")
            {
                Controls.Remove(SpeedLabel);
                Controls.Remove(SpeedTextBox);
            }
            else
            {
                Controls.Add(SpeedLabel);
                Controls.Add(SpeedTextBox);
            }

            Console.WriteLine(Controls);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _title = TitleTextBox.Text;
        }

        private void NumberStationsTextBox_TextChanged(object sender, EventArgs e)
        {
            _numberStations = int.Parse(NumberStationsTextBox.Text);
        }

        private void AverageDistanceTextBox_TextChanged(object sender, EventArgs e)
        {
            _averageDistance = double.Parse(AverageDistanceTextBox.Text);
        }

        private void SpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            _speed = double.Parse(SpeedTextBox.Text);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var instance = _type == "ComputerNetwork"
                ? new ComputerNetwork(_title, _numberStations, _averageDistance)
                : new SpeedComputerNetwork(
                    _title, _numberStations, _averageDistance, _speed
                );
            QLabel.Text = instance.Q().ToString(CultureInfo.InvariantCulture);
        }
    }
}

namespace Practice_3.Programming_Problems
{
    public partial class CelsiusFahrenheit : Form
    {
        public CelsiusFahrenheit()
        {
            Console.WriteLine("Hello WORLD.");
            InitializeComponent();
        }

        private void convertTemp() {
            if (txtb_Temperature.Text == "" || txtb_Temperature.Text == "-") { return; }
            try
            {
                double temp = double.Parse(txtb_Temperature.Text);

                if (radBtt_Fahrenheit.Checked)
                {
                    var newTemp = ((9/5 * temp) + 32);
                    lb_Display.Text = $"{newTemp}° Fahrenheit";

                }
                else if (radBtt_Celsius.Checked)
                {
                    var newTemp = ((temp - 32) * (5 / 9));

                    lb_Display.Text = $"{newTemp}° Celsius";
                }

            }
            catch (Exception ex)
            {
                lb_Display.Text = "Keep on slaying.";
                MessageBox.Show(ex.Message);
            }
        }

        private void txtb_Temperature_TextChanged(object sender, EventArgs e)
        {
            convertTemp();
        }

        private void radBtt_Celsius_CheckedChanged(object sender, EventArgs e)
        {
            lb_Scale.Text = "°F";
            convertTemp();
        }

        private void radBtt_Fahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lb_Scale.Text = "°C";
            convertTemp();
        }
    }
}

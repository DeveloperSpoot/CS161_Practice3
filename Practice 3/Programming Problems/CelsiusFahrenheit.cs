namespace Practice_3.Programming_Problems
{
    public partial class CelsiusFahrenheit : Form
    {
        public CelsiusFahrenheit()
        {
            InitializeComponent();
        }

        private void convertTemp() {
            if (txtb_Temperature.Text == "" || txtb_Temperature.Text == "-") { return; }
            try
            {
                double temp = double.Parse(txtb_Temperature.Text);

                if (radBtt_Fahrenheit.Checked)
                {
                    //f = (9/2*C) + 32
                   
                    double newTemp = (9.0/5.0) * temp + 32;
                    lb_Display.Text = newTemp.ToString("F") + "° Fahrenheit";

                }
                else if (radBtt_Celsius.Checked)
                {
                    // c = 5/9 * (f-32)
                    double newTemp = ((temp - 32) * 0.55555555555);


                    lb_Display.Text = newTemp.ToString("F")+"° Celsius";
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

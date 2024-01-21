namespace Practice_3
{
    public partial class SingleStepping : Form
    {
        public SingleStepping()
        {
            InitializeComponent();
        }

        private void btt_Calc_Click(object sender, EventArgs e)
        {
            double r1 = double.Parse(txtb_R1.Text);
            double r2 = double.Parse(txtb_R2.Text);
            double r3 = double.Parse(txtb_R3.Text);

            double average = (r1 + r2 + r3) / 3.0;

            lb_Display.Text = average.ToString("n1");
        }

        private void btt_Clear_Click(object sender, EventArgs e)
        {
            txtb_R1.Text = "";
            txtb_R2.Text = "";
            txtb_R3.Text = "";
            lb_Display.Text = "";
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

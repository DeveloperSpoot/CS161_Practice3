namespace Practice_3
{
    public partial class FuelEcon : Form
    {
        public FuelEcon()
        {
            InitializeComponent();
        }

        private void btt_MPG_Click(object sender, EventArgs e)
        {
            try
            {

            lb_MPG.Text = $"{int.Parse(txtb_Miles.Text)/int.Parse(txtb_Gas.Text)}";
            }catch 
            {
                MessageBox.Show("Invalid data was entered.");
            }
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

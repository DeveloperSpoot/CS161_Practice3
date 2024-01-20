namespace Practice_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btt_BirthDate_Click(object sender, EventArgs e)
        {
            BirthDate form = new BirthDate();
            form.Show();
        }

        private void btt_FuelEcon_Click(object sender, EventArgs e)
        {
            FuelEcon form = new FuelEcon();
            form.Show();
        }

        private void btt_SalePrice_Click(object sender, EventArgs e)
        {
            SalePrice form = new SalePrice();
            form.Show();
        }

        private void btt_TestAvg_Click(object sender, EventArgs e)
        {
            TestAverage form = new TestAverage();
            form.Show();
        }

        private void btt_ChangeCounter_Click(object sender, EventArgs e)
        {

        }

        private void btt_SingleStep_Click(object sender, EventArgs e)
        {

        }
    }
}

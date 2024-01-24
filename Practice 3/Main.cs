using Practice_3.Programming_Problems;

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
            ChangeCounter form = new ChangeCounter();
            form.Show();
        }

        private void btt_SingleStep_Click(object sender, EventArgs e)
        {
            SingleStepping form = new SingleStepping();
            form.Show();
        }

        private void btt_NameFormatter_Click(object sender, EventArgs e)
        {
            NameFormatter form = new NameFormatter();
            form.Show();
        }

        private void btt_TipTaxTotal_Click(object sender, EventArgs e)
        {
            TipTaxTotal form = new TipTaxTotal();
            form.Show();
        }

        private void btt_DistanceTraveled_Click(object sender, EventArgs e)
        {
            DistanceTraveled form = new DistanceTraveled();
            form.Show();
        }

        private void btt_SalesTaxTotal_Click(object sender, EventArgs e)
        {
            TipTaxTotal form = new TipTaxTotal();
            form.Show();
        }

        private void btt_CelsiusFahrenheit_Click(object sender, EventArgs e)
        {
            CelsiusFahrenheit form = new CelsiusFahrenheit();
            form.Show();
        }

        private void btt_IngredientAdjuster_Click(object sender, EventArgs e)
        {

        }
    }
}

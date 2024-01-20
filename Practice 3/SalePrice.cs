namespace Practice_3
{
    public partial class SalePrice : Form
    {
        public SalePrice()
        {
            InitializeComponent();
        }

        private void btt_Calculate_Click(object sender, EventArgs e)
        {

            decimal ogPrice = decimal.Parse(txtb_Price.Text);
            decimal discountPrecent = decimal.Parse(txtb_Precent.Text);
            decimal discountAmount;
            decimal salePrice;

            discountPrecent = discountPrecent / 100;

            discountAmount = ogPrice * discountPrecent;

            salePrice = ogPrice - discountAmount;

            lb_SalePrice.Text = salePrice.ToString("c");
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

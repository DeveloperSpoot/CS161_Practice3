namespace Practice_3.Programming_Problems
{
    public partial class TipTaxTotal : Form
    {
        public TipTaxTotal()
        {
            InitializeComponent();
        }

        private void btt_Total_Click(object sender, EventArgs e)
        {
            try
            {
                decimal bill = decimal.Parse(txtb_Bill.Text);
                decimal tip = bill * (decimal.Parse(txtb_Tip.Text)/100);
                decimal tax = bill * (decimal.Parse(txtb_Tax.Text)/100);

                lb_Display.Text = $"{(bill + tip + tax).ToString("c")}";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
    }
}

namespace Practice_3.Programming_Problems
{
    public partial class IngredientAdjuster : Form
    {
        public IngredientAdjuster()
        {
            InitializeComponent();
        }

        decimal surgarPerCookie = 1.50m / 48m;
        decimal butterPerCookie = 1m / 48m;
        decimal flourPerCookie = 2.75m / 48m;

        private void txtb_CookiesAmount_TextChanged(object sender, EventArgs e)
        {

            if(txtb_CookiesAmount.Text == "") { return; }

            try
            {
                decimal cookiesNeeded = decimal.Parse(txtb_CookiesAmount.Text);

                decimal surgarNeeded = surgarPerCookie*cookiesNeeded;
                decimal butterNeeded = butterPerCookie*cookiesNeeded;
                decimal flourNeeded = flourPerCookie*cookiesNeeded;

                lb_Sugar.Text = surgarNeeded.ToString("F");
                lb_Butter.Text = butterNeeded.ToString("F");
                lb_Flour.Text = flourNeeded.ToString("F");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

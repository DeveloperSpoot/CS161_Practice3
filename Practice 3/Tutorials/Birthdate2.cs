namespace Practice_3.Tutorials
{
    public partial class Birthdate2 : Form
    {
        public Birthdate2()
        {
            InitializeComponent();
        }

        private string DateString = "";

        private void btt_ShowDate_Click(object sender, EventArgs e)
        {
            DateString = $"{txtb_day.Text}, {txtb_Month.Text} {txtb_nDay.Text}, {txtb_Year.Text}";
            dateDisplay.Text = DateString;
        }

        private void btt_Clear_Click(object sender, EventArgs e)
        {
            txtb_day.Clear();
            txtb_Month.Clear();
            txtb_nDay.Clear();
            txtb_Year.Clear();
            dateDisplay.Text = "";
            DateString = "";
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Birthdate2_Load(object sender, EventArgs e)
        {

        }
    }
}

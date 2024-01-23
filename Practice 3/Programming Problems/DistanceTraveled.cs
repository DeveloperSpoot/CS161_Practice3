namespace Practice_3.Programming_Problems
{
    public partial class DistanceTraveled : Form
    {
        public DistanceTraveled()
        {
            InitializeComponent();
        }

        private void calculateDistance(int MpH = 0, int TimeDriven = 0)
        {
            lb_Display.Text = $"Traveled {(MpH*TimeDriven)} Miles";
        }

        private void btt_Calculate_Click(object sender, EventArgs e)
        {

            try
            {
                int milesPerHour = int.Parse(txtb_Mph.Text);
                int timeDriven = int.Parse(txtb_Time.Text);

                calculateDistance(milesPerHour, timeDriven);
            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_5hours_Click(object sender, EventArgs e)
        {
            try
            {
                int milesPerHour = int.Parse(txtb_Mph.Text);

                calculateDistance(milesPerHour, 5);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_8hours_Click(object sender, EventArgs e)
        {
            try
            {
                int milesPerHour = int.Parse(txtb_Mph.Text);

                calculateDistance(milesPerHour, 8);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_12hours_Click(object sender, EventArgs e)
        {
            try
            {
                int milesPerHour = int.Parse(txtb_Mph.Text);

                calculateDistance(milesPerHour, 12);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

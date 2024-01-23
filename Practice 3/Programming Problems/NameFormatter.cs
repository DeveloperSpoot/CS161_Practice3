namespace Practice_3.Programming_Problems
{
    public partial class NameFormatter : Form
    {
        public NameFormatter()
        {
            InitializeComponent();
      
        }


        private void combo_Field1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = txtb_Title.Text;
            string  first = txtb_First.Text;
            string  middle = txtb_Middle.Text;
            string last = txtb_Last.Text;

            switch (combo_Field1.SelectedIndex)
            {
                case 0:
                    if(title == "" || first == "" || middle == "" || last == "")
                    {
                      MessageBox.Show("Please make sure all fields are answered.");
                        return;
                    }
                    lb_Display.Text = $"{title}. {first} {middle} {last}";
                    break;
                case 1:
                    if (first == "" || middle == "" || last == "")
                    {
                        MessageBox.Show("Please make sure fields first, middle, last, are all answered.");
                        return;
                    }
                    lb_Display.Text = $"{first} {middle} {last}";
                    break;
                case 2:
                    if (first == "" || last == "")
                    {
                        MessageBox.Show("Please make sure fields first, last, are all answered.");
                        return;
                    }
                    lb_Display.Text = $"{first} {last}";
                    break;
                case 3:
                    if (title == "" || first == "" || middle == "" || last == "")
                    {
                        MessageBox.Show("Please make sure all fields are answered.");
                        return;
                    }
                    lb_Display.Text = $"{last}, {first} {middle}, {title}.";
                    break;
                case 4:
                    if (first == "" || middle == "" || last == "")
                    {
                        MessageBox.Show("Please make sure fields first, middle, last, are all answered.");
                        return;
                    }
                    lb_Display.Text = $"{last}, {first} {middle}";
                    break;
                case 5:
                    if (first == "" || last == "")
                    {
                        MessageBox.Show("Please make sure fields first, last, are all answered.");
                        return;
                    }
                    lb_Display.Text = $"{last}, {first}";
                    break;
            }
        }
    }
}

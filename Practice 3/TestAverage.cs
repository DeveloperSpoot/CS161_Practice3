using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3
{
    public partial class TestAverage : Form
    {
        public TestAverage()
        {
            InitializeComponent();
        }

        private void btt_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                lb_Average.Text = ((double.Parse(txtb_Test1.Text) + double.Parse(txtb_Test2.Text) + double.Parse(txtb_Test3.Text)) / 3.0).ToString("n1");

            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btt_Clear_Click(object sender, EventArgs e)
        {
            txtb_Test1.Text = "";
            txtb_Test2.Text = "";
            txtb_Test3.Text = "";
            lb_Average.Text = "";
;        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

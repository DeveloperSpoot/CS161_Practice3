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
    public partial class FuelEcon : Form
    {
        public FuelEcon()
        {
            InitializeComponent();
        }

        private void btt_MPG_Click(object sender, EventArgs e)
        {
            lb_MPG.Text = $"{int.Parse(txtb_Miles.Text)/int.Parse(txtb_Gas.Text)}";
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

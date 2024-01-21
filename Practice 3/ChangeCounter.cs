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
    public partial class ChangeCounter : Form
    {
        public ChangeCounter()
        {
            InitializeComponent();
        }

        const decimal fiveCents = 0.05m;
        const decimal tenCents = 0.10m;
        const decimal twentyFiveCents = .25m;
        const decimal fiftyCents = .50m;

        private decimal total = 0m;

        private void picb_fiveCents_Click(object sender, EventArgs e)
        {
            total += fiveCents;
            lb_Display.Text = total.ToString("C");
        }

        private void picb_tenCents_Click(object sender, EventArgs e)
        {
            total += tenCents;
            lb_Display.Text = total.ToString("C");
        }

        private void picb_twentyfiveCents_Click(object sender, EventArgs e)
        {
            total += twentyFiveCents;
            lb_Display.Text = total.ToString("C");
        }

        private void picb_fiftyCents_Click(object sender, EventArgs e)
        {
            total += fiftyCents;
            lb_Display.Text = total.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

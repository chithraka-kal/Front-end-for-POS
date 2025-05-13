using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end_for_POS
{
    public partial class startnewtask: Form
    {
        public startnewtask()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
        /*saving for the petty cash processes*/
            this.Close();
            Technicaldashboard Technicaldashboard = new Technicaldashboard();
            Technicaldashboard.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Technicaldashboard Technicaldashboard = new Technicaldashboard();
            Technicaldashboard.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

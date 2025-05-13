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
    public partial class Technicaldashboard: Form
    {
        public Technicaldashboard()
        {
            InitializeComponent();
        }

        private void btnstarttask_Click(object sender, EventArgs e)
        {
            this.Hide();
            startnewtask startnewtask = new startnewtask();
            startnewtask.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pettycashrequestform pettycashrequestform = new pettycashrequestform();
            pettycashrequestform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnrequeststock_Click(object sender, EventArgs e)
        {

        }
    }
}

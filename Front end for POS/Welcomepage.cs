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
    public partial class Loginselectionform: Form
    {
        public Loginselectionform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginstocks Loginstocks = new Loginstocks();
            Loginstocks.Show();

        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginsales Loginsales = new Loginsales();
            Loginsales.Show();
        }

        private void Loginselectionform_Load(object sender, EventArgs e)
        {

        }

        private void btntechnical_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logintechnical Logintechnical = new Logintechnical();
            Logintechnical.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmanagement_Click(object sender, EventArgs e)
        {

        }
    }
}

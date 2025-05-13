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
    public partial class salesdashboard: Form
    {
        public salesdashboard()
        {
            InitializeComponent();
        }

        private void btnadvancedpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customerselect Customerselect = new Customerselect();
            Customerselect.Show();
        }

        private void btnsalesman_Click(object sender, EventArgs e)
        {
            Salesmanselct Salesmanselect = new Salesmanselct();
            Salesmanselect.Show();

        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Customerselect Customerselect = new Customerselect();
            Customerselect.Show();
        }

        private void btnshiftclose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure??");
            this.Close();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Itemsearch Itemsearch = new Itemsearch();
            Itemsearch.Show();
        }
    }
}

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
    public partial class Itemsearch: Form
    {
        public Itemsearch()
        {
            InitializeComponent();
        }

        private void Itemsearch_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
        

        private void btnselectitem_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesdashboard salesdashboard = new salesdashboard();
            salesdashboard.Show();
        }
    }
}

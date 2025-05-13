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
    public partial class Loginsales: Form
    {
        public Loginsales()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string enteredUsername=txtusername.Text;
            string enteredPassword=txtpassword.Text;

            string correctUsername = "Admin";
            string correctpassword = "1234";
            if (enteredUsername == correctUsername && enteredPassword==correctpassword)
            {
                this.Hide();
                salesdashboard salesdashboard = new salesdashboard();
                salesdashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginselectionform Loginselectionform = new Loginselectionform();
            Loginselectionform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loginsales_Load(object sender, EventArgs e)
        {

        }
    }
}

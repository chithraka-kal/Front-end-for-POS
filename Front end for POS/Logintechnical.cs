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
    public partial class Logintechnical: Form
    {
        public Logintechnical()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtusername.Text;
            string enteredPassword = txtpassword.Text;

            string correctUsername = "Admin";
            string correctpassword = "1234";
            if (enteredUsername == correctUsername && enteredPassword == correctpassword)
            {
                this.Hide();
                Technicaldashboard Technicaldashboard = new Technicaldashboard();
                Technicaldashboard.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginselectionform Loginselelectionform = new Loginselectionform();
            Loginselelectionform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

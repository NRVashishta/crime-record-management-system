using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crime_record_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname, upass, user, pass; 
            uname = "1"; upass = "1";
            user = textBox1.Text;
            pass = textBox2.Text;
            //MessageBox.Show("login success "+ user+" "+pass);
            if (user.Equals(uname) && pass.Equals(upass))
            {
                //login
                label4.Hide();
                MessageBox.Show("login success");
            }
            else
            {
                //dont login
                label4.Show();
            }
        }
    }
}

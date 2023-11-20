
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        mainform frm1 = new mainform();

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mona135")
            {
                frm1.Show();
                this.Hide();
            }
                

            else
                MessageBox.Show("Incorrect Password, Please try again!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }
    }
}

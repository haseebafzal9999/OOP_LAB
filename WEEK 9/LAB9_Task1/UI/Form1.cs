using LAB9_Task1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {

                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                checkBox1.Checked = false;
                this.Hide();
            }
            else if(checkBox2.Checked)
            {
                SignUP signup = new SignUP();
                signup.Show();
                checkBox2.Checked = false;
                this.Hide();

            }
        }
    }
}

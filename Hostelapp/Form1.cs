using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostelapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsign_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;
            bool allEmpty = Extensions.IsNotEmpty(new string[]
            {
                email,password
            }, String.Empty);
            if (allEmpty)
            {

            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Butun xanalari doldurun";
            }
        }
    }
}

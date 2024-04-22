using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //txtDetails.Text = txtDetails.Text + "\n" + txtName.Text;
            string details = "rerer";
            txtDetails.Text = txtName.Text;


            if (rbBCA.Checked)
            {               
                txtDetails.Text += "\r\n"  + rbBCA.Text;
            }
            else if (rbBCIT.Checked)
            {
                txtDetails.Text += "\r\n" + rbBCIT.Text;
            }

        }
    }
}

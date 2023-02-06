using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess.Operations;
using DatabaseAccess.StorageData;

namespace newdesign
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtUPassword.Text.Trim() != txtCUPassword.Text.Trim())
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if(txtUPassword.Text.Trim().Length < 8 || txtCUPassword.Text.Trim().Length > 16)
            {
                MessageBox.Show("Password must be between 8 to 16 characters.");
            }
            else
            {
                StoreData store3 = new StoreData();
                store3.UName = txtUpUName.Text.Trim();
                store3.Password = txtUPassword.Text.Trim();

                OpSignUP updPswrd1 = new OpSignUP();
                updPswrd1.ConnectData3(store3);

                MessageBox.Show("Password updated successfully.");

                txtUPassword.Text = "";
                txtCUPassword.Text = "";
            }
        }

        private void txtCUPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtCUPassword.Text.Trim() == txtUPassword.Text.Trim())
            {
                txtCUPassword.ForeColor = Color.Black;
            }
            else
            {
                txtCUPassword.ForeColor = Color.Red;
            }
        }

        private void btnUpPasAd_Click(object sender, EventArgs e)
        {
            if (txtUPassword.Text.Trim() != txtCUPassword.Text.Trim())
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if (txtUPassword.Text.Trim().Length < 8 || txtCUPassword.Text.Trim().Length > 16)
            {
                MessageBox.Show("Password must be between 8 to 16 characters.");
            }
            else
            {
                StoreData strAUPas = new StoreData();
                strAUPas.UName = txtUpUName.Text.Trim();
                strAUPas.Password = txtUPassword.Text.Trim();


                OpSignUP upPasAd = new OpSignUP();
                upPasAd.ConnectDataAdUPas2(strAUPas);

                MessageBox.Show("Password updated successfully");

                txtUPassword.Text = "";
                txtCUPassword.Text = "";
            } 
        }

        private void btnupSigninU_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}

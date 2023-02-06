using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess.StorageData;
using DatabaseAccess.Operations;

namespace newdesign
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void txtCpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtupPassword.Text.Trim() == txtCpassword.Text.Trim())
            {
                txtCpassword.ForeColor = Color.Black;
            }
            else
            {
                txtCpassword.ForeColor = Color.Red;
            }
        }

        private void btnupSignUp_Click(object sender, EventArgs e)
        {
            StoreData store1 = new StoreData();
            store1.FName = txtFullName.Text.Trim();
            store1.Email = txtEmail.Text.Trim();
            store1.UName = txtupUserName.Text.Trim();
            store1.Password = txtupPassword.Text.Trim();
            
            if(rdbtnMale.Checked)
            {
                store1.Gender = rdbtnMale.Text.Trim();
            }
            else
            {
                store1.Gender = rdbtnFemale.Text.Trim();
            }

            if((((((txtFullName.Text.Equals("") || txtEmail.Text.Equals("")) || txtupUserName.Text.Equals("")) || txtupPassword.Text.Equals("")) || txtCpassword.Text.Equals("")) || (rdbtnMale.Checked.Equals(false) && rdbtnFemale.Checked.Equals(false))) || checkBox1.Checked.Equals(false))
            {
                MessageBox.Show("Please fill up all required information.");
            }
            else if(txtupPassword.Text.Trim().Length < 8 || txtupPassword.Text.Trim().Length > 16)
            {
                MessageBox.Show("Password must be between 8 to 16 characters.");
            }
            else if(txtupPassword.Text.Trim() != txtCpassword.Text.Trim())
            {
                MessageBox.Show("Please confirm your password.");
            }
            else
            {
                OpSignUP signupIn1 = new OpSignUP();
                
                if(signupIn1.ConnectData1(store1).Equals(true))
                {
                    MessageBox.Show("Account created successfully.");
                }
                else
                {
                    MessageBox.Show("Username already exist.");
                }
            }
        }

        private void btnupSignin_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}

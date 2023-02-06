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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            lnlblEmp.Visible = false;
            lnlblAdmin.Visible = true;
            btninSigninAdm.Visible = false;
            btninSigninEmp.Visible = true;
            lnlblFrAd.Visible = false;
            fgPassword.Visible = true;
        }

        private void btnPassShow_Click(object sender, EventArgs e)
        {
            txtinPassword.PasswordChar = '\0';
            btnPassShow.Visible = false;
            btnPassHide.Visible = true;
        }

        private void btnPassHide_Click(object sender, EventArgs e)
        {
            txtinPassword.PasswordChar = '*';
            btnPassHide.Visible = false;
            btnPassShow.Visible = true;
        }

        private void btninSignUp_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void fgPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StoreData store3 = new StoreData();
            store3.UName = txtinUserName.Text.Trim();

            OpSignUP opSingUp1 = new OpSignUP();

            if(opSingUp1.ConnectData4(store3).Equals(true))
            {
                UpdatePassword upsd1 = new UpdatePassword();
                upsd1.txtUpUName.Text = txtinUserName.Text.Trim();
                upsd1.btnUpPasAd.Visible = false;
                upsd1.btnUpPass.Visible = true;
                upsd1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid username first.");
            }
        }

        private void lnlblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtinUserName.Text = "";
            txtinPassword.Text = "";

            lblHaveAcc.Visible = false;
            btninSignUp.Visible = false;
            lnlblEmp.Visible = true;
            lnlblAdmin.Visible = false;
            btninSigninEmp.Visible = false;
            btninSigninAdm.Visible = true;
            fgPassword.Visible = false;
            lnlblFrAd.Visible = true;
        }

        private void lnlblEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtinUserName.Text = "";
            txtinPassword.Text = "";

            lblHaveAcc.Visible = true ;
            btninSignUp.Visible = true;
            lnlblAdmin.Visible = true ;
            lnlblEmp.Visible = false ;
            btninSigninAdm.Visible = false;
            btninSigninEmp.Visible = true;
            lnlblFrAd.Visible = false;
            fgPassword.Visible = true;
        }

        private void btninSigninEmp_Click(object sender, EventArgs e)
        {
            StoreData store2 = new StoreData();
            store2.UName = txtinUserName.Text.Trim();
            store2.Password = txtinPassword.Text.Trim();

            OpSignUP login1 = new OpSignUP();
            if (login1.ConnectData2(store2).Equals(true))
            {
                WelcomeForm wlcFrmEmp = new WelcomeForm();
                wlcFrmEmp.btnEdtMenu.Visible = false;
                wlcFrmEmp.btnMenuAd.Visible = false;
                wlcFrmEmp.btnMenuEmp.Visible = true;
                wlcFrmEmp.btnAbout.Location = new Point(31, 313);
                wlcFrmEmp.btnMenu.Visible = true;
                wlcFrmEmp.btnMenuEmp.Visible = false;
                wlcFrmEmp.btnAdAbout.Visible = false;
                wlcFrmEmp.btnAbout.Visible = true;
                wlcFrmEmp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your given data.");
            }
        }

        private void btninSigninAdm_Click(object sender, EventArgs e)
        {
            StoreData strA = new StoreData();
            strA.UName = txtinUserName.Text.Trim();
            strA.Password = txtinPassword.Text.Trim();

            OpSignUP opSignUpAd = new OpSignUP();

            if(opSignUpAd.ConnectDataAdminSignIn(strA).Equals(true)) {
                WelcomeForm wlcFrmAd = new WelcomeForm();
                wlcFrmAd.btnEdtMenu.Visible = true;
                wlcFrmAd.btnMenuEmp.Visible = false;
                wlcFrmAd.btnMenuAd.Visible = true;
                wlcFrmAd.btnMenu.Visible = false;
                wlcFrmAd.btnAdAbout.Visible = true;
                wlcFrmAd.btnAbout.Visible = false;
                wlcFrmAd.btnAbout.Location = new Point(31, 389);
                wlcFrmAd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your given data.");
            }
        }

        private void lnlblFrAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StoreData strB = new StoreData();
            strB.UName = txtinUserName.Text.Trim();

            OpSignUP opSignUpFAd = new OpSignUP();
            
            if(opSignUpFAd.ConnectDataAdminUPas1(strB).Equals(true))
            {
                UpdatePassword upsdAd = new UpdatePassword();
                upsdAd.txtUpUName.Text = txtinUserName.Text.Trim();
                upsdAd.btnUpPass.Visible = false;
                upsdAd.btnUpPasAd.Visible = true;
                upsdAd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid username first.");
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

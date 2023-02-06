using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newdesign
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       private void movesidepanel(Button btn)
        {
            panelMove.Top = btn.Top;
            panelMove.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            movesidepanel(btnHome);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            movesidepanel(btnMenu);
            MenuForm obj1 = new MenuForm();
            obj1.btnBackHomeAdm.Visible = false;
            obj1.btnBckHome.Visible = true;
            obj1.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            movesidepanel(btnAbout);
            Aboutus objAbEmp = new Aboutus();
            objAbEmp.btnBackAboutEmp.Visible = true;
            objAbEmp.btnBackAboutAd.Visible = false;
            objAbEmp.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void btnAdAbout_Click(object sender, EventArgs e)
        {
            movesidepanel(btnAbout);
            Aboutus objAbEmp = new Aboutus();
            objAbEmp.btnBackAboutEmp.Visible = false;
            objAbEmp.btnBackAboutAd.Visible = true;
            objAbEmp.Show();
            this.Hide();
        }

        private void btnMenuAd_Click(object sender, EventArgs e)
        {
            movesidepanel(btnMenuAd);
            MenuForm obj1 = new MenuForm();
            obj1.btnBackHomeAdm.Visible = true;
            obj1.btnBckHome.Visible = false;
            obj1.Show();
            this.Hide();
        }

        private void btnEdtMenu_Click(object sender, EventArgs e)
        {
            movesidepanel(btnEdtMenu);
            new EditMenu().Show();
            this.Hide();
        }

        private void btnMenuEmp_Click(object sender, EventArgs e)
        {
            movesidepanel(btnMenuEmp);
            MenuForm obj2 = new MenuForm();
            obj2.btnBackHomeAdm.Visible = false;
            obj2.btnBckHome.Visible = true;
            obj2.Show();
            this.Hide();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This is homepage.", btnHome);
        }
    }
}


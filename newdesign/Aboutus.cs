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
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
        }
        private void btnBackAbout_Click(object sender, EventArgs e)
        {
            WelcomeForm objAd = new WelcomeForm();
            objAd.btnMenuEmp.Visible = false;
            objAd.btnMenuAd.Visible = true;
            objAd.btnEdtMenu.Visible = true;
            objAd.btnAbout.Visible = false;
            objAd.btnAdAbout.Location = new Point(31, 389);
            objAd.btnAdAbout.Visible = true;
            objAd.Show();
            this.Hide();
        }

        private void btnBackAboutEmp_Click(object sender, EventArgs e)
        {
            WelcomeForm objEmp = new WelcomeForm();
            objEmp.btnMenuEmp.Visible = true;
            objEmp.btnMenuAd.Visible = false;
            objEmp.btnEdtMenu.Visible = false;
            objEmp.btnAbout.Visible = true;
            objEmp.btnAdAbout.Visible = false;
            objEmp.btnAbout.Location = new Point(31, 313);
            objEmp.Show();
            this.Hide();
        }
    }
}

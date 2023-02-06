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
using System.Data.SqlClient;

namespace newdesign
{
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }

        private void btnAddItm_Click(object sender, EventArgs e)
        {
            StoreItem strItmAdd = new StoreItem();
            strItmAdd.ItemId = txtIDAd.Text.Trim();
            strItmAdd.ItemCategory = cmbAdCtgry.Text.Trim();
            strItmAdd.ItemName = txtItmAd.Text.Trim();
            strItmAdd.ItemPrice = txtPrcAd.Text.Trim();

            OpItem addItm = new OpItem();

            if ((((txtIDAd.Text.Trim().Equals("") || cmbAdCtgry.Text.Trim().Equals("")) || txtItmAd.Text.Trim().Equals("")) || txtPrcAd.Text.Trim().Equals("")))
            {
                MessageBox.Show("Please enter required data.");
            }
            else if(addItm.ConnectAddItem(strItmAdd).Equals(true))
            {
                txtIDAd.Text = "";
                cmbAdCtgry.Items.Clear();
                txtItmAd.Text = "";
                txtPrcAd.Text = "";
                MessageBox.Show("Item added successfully.");
            }  
            else
            {
                MessageBox.Show("Item already exist.");
            }
        }

        private void btnUpdItm_Click(object sender, EventArgs e)
        {
            StoreItem strItmUpdt = new StoreItem();
            strItmUpdt.ItemId = txtIDAd.Text.Trim();
            strItmUpdt.ItemCategory = cmbAdCtgry.Text.Trim();
            strItmUpdt.ItemName = txtItmAd.Text.Trim();
            strItmUpdt.ItemPrice = txtPrcAd.Text.Trim();

            OpItem updtItm = new OpItem();
            

            if ((((txtIDAd.Text.Trim().Equals("") || cmbAdCtgry.Text.Trim().Equals("")) || txtItmAd.Text.Trim().Equals("")) || txtPrcAd.Text.Trim().Equals("")))
            {
                MessageBox.Show("Please enter required data.");
            }
            else if(updtItm.ConnectUpdateItemSelect(strItmUpdt).Equals(true))
            {
                updtItm.ConnectUpdateItem(strItmUpdt);
                txtIDAd.Text = "";
                cmbAdCtgry.Items.Clear();
                txtItmAd.Text = "";
                txtPrcAd.Text = "";
                MessageBox.Show("Item updated successfully");
            }
            else
            {
                MessageBox.Show("Invalid item id.");
            }
        }

        private void btnShwItm_Click(object sender, EventArgs e)
        {
            OpItem addItm = new OpItem();

            SqlDataAdapter sda1 = addItm.ConnectShowItem();
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            gridVwShowItmAd.DataSource = dt1;
        }

        private void btnRmvItm_Click(object sender, EventArgs e)
        {
            StoreItem strItmDlt = new StoreItem();
            strItmDlt.ItemId = txtIDAd.Text.Trim();

            OpItem rmvItm = new OpItem();

            if (txtIDAd.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter item id first.");
            }
            else if(rmvItm.ConnectRemoveItemSelect(strItmDlt).Equals(true))
            {
                rmvItm.ConnectRemoveItem(strItmDlt);

                txtIDAd.Text = "";
                cmbAdCtgry.Items.Clear();
                txtItmAd.Text = "";
                txtPrcAd.Text = "";
                MessageBox.Show("Item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Invalid item id.");
            }
        }

        private void btnBackAd_Click(object sender, EventArgs e)
        {
            WelcomeForm objBackEd = new WelcomeForm();
            objBackEd.btnEdtMenu.Visible = true;
            objBackEd.btnEdtMenu.Visible = true;
            objBackEd.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new EditMenu().Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Refresh", pictureBox2);
        }
    }
}

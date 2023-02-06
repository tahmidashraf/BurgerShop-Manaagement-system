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
using DGVPrinterHelper;

namespace newdesign
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnEdMenu_Click(object sender, EventArgs e)
        {
            new EditMenu().Show();
            this.Hide();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem.Items.Clear();

            StoreItem strItm1 = new StoreItem();
            strItm1.ItemCategory = cmbCategory.Text.Trim();

            OpItem itmListOp1 = new OpItem();
            DataSet dts1 = itmListOp1.ConnectShowItemList(strItm1);

            for(int i = 0; i < dts1.Tables[0].Rows.Count; i++)
            {
                MenuItem.Items.Add(dts1.Tables[0].Rows[i][0].ToString());
            }
        }

        private void MenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtPrice.Clear();
            txtItmName.Clear();
            txtTotal.Clear();
            txtItmName.Text = MenuItem.SelectedItem.ToString();

            StoreItem strPrice1 = new StoreItem();
            strPrice1.ItemName = MenuItem.SelectedItem.ToString();

            OpItem opFillPrice = new OpItem();
            DataSet dts2 = opFillPrice.ConnectFillUpTxt(strPrice1);
            txtPrice.Text = dts2.Tables[0].Rows[0][0].ToString();
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            int subTtl1 = Convert.ToInt32(txtPrice.Text);
            int subTtl2 = Convert.ToInt32(txtQuantity.Value);
            int totalPrc = subTtl1 * subTtl2;
            txtTotal.Text = totalPrc.ToString();
        }

        int n, total = 0, fnlTotal;

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                n = DataGridView.Rows.Add();

                DataGridView.Rows[n].Cells[0].Value = txtItmName.Text.Trim();
                DataGridView.Rows[n].Cells[1].Value = txtPrice.Text.Trim();
                DataGridView.Rows[n].Cells[2].Value = txtQuantity.Text.Trim();
                DataGridView.Rows[n].Cells[3].Value = txtTotal.Text.Trim();

                total = total + int.Parse(txtTotal.Text.Trim());
                lblGTotal.Text = total + " TK";
            }
            
            catch(Exception)
            {
                MessageBox.Show("Please enter quantity.");
            }
        }

  

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + lblGTotal.Text.Trim();
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DataGridView);

            total = 0;
            DataGridView.Rows.Clear();
            lblGTotal.Text = total + " TK"; 


        }

        private void btnBckHome_Click(object sender, EventArgs e)
        {
            WelcomeForm objWc1 = new WelcomeForm();
            objWc1.btnMenuAd.Visible = false;
            objWc1.btnMenuEmp.Visible = true;
            objWc1.btnEdtMenu.Visible = false;
            objWc1.btnAbout.Visible = true;
            objWc1.btnAdAbout.Visible = false;
            objWc1.btnAbout.Location = new Point(31, 313);
            objWc1.Show();
            this.Hide();
        }

        private void btnBackHomeAdm_Click(object sender, EventArgs e)
        {
            WelcomeForm objWc2 = new WelcomeForm();
            objWc2.btnMenuAd.Visible = true;
            objWc2.btnMenuEmp.Visible = false;
            objWc2.btnEdtMenu.Visible = true;
            objWc2.btnAdAbout.Visible = true;
            objWc2.btnAbout.Visible = false;
            objWc2.btnAdAbout.Location = new Point(31, 389);
            objWc2.Show();
            this.Hide();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fnlTotal = int.Parse(DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("You're about to remove an item.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView.Rows.RemoveAt(this.DataGridView.SelectedRows[0].Index);
            }
            catch(Exception)
            {
                MessageBox.Show("There is no item to remove from cart.");
            }

            total -= fnlTotal;
            lblGTotal.Text = total + " TK";
        }
    }
}

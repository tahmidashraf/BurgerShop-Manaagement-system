
namespace newdesign
{
    partial class EditMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
            this.txtIDAd = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShwItm = new Guna.UI.WinForms.GunaButton();
            this.gridVwShowItmAd = new Guna.UI.WinForms.GunaDataGridView();
            this.txtPrcAd = new Guna.UI.WinForms.GunaTextBox();
            this.btnRmvItm = new Guna.UI.WinForms.GunaButton();
            this.btnUpdItm = new Guna.UI.WinForms.GunaButton();
            this.txtItmAd = new Guna.UI.WinForms.GunaTextBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.cmbAdCtgry = new Guna.UI.WinForms.GunaComboBox();
            this.btnAddItm = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCtgry = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackAd = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVwShowItmAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDAd
            // 
            this.txtIDAd.BaseColor = System.Drawing.Color.White;
            this.txtIDAd.BorderColor = System.Drawing.Color.Silver;
            this.txtIDAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDAd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIDAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIDAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDAd.Location = new System.Drawing.Point(241, 28);
            this.txtIDAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDAd.Name = "txtIDAd";
            this.txtIDAd.PasswordChar = '\0';
            this.txtIDAd.SelectedText = "";
            this.txtIDAd.Size = new System.Drawing.Size(197, 37);
            this.txtIDAd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShwItm
            // 
            this.btnShwItm.AnimationHoverSpeed = 0.07F;
            this.btnShwItm.AnimationSpeed = 0.03F;
            this.btnShwItm.BackColor = System.Drawing.Color.Sienna;
            this.btnShwItm.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnShwItm.BorderColor = System.Drawing.Color.Black;
            this.btnShwItm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShwItm.FocusedColor = System.Drawing.Color.Empty;
            this.btnShwItm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShwItm.ForeColor = System.Drawing.Color.Black;
            this.btnShwItm.Image = null;
            this.btnShwItm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShwItm.Location = new System.Drawing.Point(1012, 457);
            this.btnShwItm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShwItm.Name = "btnShwItm";
            this.btnShwItm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShwItm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShwItm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShwItm.OnHoverImage = null;
            this.btnShwItm.OnPressedColor = System.Drawing.Color.Black;
            this.btnShwItm.Size = new System.Drawing.Size(160, 46);
            this.btnShwItm.TabIndex = 10;
            this.btnShwItm.Text = "Show Item";
            this.btnShwItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShwItm.Click += new System.EventHandler(this.btnShwItm_Click);
            // 
            // gridVwShowItmAd
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridVwShowItmAd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVwShowItmAd.BackgroundColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVwShowItmAd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridVwShowItmAd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVwShowItmAd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridVwShowItmAd.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVwShowItmAd.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridVwShowItmAd.EnableHeadersVisualStyles = false;
            this.gridVwShowItmAd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridVwShowItmAd.Location = new System.Drawing.Point(241, 84);
            this.gridVwShowItmAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridVwShowItmAd.Name = "gridVwShowItmAd";
            this.gridVwShowItmAd.RowHeadersVisible = false;
            this.gridVwShowItmAd.RowHeadersWidth = 51;
            this.gridVwShowItmAd.RowTemplate.Height = 24;
            this.gridVwShowItmAd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVwShowItmAd.Size = new System.Drawing.Size(931, 353);
            this.gridVwShowItmAd.TabIndex = 7;
            this.gridVwShowItmAd.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridVwShowItmAd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridVwShowItmAd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridVwShowItmAd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridVwShowItmAd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridVwShowItmAd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridVwShowItmAd.ThemeStyle.HeaderStyle.Height = 4;
            this.gridVwShowItmAd.ThemeStyle.ReadOnly = false;
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.Height = 24;
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridVwShowItmAd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtPrcAd
            // 
            this.txtPrcAd.BaseColor = System.Drawing.Color.White;
            this.txtPrcAd.BorderColor = System.Drawing.Color.Silver;
            this.txtPrcAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrcAd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrcAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrcAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrcAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrcAd.Location = new System.Drawing.Point(975, 28);
            this.txtPrcAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrcAd.Name = "txtPrcAd";
            this.txtPrcAd.PasswordChar = '\0';
            this.txtPrcAd.SelectedText = "";
            this.txtPrcAd.Size = new System.Drawing.Size(197, 37);
            this.txtPrcAd.TabIndex = 6;
            // 
            // btnRmvItm
            // 
            this.btnRmvItm.AnimationHoverSpeed = 0.07F;
            this.btnRmvItm.AnimationSpeed = 0.03F;
            this.btnRmvItm.BackColor = System.Drawing.Color.SeaShell;
            this.btnRmvItm.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnRmvItm.BorderColor = System.Drawing.Color.Black;
            this.btnRmvItm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRmvItm.FocusedColor = System.Drawing.Color.Empty;
            this.btnRmvItm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvItm.ForeColor = System.Drawing.Color.Black;
            this.btnRmvItm.Image = null;
            this.btnRmvItm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRmvItm.Location = new System.Drawing.Point(699, 562);
            this.btnRmvItm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRmvItm.Name = "btnRmvItm";
            this.btnRmvItm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRmvItm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRmvItm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRmvItm.OnHoverImage = null;
            this.btnRmvItm.OnPressedColor = System.Drawing.Color.Black;
            this.btnRmvItm.Size = new System.Drawing.Size(200, 50);
            this.btnRmvItm.TabIndex = 2;
            this.btnRmvItm.Text = "Remove Item";
            this.btnRmvItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRmvItm.Click += new System.EventHandler(this.btnRmvItm_Click);
            // 
            // btnUpdItm
            // 
            this.btnUpdItm.AnimationHoverSpeed = 0.07F;
            this.btnUpdItm.AnimationSpeed = 0.03F;
            this.btnUpdItm.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdItm.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnUpdItm.BorderColor = System.Drawing.Color.Black;
            this.btnUpdItm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdItm.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdItm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdItm.ForeColor = System.Drawing.Color.Black;
            this.btnUpdItm.Image = null;
            this.btnUpdItm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdItm.Location = new System.Drawing.Point(469, 562);
            this.btnUpdItm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdItm.Name = "btnUpdItm";
            this.btnUpdItm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdItm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdItm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdItm.OnHoverImage = null;
            this.btnUpdItm.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdItm.Size = new System.Drawing.Size(200, 50);
            this.btnUpdItm.TabIndex = 1;
            this.btnUpdItm.Text = "Update Item";
            this.btnUpdItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdItm.Click += new System.EventHandler(this.btnUpdItm_Click);
            // 
            // txtItmAd
            // 
            this.txtItmAd.BaseColor = System.Drawing.Color.White;
            this.txtItmAd.BorderColor = System.Drawing.Color.Silver;
            this.txtItmAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItmAd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItmAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItmAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItmAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItmAd.Location = new System.Drawing.Point(699, 28);
            this.txtItmAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItmAd.Name = "txtItmAd";
            this.txtItmAd.PasswordChar = '\0';
            this.txtItmAd.SelectedText = "";
            this.txtItmAd.Size = new System.Drawing.Size(248, 37);
            this.txtItmAd.TabIndex = 5;
            // 
            // lblPrc
            // 
            this.lblPrc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrc.Location = new System.Drawing.Point(1008, 2);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(125, 23);
            this.lblPrc.TabIndex = 4;
            this.lblPrc.Text = "Price";
            this.lblPrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAdCtgry
            // 
            this.cmbAdCtgry.BackColor = System.Drawing.Color.Transparent;
            this.cmbAdCtgry.BaseColor = System.Drawing.Color.White;
            this.cmbAdCtgry.BorderColor = System.Drawing.Color.Silver;
            this.cmbAdCtgry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAdCtgry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdCtgry.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAdCtgry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAdCtgry.ForeColor = System.Drawing.Color.Black;
            this.cmbAdCtgry.FormattingEnabled = true;
            this.cmbAdCtgry.Items.AddRange(new object[] {
            "Chicken Burger",
            "Beef Burger",
            "Beverage"});
            this.cmbAdCtgry.Location = new System.Drawing.Point(469, 28);
            this.cmbAdCtgry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAdCtgry.Name = "cmbAdCtgry";
            this.cmbAdCtgry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAdCtgry.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAdCtgry.Size = new System.Drawing.Size(197, 31);
            this.cmbAdCtgry.TabIndex = 3;
            // 
            // btnAddItm
            // 
            this.btnAddItm.AnimationHoverSpeed = 0.07F;
            this.btnAddItm.AnimationSpeed = 0.03F;
            this.btnAddItm.BackColor = System.Drawing.Color.Chocolate;
            this.btnAddItm.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnAddItm.BorderColor = System.Drawing.Color.Black;
            this.btnAddItm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItm.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItm.ForeColor = System.Drawing.Color.Black;
            this.btnAddItm.Image = null;
            this.btnAddItm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItm.Location = new System.Drawing.Point(241, 562);
            this.btnAddItm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItm.Name = "btnAddItm";
            this.btnAddItm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddItm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItm.OnHoverImage = null;
            this.btnAddItm.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItm.Size = new System.Drawing.Size(200, 50);
            this.btnAddItm.TabIndex = 0;
            this.btnAddItm.Text = "Add Item";
            this.btnAddItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItm.Click += new System.EventHandler(this.btnAddItm_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCtgry
            // 
            this.lblCtgry.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtgry.Location = new System.Drawing.Point(509, 2);
            this.lblCtgry.Name = "lblCtgry";
            this.lblCtgry.Size = new System.Drawing.Size(125, 23);
            this.lblCtgry.TabIndex = 0;
            this.lblCtgry.Text = "Category";
            this.lblCtgry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackAd
            // 
            this.btnBackAd.AnimationHoverSpeed = 0.07F;
            this.btnBackAd.AnimationSpeed = 0.03F;
            this.btnBackAd.BackColor = System.Drawing.Color.Chocolate;
            this.btnBackAd.BaseColor = System.Drawing.Color.CadetBlue;
            this.btnBackAd.BorderColor = System.Drawing.Color.Black;
            this.btnBackAd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackAd.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAd.ForeColor = System.Drawing.Color.Black;
            this.btnBackAd.Image = null;
            this.btnBackAd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackAd.Location = new System.Drawing.Point(45, 669);
            this.btnBackAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackAd.Name = "btnBackAd";
            this.btnBackAd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBackAd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackAd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackAd.OnHoverImage = null;
            this.btnBackAd.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackAd.Size = new System.Drawing.Size(104, 42);
            this.btnBackAd.TabIndex = 14;
            this.btnBackAd.Text = "Back";
            this.btnBackAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackAd.Click += new System.EventHandler(this.btnBackAd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1195, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 746);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBackAd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIDAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShwItm);
            this.Controls.Add(this.gridVwShowItmAd);
            this.Controls.Add(this.lblCtgry);
            this.Controls.Add(this.txtPrcAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRmvItm);
            this.Controls.Add(this.btnAddItm);
            this.Controls.Add(this.btnUpdItm);
            this.Controls.Add(this.cmbAdCtgry);
            this.Controls.Add(this.txtItmAd);
            this.Controls.Add(this.lblPrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMenu";
            ((System.ComponentModel.ISupportInitialize)(this.gridVwShowItmAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtPrcAd;
        private Guna.UI.WinForms.GunaButton btnRmvItm;
        private Guna.UI.WinForms.GunaButton btnUpdItm;
        private Guna.UI.WinForms.GunaTextBox txtItmAd;
        private System.Windows.Forms.Label lblPrc;
        private Guna.UI.WinForms.GunaComboBox cmbAdCtgry;
        private Guna.UI.WinForms.GunaButton btnAddItm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCtgry;
        private Guna.UI.WinForms.GunaDataGridView gridVwShowItmAd;
        private Guna.UI.WinForms.GunaTextBox txtIDAd;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnShwItm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnBackAd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
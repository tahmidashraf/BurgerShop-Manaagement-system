
namespace newdesign
{
    partial class Aboutus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aboutus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackAboutAd = new System.Windows.Forms.Button();
            this.btnBackAboutEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackAboutAd);
            this.panel1.Controls.Add(this.btnBackAboutEmp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 559);
            this.panel1.TabIndex = 0;
            // 
            // btnBackAboutAd
            // 
            this.btnBackAboutAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAboutAd.Location = new System.Drawing.Point(1023, 3);
            this.btnBackAboutAd.Name = "btnBackAboutAd";
            this.btnBackAboutAd.Size = new System.Drawing.Size(41, 38);
            this.btnBackAboutAd.TabIndex = 4;
            this.btnBackAboutAd.Text = "✖";
            this.btnBackAboutAd.UseVisualStyleBackColor = true;
            this.btnBackAboutAd.Click += new System.EventHandler(this.btnBackAbout_Click);
            // 
            // btnBackAboutEmp
            // 
            this.btnBackAboutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAboutEmp.Location = new System.Drawing.Point(1023, 3);
            this.btnBackAboutEmp.Name = "btnBackAboutEmp";
            this.btnBackAboutEmp.Size = new System.Drawing.Size(41, 38);
            this.btnBackAboutEmp.TabIndex = 3;
            this.btnBackAboutEmp.Text = "✖";
            this.btnBackAboutEmp.UseVisualStyleBackColor = true;
            this.btnBackAboutEmp.Click += new System.EventHandler(this.btnBackAboutEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Aboutus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aboutus";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnBackAboutEmp;
        public System.Windows.Forms.Button btnBackAboutAd;
    }
}

namespace newdesign
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCpassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnupSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnupSignin = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtupUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtupPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblregister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 682);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(715, 111);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(108, 23);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // lblCpassword
            // 
            this.lblCpassword.AutoSize = true;
            this.lblCpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpassword.Location = new System.Drawing.Point(716, 407);
            this.lblCpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpassword.Name = "lblCpassword";
            this.lblCpassword.Size = new System.Drawing.Size(183, 23);
            this.lblCpassword.TabIndex = 2;
            this.lblCpassword.Text = "Confirm Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(716, 262);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 23);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(716, 187);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtFullName
            // 
            this.txtFullName.Animated = true;
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(720, 140);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(413, 42);
            this.txtFullName.TabIndex = 6;
            // 
            // btnupSignUp
            // 
            this.btnupSignUp.BorderRadius = 10;
            this.btnupSignUp.CheckedState.Parent = this.btnupSignUp;
            this.btnupSignUp.CustomImages.Parent = this.btnupSignUp;
            this.btnupSignUp.FillColor = System.Drawing.Color.Black;
            this.btnupSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupSignUp.ForeColor = System.Drawing.Color.White;
            this.btnupSignUp.HoverState.Parent = this.btnupSignUp;
            this.btnupSignUp.Location = new System.Drawing.Point(837, 576);
            this.btnupSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnupSignUp.Name = "btnupSignUp";
            this.btnupSignUp.ShadowDecoration.Parent = this.btnupSignUp;
            this.btnupSignUp.Size = new System.Drawing.Size(211, 62);
            this.btnupSignUp.TabIndex = 10;
            this.btnupSignUp.Text = "Sign Up ";
            this.btnupSignUp.Click += new System.EventHandler(this.btnupSignUp_Click);
            // 
            // btnupSignin
            // 
            this.btnupSignin.BorderRadius = 10;
            this.btnupSignin.CheckedState.Parent = this.btnupSignin;
            this.btnupSignin.CustomImages.Parent = this.btnupSignin;
            this.btnupSignin.FillColor = System.Drawing.Color.Black;
            this.btnupSignin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnupSignin.ForeColor = System.Drawing.Color.White;
            this.btnupSignin.HoverState.Parent = this.btnupSignin;
            this.btnupSignin.Location = new System.Drawing.Point(992, 14);
            this.btnupSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnupSignin.Name = "btnupSignin";
            this.btnupSignin.ShadowDecoration.Parent = this.btnupSignin;
            this.btnupSignin.Size = new System.Drawing.Size(167, 32);
            this.btnupSignin.TabIndex = 11;
            this.btnupSignin.Text = "Sign In";
            this.btnupSignin.Click += new System.EventHandler(this.btnupSignin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(720, 215);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(413, 42);
            this.txtEmail.TabIndex = 12;
            // 
            // txtupUserName
            // 
            this.txtupUserName.Animated = true;
            this.txtupUserName.BorderRadius = 10;
            this.txtupUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtupUserName.DefaultText = "";
            this.txtupUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtupUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtupUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupUserName.DisabledState.Parent = this.txtupUserName;
            this.txtupUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupUserName.FocusedState.Parent = this.txtupUserName;
            this.txtupUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtupUserName.ForeColor = System.Drawing.Color.Black;
            this.txtupUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupUserName.HoverState.Parent = this.txtupUserName;
            this.txtupUserName.Location = new System.Drawing.Point(720, 286);
            this.txtupUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtupUserName.Name = "txtupUserName";
            this.txtupUserName.PasswordChar = '\0';
            this.txtupUserName.PlaceholderText = "";
            this.txtupUserName.SelectedText = "";
            this.txtupUserName.ShadowDecoration.Parent = this.txtupUserName;
            this.txtupUserName.Size = new System.Drawing.Size(413, 42);
            this.txtupUserName.TabIndex = 13;
            // 
            // txtCpassword
            // 
            this.txtCpassword.Animated = true;
            this.txtCpassword.BorderRadius = 10;
            this.txtCpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpassword.DefaultText = "";
            this.txtCpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpassword.DisabledState.Parent = this.txtCpassword;
            this.txtCpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpassword.FocusedState.Parent = this.txtCpassword;
            this.txtCpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCpassword.ForeColor = System.Drawing.Color.Black;
            this.txtCpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpassword.HoverState.Parent = this.txtCpassword;
            this.txtCpassword.Location = new System.Drawing.Point(719, 434);
            this.txtCpassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCpassword.Name = "txtCpassword";
            this.txtCpassword.PasswordChar = '\0';
            this.txtCpassword.PlaceholderText = "";
            this.txtCpassword.SelectedText = "";
            this.txtCpassword.ShadowDecoration.Parent = this.txtCpassword;
            this.txtCpassword.Size = new System.Drawing.Size(413, 42);
            this.txtCpassword.TabIndex = 14;
            this.txtCpassword.TextChanged += new System.EventHandler(this.txtCpassword_TextChanged);
            // 
            // txtupPassword
            // 
            this.txtupPassword.Animated = true;
            this.txtupPassword.BorderRadius = 10;
            this.txtupPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtupPassword.DefaultText = "";
            this.txtupPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtupPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtupPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupPassword.DisabledState.Parent = this.txtupPassword;
            this.txtupPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtupPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupPassword.FocusedState.Parent = this.txtupPassword;
            this.txtupPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtupPassword.ForeColor = System.Drawing.Color.Black;
            this.txtupPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtupPassword.HoverState.Parent = this.txtupPassword;
            this.txtupPassword.Location = new System.Drawing.Point(719, 359);
            this.txtupPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtupPassword.Name = "txtupPassword";
            this.txtupPassword.PasswordChar = '\0';
            this.txtupPassword.PlaceholderText = "";
            this.txtupPassword.SelectedText = "";
            this.txtupPassword.ShadowDecoration.Parent = this.txtupPassword;
            this.txtupPassword.Size = new System.Drawing.Size(413, 42);
            this.txtupPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(716, 332);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(720, 534);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(412, 25);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Accept terms and pricacy.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(945, 486);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(72, 26);
            this.rdbtnMale.TabIndex = 19;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(1043, 486);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(89, 26);
            this.rdbtnFemale.TabIndex = 20;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(716, 482);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 23);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblregister
            // 
            this.lblregister.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.Location = new System.Drawing.Point(769, 14);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(216, 32);
            this.lblregister.TabIndex = 22;
            this.lblregister.Text = "Already have an account?";
            this.lblregister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1172, 681);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtupPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtCpassword);
            this.Controls.Add(this.txtupUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnupSignin);
            this.Controls.Add(this.btnupSignUp);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCpassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCpassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2Button btnupSignUp;
        private Guna.UI2.WinForms.Guna2Button btnupSignin;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtupUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtCpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtupPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblregister;
    }
}
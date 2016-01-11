namespace LoginForm
{
    partial class LoginForm
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
            this.grouplogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.txt_pword = new MetroFramework.Controls.MetroTextBox();
            this.txt_uname = new MetroFramework.Controls.MetroTextBox();
            this.grouplogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grouplogin
            // 
            this.grouplogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grouplogin.Controls.Add(this.pictureBox1);
            this.grouplogin.Controls.Add(this.btn_cancel);
            this.grouplogin.Controls.Add(this.btn_login);
            this.grouplogin.Controls.Add(this.txt_pword);
            this.grouplogin.Controls.Add(this.txt_uname);
            this.grouplogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grouplogin.Location = new System.Drawing.Point(20, 60);
            this.grouplogin.Name = "grouplogin";
            this.grouplogin.Size = new System.Drawing.Size(405, 173);
            this.grouplogin.TabIndex = 0;
            this.grouplogin.TabStop = false;
            this.grouplogin.Text = "Please Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.lock_512;
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cancel.Location = new System.Drawing.Point(259, 106);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 34);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_login.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_login.Location = new System.Drawing.Point(157, 106);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 34);
            this.btn_login.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pword
            // 
            // 
            // 
            // 
            this.txt_pword.CustomButton.Image = null;
            this.txt_pword.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txt_pword.CustomButton.Name = "";
            this.txt_pword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pword.CustomButton.TabIndex = 1;
            this.txt_pword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pword.CustomButton.UseSelectable = true;
            this.txt_pword.CustomButton.Visible = false;
            this.txt_pword.DisplayIcon = true;
            this.txt_pword.Icon = global::LoginForm.Properties.Resources.Key_25;
            this.txt_pword.IconRight = true;
            this.txt_pword.Lines = new string[0];
            this.txt_pword.Location = new System.Drawing.Point(157, 62);
            this.txt_pword.MaxLength = 32767;
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.PasswordChar = '*';
            this.txt_pword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pword.SelectedText = "";
            this.txt_pword.SelectionLength = 0;
            this.txt_pword.SelectionStart = 0;
            this.txt_pword.Size = new System.Drawing.Size(189, 23);
            this.txt_pword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_pword.TabIndex = 1;
            this.txt_pword.UseSelectable = true;
            this.txt_pword.UseStyleColors = true;
            this.txt_pword.WaterMark = "Password";
            this.txt_pword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_uname
            // 
            // 
            // 
            // 
            this.txt_uname.CustomButton.Image = null;
            this.txt_uname.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txt_uname.CustomButton.Name = "";
            this.txt_uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_uname.CustomButton.TabIndex = 1;
            this.txt_uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_uname.CustomButton.UseSelectable = true;
            this.txt_uname.CustomButton.Visible = false;
            this.txt_uname.DisplayIcon = true;
            this.txt_uname.Icon = global::LoginForm.Properties.Resources.user;
            this.txt_uname.IconRight = true;
            this.txt_uname.Lines = new string[0];
            this.txt_uname.Location = new System.Drawing.Point(157, 33);
            this.txt_uname.MaxLength = 32767;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PasswordChar = '\0';
            this.txt_uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_uname.SelectedText = "";
            this.txt_uname.SelectionLength = 0;
            this.txt_uname.SelectionStart = 0;
            this.txt_uname.Size = new System.Drawing.Size(189, 23);
            this.txt_uname.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_uname.TabIndex = 0;
            this.txt_uname.UseSelectable = true;
            this.txt_uname.UseStyleColors = true;
            this.txt_uname.WaterMark = "Username";
            this.txt_uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 253);
            this.Controls.Add(this.grouplogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.grouplogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private MetroFramework.Controls.MetroTextBox txt_uname;
        private MetroFramework.Controls.MetroTextBox txt_pword;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


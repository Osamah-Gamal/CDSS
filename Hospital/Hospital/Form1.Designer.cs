namespace Hospital
{
    partial class Form1
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
            this.text_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.com_usertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_username
            // 
            this.text_username.BorderRadius = 4;
            this.text_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_username.DefaultText = "";
            this.text_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_username.ForeColor = System.Drawing.Color.Black;
            this.text_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_username.Location = new System.Drawing.Point(234, 141);
            this.text_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_username.Name = "text_username";
            this.text_username.PlaceholderText = "ادخل اسم المستخدم";
            this.text_username.SelectedText = "";
            this.text_username.Size = new System.Drawing.Size(286, 60);
            this.text_username.TabIndex = 0;
            this.text_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_password
            // 
            this.text_password.BorderRadius = 4;
            this.text_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_password.DefaultText = "";
            this.text_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_password.ForeColor = System.Drawing.Color.Black;
            this.text_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_password.Location = new System.Drawing.Point(233, 261);
            this.text_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.PlaceholderText = "ادخل كلمة المرور";
            this.text_password.SelectedText = "";
            this.text_password.Size = new System.Drawing.Size(286, 60);
            this.text_password.TabIndex = 1;
            this.text_password.Tag = "";
            this.text_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 8;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_login.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(27, 385);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(285, 54);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "دخول";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(425, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(396, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم المستخدم";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.com_usertype);
            this.guna2Panel1.Controls.Add(this.btn_login);
            this.guna2Panel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.guna2Panel1.Location = new System.Drawing.Point(207, 95);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(339, 467);
            this.guna2Panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(221, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "نوع الدخول";
            // 
            // com_usertype
            // 
            this.com_usertype.BackColor = System.Drawing.Color.Transparent;
            this.com_usertype.BorderRadius = 4;
            this.com_usertype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.com_usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_usertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_usertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_usertype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.com_usertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.com_usertype.ItemHeight = 30;
            this.com_usertype.Items.AddRange(new object[] {
            "Admin",
            "Doctor"});
            this.com_usertype.Location = new System.Drawing.Point(29, 293);
            this.com_usertype.Name = "com_usertype";
            this.com_usertype.Size = new System.Drawing.Size(284, 36);
            this.com_usertype.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(761, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.guna2Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "تسجيل الدخول";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox text_username;
        private Guna.UI2.WinForms.Guna2TextBox text_password;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox com_usertype;
    }
}


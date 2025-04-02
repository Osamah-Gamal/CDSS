namespace Hospital
{
    partial class Home
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
            System.Windows.Forms.Label label4;
            this.show_screen = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_symptoms = new Guna.UI2.WinForms.Guna2Button();
            this.btn_patients = new Guna.UI2.WinForms.Guna2Button();
            this.btn_results = new Guna.UI2.WinForms.Guna2Button();
            this.btn_account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_doctors = new Guna.UI2.WinForms.Guna2Button();
            this.lbe_date = new System.Windows.Forms.Label();
            this.lbe_time = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_userid = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_usertype = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(321, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 19);
            label4.TabIndex = 11;
            label4.Text = "Type:";
            // 
            // show_screen
            // 
            this.show_screen.BorderColor = System.Drawing.Color.Black;
            this.show_screen.BorderRadius = 3;
            this.show_screen.BorderThickness = 1;
            this.show_screen.Location = new System.Drawing.Point(2, 101);
            this.show_screen.Name = "show_screen";
            this.show_screen.Size = new System.Drawing.Size(1308, 633);
            this.show_screen.TabIndex = 0;
            // 
            // btn_symptoms
            // 
            this.btn_symptoms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_symptoms.BorderRadius = 8;
            this.btn_symptoms.BorderThickness = 1;
            this.btn_symptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_symptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_symptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_symptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_symptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_symptoms.FillColor = System.Drawing.Color.Navy;
            this.btn_symptoms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_symptoms.ForeColor = System.Drawing.Color.White;
            this.btn_symptoms.Location = new System.Drawing.Point(1331, 106);
            this.btn_symptoms.Name = "btn_symptoms";
            this.btn_symptoms.Size = new System.Drawing.Size(141, 38);
            this.btn_symptoms.TabIndex = 0;
            this.btn_symptoms.Text = "ادارة الامراض";
            this.btn_symptoms.Click += new System.EventHandler(this.btn_symptoms_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BorderRadius = 8;
            this.btn_patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_patients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_patients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_patients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_patients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_patients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_patients.ForeColor = System.Drawing.Color.White;
            this.btn_patients.Location = new System.Drawing.Point(1331, 167);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(141, 38);
            this.btn_patients.TabIndex = 1;
            this.btn_patients.Text = "ادارة المرضى";
            // 
            // btn_results
            // 
            this.btn_results.BorderRadius = 8;
            this.btn_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_results.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_results.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_results.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_results.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_results.ForeColor = System.Drawing.Color.White;
            this.btn_results.Location = new System.Drawing.Point(1331, 228);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(141, 38);
            this.btn_results.TabIndex = 2;
            this.btn_results.Text = "ادارة النتائج";
            // 
            // btn_account
            // 
            this.btn_account.BorderRadius = 2;
            this.btn_account.BorderThickness = 1;
            this.btn_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_account.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_account.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account.ForeColor = System.Drawing.Color.Black;
            this.btn_account.Location = new System.Drawing.Point(1136, 59);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(171, 36);
            this.btn_account.TabIndex = 3;
            this.btn_account.Text = "الحساب الشخصي";
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_doctors
            // 
            this.btn_doctors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_doctors.BorderRadius = 8;
            this.btn_doctors.BorderThickness = 2;
            this.btn_doctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doctors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_doctors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_doctors.ForeColor = System.Drawing.Color.White;
            this.btn_doctors.Location = new System.Drawing.Point(15, 381);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(141, 50);
            this.btn_doctors.TabIndex = 4;
            this.btn_doctors.Text = "ادارة الدكاتره";
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // lbe_date
            // 
            this.lbe_date.AutoSize = true;
            this.lbe_date.Location = new System.Drawing.Point(81, 25);
            this.lbe_date.Name = "lbe_date";
            this.lbe_date.Size = new System.Drawing.Size(41, 19);
            this.lbe_date.TabIndex = 5;
            this.lbe_date.Text = "Date";
            // 
            // lbe_time
            // 
            this.lbe_time.AutoSize = true;
            this.lbe_time.Location = new System.Drawing.Point(77, 54);
            this.lbe_time.Name = "lbe_time";
            this.lbe_time.Size = new System.Drawing.Size(45, 19);
            this.lbe_time.TabIndex = 6;
            this.lbe_time.Text = "Time";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 3;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btn_doctors);
            this.guna2Panel1.Location = new System.Drawing.Point(1316, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(168, 680);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id:";
            // 
            // lb_userid
            // 
            this.lb_userid.AutoSize = true;
            this.lb_userid.Location = new System.Drawing.Point(374, 72);
            this.lb_userid.Name = "lb_userid";
            this.lb_userid.Size = new System.Drawing.Size(22, 19);
            this.lb_userid.TabIndex = 10;
            this.lb_userid.Text = "id";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(374, 37);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(48, 19);
            this.lb_username.TabIndex = 9;
            this.lb_username.Text = "name";
            // 
            // lb_usertype
            // 
            this.lb_usertype.AutoSize = true;
            this.lb_usertype.Location = new System.Drawing.Point(374, 16);
            this.lb_usertype.Name = "lb_usertype";
            this.lb_usertype.Size = new System.Drawing.Size(39, 19);
            this.lb_usertype.TabIndex = 12;
            this.lb_usertype.Text = "type";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1492, 744);
            this.Controls.Add(this.lb_usertype);
            this.Controls.Add(label4);
            this.Controls.Add(this.lb_userid);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbe_time);
            this.Controls.Add(this.lbe_date);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.btn_patients);
            this.Controls.Add(this.btn_symptoms);
            this.Controls.Add(this.show_screen);
            this.Controls.Add(this.guna2Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "الصفحة الرئيسية";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed_1);
            this.Load += new System.EventHandler(this.Home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel show_screen;
        private Guna.UI2.WinForms.Guna2Button btn_symptoms;
        private Guna.UI2.WinForms.Guna2Button btn_patients;
        private Guna.UI2.WinForms.Guna2Button btn_results;
        private Guna.UI2.WinForms.Guna2Button btn_account;
        private Guna.UI2.WinForms.Guna2Button btn_doctors;
        private System.Windows.Forms.Label lbe_date;
        private System.Windows.Forms.Label lbe_time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_userid;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_usertype;
    }
}
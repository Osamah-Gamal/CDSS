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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_userid = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_usertype = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(1, 5);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 11;
            label4.Text = "Type:";
            // 
            // show_screen
            // 
            this.show_screen.BorderColor = System.Drawing.Color.Aqua;
            this.show_screen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.show_screen.Location = new System.Drawing.Point(6, 67);
            this.show_screen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.show_screen.Name = "show_screen";
            this.show_screen.Size = new System.Drawing.Size(872, 422);
            this.show_screen.TabIndex = 0;
            this.show_screen.Paint += new System.Windows.Forms.PaintEventHandler(this.show_screen_Paint);
            // 
            // btn_symptoms
            // 
            this.btn_symptoms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_symptoms.BorderRadius = 8;
            this.btn_symptoms.BorderThickness = 2;
            this.btn_symptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_symptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_symptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_symptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_symptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_symptoms.FillColor = System.Drawing.Color.Navy;
            this.btn_symptoms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_symptoms.ForeColor = System.Drawing.Color.White;
            this.btn_symptoms.Location = new System.Drawing.Point(890, 117);
            this.btn_symptoms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_symptoms.Name = "btn_symptoms";
            this.btn_symptoms.Size = new System.Drawing.Size(94, 33);
            this.btn_symptoms.TabIndex = 0;
            this.btn_symptoms.Text = "ادارة الامراض";
            this.btn_symptoms.Click += new System.EventHandler(this.btn_symptoms_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_patients.BorderRadius = 8;
            this.btn_patients.BorderThickness = 2;
            this.btn_patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_patients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_patients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_patients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_patients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_patients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_patients.ForeColor = System.Drawing.Color.White;
            this.btn_patients.Location = new System.Drawing.Point(890, 158);
            this.btn_patients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(94, 33);
            this.btn_patients.TabIndex = 1;
            this.btn_patients.Text = "ادارة المرضى";
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // btn_results
            // 
            this.btn_results.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_results.BorderRadius = 8;
            this.btn_results.BorderThickness = 2;
            this.btn_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_results.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_results.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_results.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_results.FillColor = System.Drawing.Color.Blue;
            this.btn_results.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_results.ForeColor = System.Drawing.Color.White;
            this.btn_results.Location = new System.Drawing.Point(890, 199);
            this.btn_results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(94, 33);
            this.btn_results.TabIndex = 2;
            this.btn_results.Text = "ادارة النتائج";
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
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
            this.btn_account.Location = new System.Drawing.Point(765, 37);
            this.btn_account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(114, 24);
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
            this.btn_doctors.Location = new System.Drawing.Point(9, 31);
            this.btn_doctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(94, 33);
            this.btn_doctors.TabIndex = 4;
            this.btn_doctors.Text = "ادارة الدكاتره";
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // lbe_date
            // 
            this.lbe_date.AutoSize = true;
            this.lbe_date.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbe_date.Location = new System.Drawing.Point(183, 13);
            this.lbe_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbe_date.Name = "lbe_date";
            this.lbe_date.Size = new System.Drawing.Size(40, 13);
            this.lbe_date.TabIndex = 5;
            this.lbe_date.Text = "Date :";
            // 
            // lbe_time
            // 
            this.lbe_time.AutoSize = true;
            this.lbe_time.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbe_time.Location = new System.Drawing.Point(180, 34);
            this.lbe_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbe_time.Name = "lbe_time";
            this.lbe_time.Size = new System.Drawing.Size(41, 13);
            this.lbe_time.TabIndex = 6;
            this.lbe_time.Text = "Time :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 3;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btn_doctors);
            this.guna2Panel1.Location = new System.Drawing.Point(882, 36);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(107, 456);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Navy;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(8, 211);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(94, 33);
            this.guna2Button1.TabIndex = 67;
            this.guna2Button1.Text = "تحليل الاعرض";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id:";
            // 
            // lb_userid
            // 
            this.lb_userid.AutoSize = true;
            this.lb_userid.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lb_userid.Location = new System.Drawing.Point(43, 38);
            this.lb_userid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_userid.Name = "lb_userid";
            this.lb_userid.Size = new System.Drawing.Size(37, 13);
            this.lb_userid.TabIndex = 10;
            this.lb_userid.Text = "..........";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lb_username.Location = new System.Drawing.Point(43, 21);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(37, 13);
            this.lb_username.TabIndex = 9;
            this.lb_username.Text = "..........";
            // 
            // lb_usertype
            // 
            this.lb_usertype.AutoSize = true;
            this.lb_usertype.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lb_usertype.Location = new System.Drawing.Point(43, 5);
            this.lb_usertype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_usertype.Name = "lb_usertype";
            this.lb_usertype.Size = new System.Drawing.Size(37, 13);
            this.lb_usertype.TabIndex = 12;
            this.lb_usertype.Text = "..........";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 3;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(961, 7);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(30, 27);
            this.guna2Button2.TabIndex = 64;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 3;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 65);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(877, 427);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Location = new System.Drawing.Point(219, 35);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(37, 13);
            this.lbl_time.TabIndex = 66;
            this.lbl_time.Text = "..........";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_date.Location = new System.Drawing.Point(221, 13);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(37, 13);
            this.lbl_date.TabIndex = 65;
            this.lbl_date.Text = "..........";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.guna2Button2);
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
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(13, 40, 13, 13);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
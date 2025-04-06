namespace Hospital
{
    partial class DiseaseTypes
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_excel_show = new Guna.UI2.WinForms.Guna2Button();
            this.btn_excel_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.text_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.text_DiseaseTypes = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_DescriptionDiseaseTypes = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_DiseaseTypesId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(321, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "اسم المرض";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(950, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "وصف المرض";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_excel_show
            // 
            this.btn_excel_show.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excel_show.BorderRadius = 8;
            this.btn_excel_show.BorderThickness = 2;
            this.btn_excel_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_excel_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_excel_show.FillColor = System.Drawing.Color.Navy;
            this.btn_excel_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_excel_show.ForeColor = System.Drawing.Color.White;
            this.btn_excel_show.Location = new System.Drawing.Point(11, 429);
            this.btn_excel_show.Name = "btn_excel_show";
            this.btn_excel_show.Size = new System.Drawing.Size(200, 64);
            this.btn_excel_show.TabIndex = 36;
            this.btn_excel_show.Text = "Get data from excel";
            this.btn_excel_show.Click += new System.EventHandler(this.btn_excel_show_Click);
            // 
            // btn_excel_add
            // 
            this.btn_excel_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excel_add.BorderRadius = 8;
            this.btn_excel_add.BorderThickness = 2;
            this.btn_excel_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_excel_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_excel_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_excel_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_excel_add.ForeColor = System.Drawing.Color.White;
            this.btn_excel_add.Location = new System.Drawing.Point(9, 496);
            this.btn_excel_add.Name = "btn_excel_add";
            this.btn_excel_add.Size = new System.Drawing.Size(202, 64);
            this.btn_excel_add.TabIndex = 37;
            this.btn_excel_add.Text = "Confirm data entry into the database";
            this.btn_excel_add.Click += new System.EventHandler(this.btn_excel_add_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(1135, 340);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(141, 38);
            this.guna2Button1.TabIndex = 38;
            this.guna2Button1.Text = "تهية الصفحة";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // text_search
            // 
            this.text_search.BorderColor = System.Drawing.Color.Blue;
            this.text_search.BorderRadius = 4;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.DefaultText = "";
            this.text_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.ForeColor = System.Drawing.Color.Navy;
            this.text_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Location = new System.Drawing.Point(227, 341);
            this.text_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.PlaceholderText = "...البحث بالاسم عن";
            this.text_search.SelectedText = "";
            this.text_search.Size = new System.Drawing.Size(307, 40);
            this.text_search.TabIndex = 45;
            this.text_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 8;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(539, 343);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(141, 38);
            this.btn_search.TabIndex = 40;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BorderRadius = 8;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Maroon;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(686, 343);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 38);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BorderRadius = 8;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.Navy;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(834, 343);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(141, 38);
            this.btn_update.TabIndex = 42;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 8;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Green;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(981, 343);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 38);
            this.btn_add.TabIndex = 43;
            this.btn_add.Text = "أضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(224, 387);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(898, 190);
            this.dataGridView.TabIndex = 39;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderRadius = 4;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(224, 340);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(898, 43);
            this.guna2Panel2.TabIndex = 44;
            // 
            // text_DiseaseTypes
            // 
            this.text_DiseaseTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypes.BorderRadius = 4;
            this.text_DiseaseTypes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_DiseaseTypes.DefaultText = "";
            this.text_DiseaseTypes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_DiseaseTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_DiseaseTypes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DiseaseTypes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DiseaseTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypes.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_DiseaseTypes.ForeColor = System.Drawing.Color.Black;
            this.text_DiseaseTypes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypes.Location = new System.Drawing.Point(84, 30);
            this.text_DiseaseTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_DiseaseTypes.Multiline = true;
            this.text_DiseaseTypes.Name = "text_DiseaseTypes";
            this.text_DiseaseTypes.PlaceholderText = "اسم المرض";
            this.text_DiseaseTypes.SelectedText = "";
            this.text_DiseaseTypes.Size = new System.Drawing.Size(337, 40);
            this.text_DiseaseTypes.TabIndex = 46;
            this.text_DiseaseTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.text_DiseaseTypes.TextChanged += new System.EventHandler(this.text_DiseaseTypes_TextChanged);
            // 
            // text_DescriptionDiseaseTypes
            // 
            this.text_DescriptionDiseaseTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.text_DescriptionDiseaseTypes.BorderRadius = 4;
            this.text_DescriptionDiseaseTypes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_DescriptionDiseaseTypes.DefaultText = "";
            this.text_DescriptionDiseaseTypes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_DescriptionDiseaseTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_DescriptionDiseaseTypes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DescriptionDiseaseTypes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DescriptionDiseaseTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DescriptionDiseaseTypes.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_DescriptionDiseaseTypes.ForeColor = System.Drawing.Color.Black;
            this.text_DescriptionDiseaseTypes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DescriptionDiseaseTypes.Location = new System.Drawing.Point(306, 174);
            this.text_DescriptionDiseaseTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_DescriptionDiseaseTypes.Multiline = true;
            this.text_DescriptionDiseaseTypes.Name = "text_DescriptionDiseaseTypes";
            this.text_DescriptionDiseaseTypes.PlaceholderText = "...وصف المرض";
            this.text_DescriptionDiseaseTypes.SelectedText = "";
            this.text_DescriptionDiseaseTypes.Size = new System.Drawing.Size(747, 139);
            this.text_DescriptionDiseaseTypes.TabIndex = 47;
            this.text_DescriptionDiseaseTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.text_DescriptionDiseaseTypes.TextChanged += new System.EventHandler(this.text_DescriptionDiseaseTypes_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.text_DiseaseTypes);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.text_DiseaseTypesId);
            this.guna2Panel1.Location = new System.Drawing.Point(222, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(898, 263);
            this.guna2Panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(723, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "معرف المرض";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_DiseaseTypesId
            // 
            this.text_DiseaseTypesId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypesId.BorderRadius = 4;
            this.text_DiseaseTypesId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_DiseaseTypesId.DefaultText = "";
            this.text_DiseaseTypesId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_DiseaseTypesId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_DiseaseTypesId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DiseaseTypesId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_DiseaseTypesId.Enabled = false;
            this.text_DiseaseTypesId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypesId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_DiseaseTypesId.ForeColor = System.Drawing.Color.Black;
            this.text_DiseaseTypesId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_DiseaseTypesId.Location = new System.Drawing.Point(509, 30);
            this.text_DiseaseTypesId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_DiseaseTypesId.Name = "text_DiseaseTypesId";
            this.text_DiseaseTypesId.PlaceholderText = "";
            this.text_DiseaseTypesId.SelectedText = "";
            this.text_DiseaseTypesId.Size = new System.Drawing.Size(322, 40);
            this.text_DiseaseTypesId.TabIndex = 51;
            this.text_DiseaseTypesId.TextChanged += new System.EventHandler(this.text_DiseaseTypesId_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1242, -1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(45, 40);
            this.guna2Button2.TabIndex = 49;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Aqua;
            this.guna2Panel3.BorderRadius = 9;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Location = new System.Drawing.Point(5, 423);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(213, 143);
            this.guna2Panel3.TabIndex = 71;
            // 
            // DiseaseTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 577);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.text_DescriptionDiseaseTypes);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_excel_add);
            this.Controls.Add(this.btn_excel_show);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiseaseTypes";
            this.Load += new System.EventHandler(this.DiseaseTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_excel_show;
        private Guna.UI2.WinForms.Guna2Button btn_excel_add;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox text_search;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox text_DiseaseTypes;
        private Guna.UI2.WinForms.Guna2TextBox text_DescriptionDiseaseTypes;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox text_DiseaseTypesId;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}
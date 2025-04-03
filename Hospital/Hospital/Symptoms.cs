
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace Hospital
{
    public partial class Symptoms :  Form
    {
        // سلسلة الاتصال بقاعدة البيانات
        string connectionString = "Server=DESKTOP-P90JUS9\\ZEYAD;Database=CDSS;Integrated Security=True;";
        public Symptoms()
        {
            InitializeComponent();
            LoadSymptoms();
            loaddatatocombbox();

        }

        private void Symptoms_Load(object sender, EventArgs e)
        {

        }

        public void importExcel()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet(* .xlsx)|* .xlsx|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string co = " Provider=Microsoft.ACE.OLEDB.16.0;Data Source={0};Extended Properties ='Excel 8.0;HDR= yes'";
                co = string.Format(co, filepath, "yes");
                OleDbConnection exc = new OleDbConnection(co);
                exc.Open();

                DataTable dt = exc.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dt.Rows[1]["TABLE_NAME"].ToString();
                OleDbCommand cmd = new OleDbCommand("select * from [" + excelsheet + "]", exc);
                OleDbDataAdapter dr = new OleDbDataAdapter(cmd);
                DataTable dts = new DataTable();
                dr.Fill(dts);
                dataGridView.DataSource = dts;
                exc.Close();
            }
        }


        private void btn_excel_show_Click(object sender, EventArgs e)
        {
            importExcel();
        }




        // إدخال البيانات من DataGridView إلى SQL Server
        private void SaveDataToDatabase()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لحفظها!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تحديث الاتصال مع قاعدة البيانات
            string connectionString = "Server=DESKTOP-P90JUS9\\ZEYAD;Database=Hospital;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue; // تخطي الصف الفارغ

                        string symptomName = row.Cells[1].Value?.ToString()?.Trim();
                        string symptomDescription = row.Cells[2].Value?.ToString()?.Trim() ?? "لا يوجد وصف";
                        int diseaseTypeId = Convert.ToInt32(row.Cells[0].Value);

                        // التحقق من أن اسم المرض ليس فارغًا
                        if (!string.IsNullOrWhiteSpace(symptomName))
                        {
                            // التحقق من وجود البيانات مسبقًا
                            string checkQuery = "SELECT COUNT(*) FROM Symptoms WHERE SymptomName = @SymptomName and DiseaseTypeId=@DiseaseTypeId";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@SymptomName", symptomName);
                                checkCmd.Parameters.AddWithValue("@DiseaseTypeId", diseaseTypeId);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count == 0) // إذا لم يتم العثور على البيانات
                                {
                                    string insertQuery = "INSERT INTO Symptoms (SymptomName, SymptomDescription,DiseaseTypeId) VALUES (@SymptomName, @SymptomDescription,@DiseaseTypeId)";
                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@SymptomName", symptomName);
                                        insertCmd.Parameters.AddWithValue("@SymptomDescription", symptomDescription);
                                        insertCmd.Parameters.AddWithValue("@DiseaseTypeId", diseaseTypeId);

                                        insertCmd.ExecuteNonQuery(); // تنفيذ الاستعلام
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"العرض '{symptomName}' موجود مسبقًا، سيتم تخطيه!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("أحد الصفوف يحتوي على اسم مرض فارغ، سيتم تخطيه!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    conn.Close();
                    MessageBox.Show("تم حفظ البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء الحفظ في قاعدة البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_excel_add_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(text_Patientdescription.Text) || string.IsNullOrEmpty(text_PatientName.Text) || string.IsNullOrEmpty(comb_DiseaseTypes.Text))

            {
                MessageBox.Show("يرجى ملء جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ClearInputs()
        {
            text_PatientName.Text = "";
            text_Patientdescription.Text = "";
            text_SymptomId.Text = "";
            text_search.Text = "";
            comb_DiseaseTypes.Text = "";

            LoadSymptoms();
            loaddatatocombbox();
        }

        // load data for DiseaseTypeName combbox
        private void loaddatatocombbox()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DiseaseTypeId, DiseaseTypeName FROM DiseaseTypes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        comb_DiseaseTypes.DataSource = dt;
                        comb_DiseaseTypes.DisplayMember = "DiseaseTypeName"; // ما يعرض للمستخدم
                        comb_DiseaseTypes.ValueMember = "DiseaseTypeId"; // القيمة المخفية (ID)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSymptoms()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  SymptomId, SymptomName, SymptomDescription,DiseaseTypeId FROM Symptoms";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // button add
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Symptoms (SymptomName, SymptomDescription,DiseaseTypeId) VALUES (@SymptomName, @SymptomDescription,@DiseaseTypeId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SymptomName", text_PatientName.Text);
                        command.Parameters.AddWithValue("@SymptomDescription", text_Patientdescription.Text);
                        command.Parameters.AddWithValue("@DiseaseTypeId", comb_DiseaseTypes.SelectedValue);

                        command.ExecuteNonQuery();
                        MessageBox.Show("تمت إضافة ألاضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSymptoms(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                        loaddatatocombbox();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء إضافة : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // button search
        private void btn_search_Click(object sender, EventArgs e)
        {

            string searchText = text_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT SymptomName, SymptomDescription,DiseaseTypeId FROM Symptoms WHERE SymptomName LIKE @SearchText OR SymptomDescription LIKE @SearchText";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                LoadSymptoms(); // إعادة تحميل جميع البيانات إذا كان حقل البحث فارغًا
            }
        }

        // button delete 
        private void btn_delete_Click(object sender, EventArgs e)
        {

            string SymptomId = text_SymptomId.Text;

            if (SymptomId.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Symptoms WHERE SymptomId = @SymptomId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SymptomId", SymptomId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSymptoms(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                        loaddatatocombbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يجب حذف البيانات المرتبطه به: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // button reset feilds and data
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadSymptoms();
            loaddatatocombbox();
        }

        // button update
        private void btn_update_Click(object sender, EventArgs e)
        {

            string SymptomId = text_SymptomId.Text;
            if (ValidateInputs() && SymptomId.Trim() != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open(); 
                        string query = "UPDATE Symptoms SET SymptomName = @SymptomName, SymptomDescription = @SymptomDescription,DiseaseTypeId = @DiseaseTypeId WHERE SymptomId = @SymptomId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SymptomName", text_PatientName.Text);
                        command.Parameters.AddWithValue("@SymptomDescription", text_Patientdescription.Text);
                        command.Parameters.AddWithValue("@DiseaseTypeId", comb_DiseaseTypes.SelectedValue);

                        command.Parameters.AddWithValue("@SymptomId", Convert.ToInt32(SymptomId));


                        command.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        LoadSymptoms(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                        loaddatatocombbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء تحديث بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // تجاهل النقر على رأس العمود
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            // التحقق من وجود القيم قبل التعيين
            text_SymptomId.Text = row.Cells["SymptomId"].Value?.ToString() ?? "";
            text_PatientName.Text = row.Cells["SymptomName"].Value?.ToString() ?? "";
            text_Patientdescription.Text = row.Cells["SymptomDescription"].Value?.ToString() ?? "";

            // التعامل مع ComboBox بشكل صحيح
            if (row.Cells["DiseaseTypeId"].Value != null)
            {
                int diseaseTypeId = Convert.ToInt32(row.Cells["DiseaseTypeId"].Value);

                // البحث عن الـ ID في ComboBox وتحديد العنصر المناسب
                foreach (DataRowView item in comb_DiseaseTypes.Items)
                {
                    if (Convert.ToInt32(item["DiseaseTypeId"]) == diseaseTypeId)
                    {
                        comb_DiseaseTypes.SelectedItem = item;
                        break;
                    }
                }
            }
            else
            {
                comb_DiseaseTypes.SelectedIndex = -1;
            }
        }
    
    }
}

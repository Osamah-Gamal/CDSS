using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DiseaseTypes : Form
    {
        // سلسلة الاتصال بقاعدة البيانات
        string connectionString = "Server=DESKTOP-P90JUS9\\ZEYAD;Database=CDSS;Integrated Security=True;";

        public DiseaseTypes()
        {
            InitializeComponent();
            LoadDiseaseTypes();
        }

        public void importExcel()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string co = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;'";
                ;
                co = string.Format(co, filepath);
                OleDbConnection exc = new OleDbConnection(co);
                exc.Open();

                DataTable dt = exc.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dt.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + excelsheet + "]", exc);
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


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue; // تخطي الصف الفارغ

                        string diseaseName = row.Cells[1].Value?.ToString()?.Trim();
                        string diseaseDescription = row.Cells[2].Value?.ToString()?.Trim() ?? "لا يوجد وصف";

                        // التحقق من أن اسم المرض ليس فارغًا
                        if (!string.IsNullOrWhiteSpace(diseaseName))
                        {
                            // التحقق من وجود البيانات مسبقًا
                            string checkQuery = "SELECT COUNT(*) FROM DiseaseTypes WHERE DiseaseTypeName = @DiseaseTypeName";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@DiseaseTypeName", diseaseName);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count == 0) // إذا لم يتم العثور على البيانات
                                {
                                    string insertQuery = "INSERT INTO DiseaseTypes (DiseaseTypeName, DiseaseTypeDescription) VALUES (@DiseaseTypeName, @DiseaseTypeDescription)";
                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@DiseaseTypeName", diseaseName);
                                        insertCmd.Parameters.AddWithValue("@DiseaseTypeDescription", diseaseDescription);
                                        insertCmd.ExecuteNonQuery(); // تنفيذ الاستعلام
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"المرض '{diseaseName}' موجود مسبقًا، سيتم تخطيه!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void LoadDiseaseTypes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  DiseaseTypeId, DiseaseTypeName, DiseaseTypeDescription FROM DiseaseTypes";
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
        private void btn_excel_add_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();
        }

        private void DiseaseTypes_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(text_DiseaseTypes.Text) || string.IsNullOrEmpty(text_DescriptionDiseaseTypes.Text))
               
            {
                MessageBox.Show("يرجى ملء جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO DiseaseTypes (DiseaseTypeName, DiseaseTypeDescription) VALUES (@DiseaseTypeName, @DiseaseTypeDescription)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DiseaseTypeName", text_DiseaseTypes.Text);
                        command.Parameters.AddWithValue("@DiseaseTypeDescription", text_DescriptionDiseaseTypes.Text);
                       
                        command.ExecuteNonQuery();
                        MessageBox.Show("تمت إضافة ألاضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDiseaseTypes(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء إضافة : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string doctorId = text_DiseaseTypesId.Text;
            if (ValidateInputs() && doctorId.Trim() != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE DiseaseTypes SET DiseaseTypeName = @DiseaseTypeName, DiseaseTypeDescription = @DiseaseTypeDescription WHERE DiseaseTypeId = @DiseaseTypeId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DiseaseTypeName", text_DiseaseTypes.Text);
                        command.Parameters.AddWithValue("@DiseaseTypeDescription", text_DescriptionDiseaseTypes.Text);
                        command.Parameters.AddWithValue("@DiseaseTypeId", Convert.ToInt32(doctorId));


                        command.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        LoadDiseaseTypes(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء تحديث بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearInputs()
        {
            text_DiseaseTypesId.Text = "";
            text_DiseaseTypes.Text = "";
            text_DescriptionDiseaseTypes.Text = "";
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string doctorId = text_DiseaseTypesId.Text;

            if (doctorId.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM DiseaseTypes WHERE DiseaseTypeId = @DiseaseTypeId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DiseaseTypeId", doctorId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDiseaseTypes(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يجب حذف البيانات المرتبطه به: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

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
                        string query = "SELECT DiseaseTypeId, DiseaseTypeName, DiseaseTypeDescription FROM DiseaseTypes WHERE DiseaseTypeName LIKE @SearchText OR DiseaseTypeDescription LIKE @SearchText";
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
                LoadDiseaseTypes(); // إعادة تحميل جميع البيانات إذا كان حقل البحث فارغًا
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                text_DiseaseTypesId.Text = row.Cells["DiseaseTypeId"].Value.ToString();
                text_DiseaseTypes.Text = row.Cells["DiseaseTypeName"].Value.ToString();
                text_DescriptionDiseaseTypes.Text = row.Cells["DiseaseTypeDescription"].Value.ToString();
               
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadDiseaseTypes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_DiseaseTypes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text_DiseaseTypesId_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_DescriptionDiseaseTypes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
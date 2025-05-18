using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Results : Form
    {
        string connectionString = "Server=MOHAMMED-ESMAIL;Database=CDSS;Integrated Security=True;";
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            LoadSymptomsHistory();
        }

        private void LoadSymptomsHistory(string searchTerm = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                sh.Id, 
                                sh.AnalysisDate, 
                                sh.Symptoms, 
                                sh.Diagnosis, 
                                sh.RecommendedTests, 
                                sh.AdditionalNotes, 
                                p.PatientName,
                                d.DoctorName
                            FROM SymptomsHistory sh
                            LEFT JOIN Patients p ON sh.PatientId = p.PatientId
                            LEFT JOIN Doctors d ON sh.DoctorId = d.DoctorId";

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE p.PatientName LIKE @SearchTerm OR sh.Diagnosis LIKE @SearchTerm";
                    }

                    query += " ORDER BY sh.AnalysisDate DESC";

                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = dataTable;

                    ConfigureDataGridView(); // انقل هذا إلى هنا
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
        }



        private void ConfigureDataGridView()
        {
            // تحسين مظهر DataGridView
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            // إخفاء العمود Id
            if (dataGridView.Columns.Contains("Id"))
            {
                dataGridView.Columns["Id"].Visible = false;
            }

            // تنسيق أسماء الأعمدة
            if (dataGridView.Columns.Contains("AnalysisDate"))
            {
                dataGridView.Columns["AnalysisDate"].HeaderText = "تاريخ التحليل";
            }
            if (dataGridView.Columns.Contains("PatientName"))
            {
                dataGridView.Columns["PatientName"].HeaderText = "اسم المريض";
            }
            if (dataGridView.Columns.Contains("DoctorName"))
            {
                dataGridView.Columns["DoctorName"].HeaderText = "اسم الطبيب";
            }
            if (dataGridView.Columns.Contains("Diagnosis"))
            {
                dataGridView.Columns["Diagnosis"].HeaderText = "التشخيص";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // يمكنك إضافة كود لعرض التفاصيل عند النقر على خلية
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadSymptomsHistory(text_search.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا السجل؟", "تأكيد الحذف",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteRecord(selectedId);
                    LoadSymptomsHistory();
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد سجل للحذف", "تحذير",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteRecord(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM SymptomsHistory WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم حذف السجل بنجاح", "نجاح",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSymptomsHistory();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء محاولة الحذف: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // زر تحديث البيانات
            LoadSymptomsHistory();
            text_search.Clear();

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadSymptomsHistory(text_search.Text);
                e.Handled = true;
            }
        }
    }
}
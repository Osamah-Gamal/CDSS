using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Doctors : Form
    {
        // سلسلة الاتصال بقاعدة البيانات
        string connectionString = "Server=DESKTOP-P90JUS9\\ZEYAD;Database=CDSS;Integrated Security=True;";

        public Doctors()
        {
            InitializeComponent();
            LoadDoctors(); // تحميل البيانات عند فتح النموذج
        }

        // تحميل البيانات من الجدول Doctors
        private void LoadDoctors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DoctorId, DoctorName, Specialization, PhoneNumber, UserName FROM Doctors";
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

        // إضافة طبيب جديد
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Doctors (DoctorName, Specialization, PhoneNumber, UserName, Password) VALUES (@DoctorName, @Specialization, @PhoneNumber, @UserName, @Password)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DoctorName", text_DoctorName.Text);
                        command.Parameters.AddWithValue("@Specialization", text_Specialization.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", text_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@UserName", text_uesrname.Text);
                        command.Parameters.AddWithValue("@Password", text_password.Text); // يجب تشفير كلمة المرور في تطبيقات حقيقية
                        command.ExecuteNonQuery();
                        MessageBox.Show("تمت إضافة الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoctors(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء إضافة الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // تحديث بيانات طبيب
        private void btn_update_Click(object sender, EventArgs e)
        {
            string doctorId = text_doctorId.Text;
            if (ValidateInputs() && doctorId.Trim()!=null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Doctors SET DoctorName = @DoctorName, Specialization = @Specialization, PhoneNumber = @PhoneNumber, UserName = @UserName, Password = @Password WHERE DoctorId = @DoctorId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DoctorName", text_DoctorName.Text);
                        command.Parameters.AddWithValue("@Specialization", text_Specialization.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", text_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@UserName", text_uesrname.Text);
                        command.Parameters.AddWithValue("@Password", text_password.Text); // يجب تشفير كلمة المرور في تطبيقات حقيقية
                        command.Parameters.AddWithValue("@DoctorId",Convert.ToInt32( doctorId));

                        command.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        LoadDoctors(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء تحديث بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // حذف طبيب
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string doctorId = text_doctorId.Text;

            if (doctorId.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Doctors WHERE DoctorId = @DoctorId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DoctorId", doctorId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("تم حذف الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoctors(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء حذف الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // بحث عن طبيب
      
        // التحقق من البيانات المدخلة
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(text_DoctorName.Text) || string.IsNullOrEmpty(text_Specialization.Text) ||
                string.IsNullOrEmpty(text_PhoneNumber.Text) || string.IsNullOrEmpty(text_uesrname.Text) ||
                string.IsNullOrEmpty(text_password.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // مسح الحقول
        private void ClearInputs()
        {
            text_DoctorName.Clear();
            text_Specialization.Clear();
            text_PhoneNumber.Clear();
            text_uesrname.Clear();
            text_password.Clear();
            text_doctorId.Text="";
        }

      

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            
            string searchText = text_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT DoctorId, DoctorName, Specialization, PhoneNumber, UserName FROM Doctors WHERE DoctorName LIKE @SearchText OR Specialization LIKE @SearchText";
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
                LoadDoctors(); // إعادة تحميل جميع البيانات إذا كان حقل البحث فارغًا
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text_doctorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadDoctors();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {

        }

        
        // عند النقر على صف في DataGridView

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                text_doctorId.Text = row.Cells["DoctorId"].Value.ToString();
                text_DoctorName.Text = row.Cells["DoctorName"].Value.ToString();
                text_Specialization.Text = row.Cells["Specialization"].Value.ToString();
                text_PhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                text_uesrname.Text = row.Cells["UserName"].Value.ToString();
                text_password.Text = ""; // لا تعرض كلمة المرور لأسباب أمنية
            }
        }
    }
}
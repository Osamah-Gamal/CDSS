 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
   
    public partial class Patients : Form
    {
        // هنا يجب جلب ايدي الدكتور الذي يقوم بحفظ هذا المريض
        int doctorid ;
        public int UserID { get; set; }

        // سلسلة الاتصال بقاعدة البيانات
        string connectionString = "Server=MOHAMMED-ESMAIL;Database=CDSS;Integrated Security=True;";
        public Patients()
        {
            InitializeComponent();
            LoadPatients();
        }


        // دالة لتعيين البيانات في 
        public void SetUserData()
        {
            doctorid = UserID;
            
        }

        private void Patients_Load(object sender, EventArgs e)
        {
           

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
                        string query = "INSERT INTO Patients (PatientName , DateofBirth,Gender ,Address, PhoneNumber,DoctorId) VALUES ( @PatientName, @DateofBirth ,@Gender,@Address,@PhoneNumber,@DoctorId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PatientName", text_PatientName.Text);
                        command.Parameters.AddWithValue("@DateofBirth", text_DateofBirth.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", text_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@Gender", comb_Gender.Text);
                        command.Parameters.AddWithValue("@Address", text_Address.Text);
                        command.Parameters.AddWithValue("@DoctorId", doctorid);


                        command.ExecuteNonQuery();
                        MessageBox.Show("تمت ألاضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatients(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء إضافة : " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(text_PatientName.Text) || string.IsNullOrEmpty(text_DateofBirth.Text) || string.IsNullOrEmpty(text_PhoneNumber.Text) || string.IsNullOrEmpty(text_Address.Text) || string.IsNullOrEmpty(comb_Gender.Text))

            {
                MessageBox.Show("يرجى ملء جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

            string patientId = text_PatientId.Text;
            if (ValidateInputs() && patientId.Trim() != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Patients SET PatientName = @PatientName, DateofBirth = @DateofBirth ,Gender = @Gender,Address=@Address, PhoneNumber=@PhoneNumber,DoctorId=@DoctorId WHERE PatientId = @PatientId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PatientName", text_PatientName.Text);
                        command.Parameters.AddWithValue("@DateofBirth", text_DateofBirth.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", text_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@Gender", comb_Gender.Text);
                        command.Parameters.AddWithValue("@Address", text_Address.Text);
                        command.Parameters.AddWithValue("@DoctorId", doctorid);

                        command.Parameters.AddWithValue("@PatientId", Convert.ToInt32(patientId));


                        command.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الطبيب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        LoadPatients(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء تحديث بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string doctorId = text_PatientId.Text;

            if (doctorId.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Patients WHERE PatientId = @PatientId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PatientId", doctorId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatients(); // إعادة تحميل البيانات
                        ClearInputs(); // مسح الحقول
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يجب حذف البيانات المرتبطه به: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ClearInputs()
        {
            text_PatientId.Text = "";
            text_PatientName.Text = "";
            text_Address.Text = "";
            text_DateofBirth.Text = "";
            text_search.Text = "";
            comb_Gender.Text = "";
            text_PhoneNumber.Text = "";
        }
        private void LoadPatients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  PatientId, PatientName, DateofBirth,Gender,Address,PhoneNumber,DoctorId FROM Patients";
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
                        string query = "SELECT PatientId, PatientName, DateofBirth,Gender,Address,PhoneNumber,DoctorId FROM Patients WHERE PatientName LIKE @PatientName OR PatientId LIKE @SearchText";
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
                LoadPatients(); // إعادة تحميل جميع البيانات إذا كان حقل البحث فارغًا
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadPatients();
            ClearInputs();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // تجاهل النقر على رأس العمود
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            // التحقق من وجود القيم قبل التعيين
            text_PatientId.Text = row.Cells[0].Value?.ToString() ?? "";
            text_PatientName.Text = row.Cells[1].Value?.ToString() ?? "";
            text_Address.Text = row.Cells[4].Value?.ToString() ?? "";
            text_DateofBirth.Text = row.Cells[2].Value?.ToString() ?? "";
            text_PhoneNumber.Text = row.Cells[5].Value?.ToString() ?? "";
            comb_Gender.SelectedItem = row.Cells[3].Value?.ToString() ?? "";
           

        }
    }
}

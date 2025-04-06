using MetroFramework.Forms;
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
    public partial class DoctorAccount : MetroForm
    {

        string connectionString = "Server=DESKTOP-P90JUS9\\ZEYAD;Database=CDSS;Integrated Security=True;";

         public  int UserID;

        public DoctorAccount(int userId)
        {
            InitializeComponent();
            this.UserID = userId;

        }

        public class Doctor
        {
            public int DoctorId { get; set; }
            public string DoctorName { get; set; }
            public string Specialization { get; set; }
            public string PhoneNumber { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        private Doctor GetDoctorData(int doctorId)
        {
            Doctor doctor = null;
            string query = @"
        SELECT DoctorId, DoctorName, Specialization, PhoneNumber, UserName,Password 
        FROM Doctors 
        WHERE DoctorId = @DoctorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctorId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        doctor = new Doctor
                        {
                            DoctorId = reader.GetInt32(0),
                            DoctorName = reader.GetString(1),
                            Specialization = reader.GetString(2),
                            PhoneNumber = reader.GetString(3),
                            UserName = reader.GetString(4),
                            Password = reader.GetString(5)
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor data: " + ex.Message);
                }
            }
            return doctor;
        }

        private void LoadDoctorData()
        {
            Doctor doctor = GetDoctorData(this.UserID);
            if (doctor != null)
            {
                text_id.Text = doctor.DoctorId.ToString();
                text_fullname.Text = doctor.DoctorName;
                text_Specialization.Text = doctor.Specialization;
                text_phone.Text = doctor.PhoneNumber;
                text_username.Text = doctor.UserName;
                text_password.Text = doctor.Password;

            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // التحقق من الحقول المطلوبة
            if (string.IsNullOrWhiteSpace(text_fullname.Text) ||
                string.IsNullOrWhiteSpace(text_Specialization.Text) ||
                string.IsNullOrWhiteSpace(text_phone.Text) ||
                string.IsNullOrWhiteSpace(text_username.Text)  ||
                string.IsNullOrWhiteSpace(text_password.Text))
            {
                MessageBox.Show("اعد ملء الحقول الفارغة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // إنشاء كائن Doctor مع البيانات المحدثة
            Doctor updatedDoctor = new Doctor
            {
                DoctorId = Convert.ToInt32(text_id.Text),
                DoctorName = text_fullname.Text.Trim(),
                Specialization = text_Specialization.Text.Trim(),
                PhoneNumber = text_phone.Text.Trim(),
                UserName = text_username.Text.Trim(),
                Password = text_password.Text.Trim()
            };

            // تنفيذ التحديث
            if (UpdateDoctorData(updatedDoctor))
            {
                MessageBox.Show("Doctor updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update doctor.");
            }
        }

        private bool UpdateDoctorData(Doctor doctor)
        {
            string query = @"
        UPDATE Doctors 
        SET 
            DoctorName = @DoctorName,
            Specialization = @Specialization,
            PhoneNumber = @PhoneNumber,
            UserName = @UserName,
            Password=@Password
        WHERE 
            DoctorId = @DoctorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctor.DoctorId);
                command.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@PhoneNumber", doctor.PhoneNumber);
                command.Parameters.AddWithValue("@UserName", doctor.UserName);
                command.Parameters.AddWithValue("@Password", doctor.Password);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating doctor: " + ex.Message);
                    return false;
                }
            }
        }

        

        private void DoctorAccount_Load_1(object sender, EventArgs e)
        {
            LoadDoctorData();
        }
    }
}

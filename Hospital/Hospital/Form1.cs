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
    public partial class Form1 : MetroForm
    {
        string connectionString = "Server=MOHAMMED-ESMAIL;Database=CDSS;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string password = text_password.Text;
            
            // التحقق من المدخلات
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(com_usertype.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور ونوع الدخول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string usertype = com_usertype.SelectedItem.ToString(); // الحصول على نوع المستخدم المحدد

            // بناء الاستعلام بناءً على نوع المستخدم
            string query = "";
            if (usertype == "Admin")
            {
                query = "SELECT AdminId AS UserId, AdminName AS UserName FROM Admins WHERE UserName = @Username AND AdminPassword = @Password";
            }
            else if (usertype == "Doctor")
            {
                query = "SELECT DoctorId AS UserId, DoctorName AS UserName FROM Doctors WHERE UserName = @Username AND Password = @Password";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string userId = reader["UserId"].ToString();
                                string userName = reader["UserName"].ToString();
                                string userType = com_usertype.SelectedItem.ToString();

                                // إنشاء مثيل من HomeForm وتمرير البيانات إليه
                                Home homeForm = new Home();
                                homeForm.UserID = userId;
                                homeForm.UserName = userName;
                                homeForm.UserType = userType;

                                // تعيين Form1 كـ Owner لـ HomeForm
                                homeForm.Owner = this;

                                // تعيين البيانات في Label
                                homeForm.SetUserData();

                                // عرض HomeForm
                                homeForm.Show();

                                this.Hide(); // إخفاء نافذة تسجيل الدخول
                            }
                            else
                            {
                                MessageBox.Show("اسم المستخدم أو كلمة المرور او نوع الدخول غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

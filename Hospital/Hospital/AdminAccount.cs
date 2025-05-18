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
    public partial class AdminAccount : MetroForm
    {
        //DESKTOP-ALF92KC\\OSAMAH
        string connectionString = "Server=MOHAMMED-ESMAIL;Database=CDSS;Integrated Security=True;";

        int UserID;
      
        public class Admin
        {
            public int AdminId { get; set; }
            public string AdminName { get; set; }
            public string UserName { get; set; }
            public string AdminPassword { get; set; }

        }


        public AdminAccount(int userId)
        {
            InitializeComponent();
            this.UserID = userId;
        }


        // load data to fields
       private void load_data(int userId)
        {
            Admin admin = GetAdminData(userId);

            //  إذا وُجد المسؤول، نعبئ الحقول
            if (admin != null)
            {
                text_Id.Text = admin.AdminId.ToString();
                text_fullname.Text = admin.AdminName;
                text_username.Text = admin.UserName;
                text_password.Text = admin.AdminPassword;


                // إظهار الفورم إذا كان مخفيًا
                this.Show();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على المسؤول!");
            }
        }

        // get admin from database 
        public Admin GetAdminData(int adminId)
        {
            Admin admin = null;
            string query = "SELECT AdminId, AdminName, UserName,AdminPassword FROM Admins WHERE AdminId = @AdminId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminId", adminId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        admin = new Admin
                        {
                            AdminId = reader.GetInt32(0),
                            AdminName = reader.GetString(1),
                            UserName = reader.GetString(2),
                            AdminPassword = reader.GetString(3)
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return admin;
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            load_data(UserID);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // 1. التحقق من أن جميع الحقول مليئة
            if (string.IsNullOrWhiteSpace(text_Id.Text) ||
                string.IsNullOrWhiteSpace(text_fullname.Text) ||
                string.IsNullOrWhiteSpace(text_username.Text) ||
                string.IsNullOrWhiteSpace(text_password.Text))
            {
                MessageBox.Show("اعد ملء الحقول الفارغة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 3. إنشاء كائن Admin مع البيانات الجديدة
            Admin updatedAdmin = new Admin
            {
                AdminId = Convert.ToInt32(text_Id.Text),
                AdminName = text_fullname.Text.Trim(),
                UserName = text_username.Text.Trim(),
                AdminPassword = text_password.Text // ⚠️ في الواقع يجب تشفيرها قبل الحفظ
            };

            // 4. تنفيذ عملية التحديث في قاعدة البيانات
            try
            {
                bool isUpdated = UpdateAdminData(updatedAdmin);

                if (isUpdated)
                {
                    MessageBox.Show("تم تحديث البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على المسؤول للتحديث!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء التحديث: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //--
        private bool UpdateAdminData(Admin admin)
        {
            string query = @"
        UPDATE Admins 
        SET 
            AdminName = @AdminName,
            UserName = @UserName,
            AdminPassword = @AdminPassword
        WHERE 
            AdminId = @AdminId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminId", admin.AdminId);
                command.Parameters.AddWithValue("@AdminName", admin.AdminName);
                command.Parameters.AddWithValue("@UserName", admin.UserName);
                command.Parameters.AddWithValue("@AdminPassword", admin.AdminPassword);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}

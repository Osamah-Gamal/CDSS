using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Home : MetroForm
    {
        // خصائص لتخزين بيانات المستخدم
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }


        public Home()
        {
            InitializeComponent();
            // إضافة حدث FormClosed
        }
       
        private void Home_Load(object sender, EventArgs e)
        {

        }

        // دالة لتعيين البيانات في Label
        public void SetUserData()
        {
            lb_userid.Text = UserID;
            lb_username.Text = UserName;
            lb_usertype.Text = UserType;
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
          

        }
        private void btn_symptoms_Click(object sender, EventArgs e)
        {
            // إنشاء الفورم الذي تريد عرضه
            DiseaseTypes diseaseTypes = new DiseaseTypes();
            diseaseTypes.TopLevel = false;  // يجعل الفورم غير مستقل
            diseaseTypes.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل

            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();

            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(diseaseTypes);
            diseaseTypes.Show();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            // إنشاء الفورم الذي تريد عرضه
            Doctors doctorsForm = new Doctors();
            doctorsForm.TopLevel = false;  // يجعل الفورم غير مستقل
            doctorsForm.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل

            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();

            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(doctorsForm);
            doctorsForm.Show();
        }

        private void Home_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            // لا تضع this.Close() هنا أبداً
            Application.Exit(); // فقط إذا كنت تريد إنهاء التطبيق بالكامل
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            int userId =Convert.ToInt32(lb_userid.Text);

            Patients patient = new Patients();

            // إنشاء مثيل من patient وتمرير البيانات إليه
            patient.UserID = userId;



            // تعيين البيانات في Label
            patient.SetUserData();

            // عرض HomeForm
            patient.Show();

            patient.TopLevel = false;  // يجعل الفورم غير مستقل
            patient.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل

            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();

            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(patient);
            patient.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            // لا تضع this.Close() هنا أبداً
            Application.Exit(); // فقط إذا كنت تريد إنهاء التطبيق بالكامل
        }
    }
}

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


        private System.Windows.Forms.Timer timer;


        public Home()
        {
            InitializeComponent();
        }
       
        private void Home_Load(object sender, EventArgs e)
        {
            // تعيين التاريخ الحالي عند التحميل
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // تهيئة التايمر للتحديث التلقائي
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // كل 1000 مللي ثانية (1 ثانية)
            timer.Tick += Timer_Tick;
            timer.Start();

            // تعيين الوقت الحالي فورًا
            UpdateTime();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
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
           



            // check user type to open the accoun form for the same user

            if (lb_usertype.Text== "Admin")
            {
               
                try
                {
                    int doctorId = Convert.ToInt32(lb_userid.Text); // أو من أي مصدر آخر

                    AdminAccount admin = new AdminAccount(doctorId);
                    admin.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (lb_usertype.Text == "Doctor")
            {
                try
                {
                    int doctorId = Convert.ToInt32(lb_userid.Text); // أو من أي مصدر آخر
                    DoctorAccount doctorForm = new DoctorAccount(doctorId);
                    doctorForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Restart app...!");
            }

        }
        private void btn_symptoms_Click(object sender, EventArgs e)
        {
            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();

            // إنشاء الفورم الذي تريد عرضه
            DiseaseTypes diseaseTypes = new DiseaseTypes();
            diseaseTypes.TopLevel = false;  // يجعل الفورم غير مستقل
            diseaseTypes.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل
            diseaseTypes.FormBorderStyle = FormBorderStyle.None; // إزالة حدود النموذج

            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(diseaseTypes);
            diseaseTypes.Show();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();

            // إنشاء الفورم الذي تريد عرضه
            Doctors doctorsForm = new Doctors();
            doctorsForm.TopLevel = false;  // يجعل الفورم غير مستقل
            doctorsForm.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل
            doctorsForm.FormBorderStyle = FormBorderStyle.None; // إزالة حدود النموذج

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

            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();  


            int userId =Convert.ToInt32(lb_userid.Text);

            Patients patient = new Patients();

            // إنشاء مثيل من patient وتمرير البيانات إليه
            patient.UserID = userId;

            // تعيين البيانات في Label
            patient.SetUserData();



            patient.TopLevel = false;  // يجعل الفورم غير مستقل
            patient.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل
            patient.FormBorderStyle = FormBorderStyle.None; // إزالة حدود النموذج

            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(patient);
            patient.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Application.Exit(); //  إنهاء التطبيق بالكامل
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            // مسح أي محتوى داخل الـ Panel قبل عرض الفورم الجديد
            show_screen.Controls.Clear();
           

            Results re = new Results();

            re.TopLevel = false;  // يجعل الفورم غير مستقل
            re.Dock = DockStyle.Fill;  // يجعل الفورم يملأ الـ Panel بالكامل
            re.FormBorderStyle = FormBorderStyle.None; // إزالة حدود النموذج


            // إضافة الفورم إلى الـ Panel
            show_screen.Controls.Add(re);

            
            re.Show();
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

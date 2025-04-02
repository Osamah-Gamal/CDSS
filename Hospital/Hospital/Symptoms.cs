
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

namespace Hospital
{
    public partial class Symptoms :  Form
    {
        public Symptoms()
        {
            InitializeComponent();
        }

        private void Symptoms_Load(object sender, EventArgs e)
        {

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
                string excelsheet = dt.Rows[1]["TABLE_NAME"].ToString();
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
                                //else
                                //{
                                //    MessageBox.Show($"العرض '{symptomName}' موجود مسبقًا، سيتم تخطيه!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //}
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
    }
}

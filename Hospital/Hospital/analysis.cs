using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class analysis : Form
    {
        int doctorid;
        public int UserID { get; set; }

        public analysis()
        {
            InitializeComponent();
        }


        private readonly string _apiKey = "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";
        private readonly string _baseUrl = "https://openrouter.ai/api/v1";

        string connectionString = "Server=MOHAMMED-ESMAIL;Database=CDSS;Integrated Security=True;";

        // دالة لتعيين البيانات في 
        public void SetUserData()
        {
            doctorid = UserID;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void btn_gethistory_Click(object sender, EventArgs e)
        {

        }

        private async void btn_analysis_Click(object sender, EventArgs e)
        {
            // التحقق من وجود نص في صندوق النص
            if (string.IsNullOrEmpty(txtSymptoms.Text))
            {
                MessageBox.Show("الرجاء إدخال الأعراض أولاً", "تحذير",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // تعطيل الزر أثناء المعالجة
                btn_analysis.Enabled = false;
                btn_analysis.Text = "جاري التحليل...";

                // استدعاء دالة التحليل مع تمرير نص الأعراض
                var analysis = await AnalyzeSymptomsAsync(txtSymptoms.Text.Trim());

                // عرض النتائج في صندوق النص المخصص للنتائج
                DisplayAnalysisResults(analysis);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                // إعادة تمكين الزر بعد الانتهاء
                btn_analysis.Enabled = true;
                btn_analysis.Text = "تحليل الأعراض";
            }
        }

        public class SymptomAnalysis
        {
            public string Diagnosis { get; set; }
            public string AdditionalSymptomsToCheck { get; set; }
            public string RecommendedTests { get; set; }
            public string Notes { get; set; }
        }

        private void DisplayAnalysisResults(SymptomAnalysis analysis)
        {
            var result = new StringBuilder();

            result.AppendLine("═════════ التشخيص المحتمل ═════════");
            result.AppendLine(analysis.Diagnosis);
            result.AppendLine();

            result.AppendLine("═════════ أعراض إضافية للتأكد ═════════");
            result.AppendLine(analysis.AdditionalSymptomsToCheck);
            result.AppendLine();

            result.AppendLine("═════════ فحوصات مقترحة ═════════");
            result.AppendLine(analysis.RecommendedTests);
            result.AppendLine();

            result.AppendLine("═════════ ملاحظات طبية ═════════");
            result.AppendLine(analysis.Notes);

            txtResult.Text = result.ToString();
            SaveAnalysisToDatabase(analysis);
        }



        private async Task SaveAnalysisToDatabase(SymptomAnalysis analysis)
        {
            
            if (combo_PatientNames.SelectedValue == null || !int.TryParse(combo_PatientNames.SelectedValue.ToString(), out int patientId))
            {
                MessageBox.Show("يرجى اختيار مريض من القائمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int doctorId = doctorid; // يمكن تغييرها حسب الحاجة

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = @"INSERT INTO SymptomsHistory 
                   (AnalysisDate, Symptoms, Diagnosis, 
                    RecommendedTests, AdditionalNotes,
                    PatientId, DoctorId)
                   VALUES 
                   (@AnalysisDate, @Symptoms, @Diagnosis, 
                    @RecommendedTests, @AdditionalNotes,
                    @PatientId, @DoctorId);
                   SELECT SCOPE_IDENTITY();"; // للحصول على المعرف المنشأ

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@AnalysisDate", SqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@Symptoms", SqlDbType.NVarChar).Value = txtSymptoms.Text.Trim();
                        command.Parameters.Add("@Diagnosis", SqlDbType.NVarChar, 1000).Value =
                            string.IsNullOrEmpty(analysis.Diagnosis) ? "N/A" : analysis.Diagnosis;
                        command.Parameters.Add("@RecommendedTests", SqlDbType.NVarChar).Value =
                            string.IsNullOrEmpty(analysis.RecommendedTests) ? "N/A" : analysis.RecommendedTests;
                        command.Parameters.Add("@AdditionalNotes", SqlDbType.NVarChar).Value =
                            string.IsNullOrEmpty(analysis.Notes) ? "N/A" : analysis.Notes;
                        command.Parameters.Add("@PatientId", SqlDbType.Int).Value = patientId;
                        command.Parameters.Add("@DoctorId", SqlDbType.Int).Value = doctorId;

                        // تنفيذ الأمر وإرجاع عدد الصفوف المتأثرة
                        object result = await command.ExecuteScalarAsync();

                        if (result != null)
                        {
                            int newId = Convert.ToInt32(result);
                            MessageBox.Show($"تم حفظ التحليل بنجاح برقم: {newId}", "نجاح",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("تم تنفيذ الأمر ولكن لم يتم إرجاع معرف", "تحذير",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                string errorMessage = $"خطأ في قاعدة البيانات: {ex.Message}";
                if (ex.Number == 2627) // خطأ تكرار مفتاح
                {
                    errorMessage = "هذا السجل موجود مسبقاً في قاعدة البيانات";
                }
                MessageBox.Show(errorMessage, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task PingServerAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    var response = await client.GetAsync("https://openrouter.ai");
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception("الخادم غير متاح");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"⚡ لا يمكن الوصول للخادم: {ex.Message}");
            }
        }


        public async Task<SymptomAnalysis> AnalyzeSymptomsAsync(string symptoms)
        {
            // التحقق من اتصال الخادم أولاً
            await PingServerAsync();

            using (var client = new HttpClient())
            {
                // تهيئة رأس الطلب
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

                // بناء جسم الطلب
                var requestBody = BuildRequestBody(symptoms);
                var content = new StringContent(
                    JsonConvert.SerializeObject(requestBody),
                    Encoding.UTF8,
                    "application/json");

                // إرسال الطلب مع تحديد وقت انتظار
                var response = await client.PostAsync($"{_baseUrl}/chat/completions", content)
                    ;

                // معالجة الاستجابة
                return await ProcessApiResponse(response);
            }
        }

        private object BuildRequestBody(string symptoms)
        {
            string systemPrompt = @"أنت مساعد طبي متخصص. أجب بطريقة منظمة ومحددة وفق التالي:

1. التشخيص المحتمل:
[اذكر هنا التشخيصات المحتملة مرتبة حسب الاحتمالية]

2. أعراض إضافية:
[اذكر هنا الأعراض التي يجب التحقق منها]

3. الفحوصات الطبية:
[اذكر هنا الفحوصات المطلوبة]

4. الملاحظات:
[اذكر هنا أي ملاحظات إضافية]

الرجاء الالتزام بهذا التنسيق بدقة.";

            return new
            {
                model = "openai/gpt-3.5-turbo",
                messages = new[]
                {
            new { role = "system", content = systemPrompt },
            new { role = "user", content = $"الأعراض: {symptoms}" }
        },
                temperature = 0.3,
                max_tokens = 1500,
                response_format = new { type = "text" }
            };
        }

        private async Task<SymptomAnalysis> ProcessApiResponse(HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"خطأ في API: {response.StatusCode} - {responseContent}");
            }

            try
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                string aiResponse = jsonResponse.choices[0].message.content;

                // استخراج الأقسام مع تحسين التنسيق
                return new SymptomAnalysis
                {
                    Diagnosis = FormatSection(ExtractSection(aiResponse, "1. التشخيص المحتمل:", "2. أعراض إضافية:")),
                    AdditionalSymptomsToCheck = FormatSection(ExtractSection(aiResponse, "2. أعراض إضافية:", "3. الفحوصات الطبية:")),
                    RecommendedTests = FormatSection(ExtractSection(aiResponse, "3. الفحوصات الطبية:", "4. الملاحظات:")),
                    Notes = ExtractSection(aiResponse, "4. الملاحظات:", null)
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل تحليل الاستجابة: {ex.Message}");
            }
        }
        private string FormatSection(string text)
        {
            if (text == "غير محدد") return text;

            // تحقق إذا كان النص يحتوي على أكثر من عنصر
            var lines = text.Split('\n')
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim())
                .ToList();

            if (lines.Count <= 1) return text;

            // إذا كان هناك أكثر من عنصر، نقوم بترقيمهم
            var result = new StringBuilder();
            for (int i = 0; i < lines.Count; i++)
            {
                // إزالة أي ترميز موجود مسبقاً (- أو •)
                string line = lines[i].TrimStart('-', '•', ' ', '\t');
                result.AppendLine($"{i + 1}. {line}");
            }

            return result.ToString();
        }

        // دالة مساعدة لاستخراج الأقسام
        private string ExtractSection(string text, string startHeader, string nextHeader)
        {
            try
            {
                int startIndex = text.IndexOf(startHeader);
                if (startIndex == -1) return "غير محدد";

                startIndex += startHeader.Length;
                int endIndex = nextHeader != null ? text.IndexOf(nextHeader, startIndex) : text.Length;

                if (endIndex == -1) endIndex = text.Length;

                string result = text.Substring(startIndex, endIndex - startIndex).Trim();

                // تنظيف النتيجة من أي رموز أو مسافات زائدة
                result = Regex.Replace(result, @"^\s*[\r\n:-]+\s*", "").Trim();
                return string.IsNullOrWhiteSpace(result) ? "غير محدد" : result;
            }
            catch
            {
                return "غير محدد";
            }
        }

        private void LoadPatientNames()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("SELECT PatientId, PatientName FROM Patients", conn);
                    conn.Open();

                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    combo_PatientNames.DataSource = dt;
                    combo_PatientNames.DisplayMember = "PatientName";
                    combo_PatientNames.ValueMember = "PatientId";

                    var autoComplete = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows)
                        autoComplete.Add(row["PatientName"].ToString());

                    combo_PatientNames.AutoCompleteCustomSource = autoComplete;
                    combo_PatientNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    combo_PatientNames.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void analysis_Load(object sender, EventArgs e) => LoadPatientNames();
    }
}
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
    public partial class HistoryForm : Form
    {
        
        public  HistoryForm()
        {
            InitializeComponent();
        }

        private void LoadHistory(List<Emergency> history)
        {
            // يمكنك استخدام DataGridView أو ListView لعرض البيانات
            // هذا مثال مبسط:
            var grid = (DataGridView)this.Controls[0];
            grid.DataSource = history
                .OrderByDescending(x => x.Date)
                .Select(x => new
                {
                    التاريخ = x.Date.ToString("yyyy-MM-dd HH:mm"),
                    الأعراض = x.Symptoms,
                    التشخيص = x.Diagnosis,
                    حالة_طارئة = x.IsEmergency ? "نعم" : "لا"
                })
                .ToList();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}

  

   

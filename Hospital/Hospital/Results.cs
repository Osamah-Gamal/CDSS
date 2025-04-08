
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
    public partial class Results :  Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDSSDataSet.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter.Fill(this.cDSSDataSet.Results);
            // TODO: This line of code loads data into the 'cDSSDataSet4.Results' table. You can move, or remove it, as needed.
 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

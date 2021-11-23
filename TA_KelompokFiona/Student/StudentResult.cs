using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_KelompokFiona.Student
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
            dg2.Hide();
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String sessionid = dg1.Rows[e.RowIndex].Cells[0].Value.ToString();
            loadExamResult(sessionid);
        }

        private void loadExamResult(String sessionid)
        {

        }
    }
}

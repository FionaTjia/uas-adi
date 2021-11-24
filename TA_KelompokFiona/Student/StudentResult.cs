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

namespace TA_KelompokFiona.Student
{
    public partial class StudentResult : Form
    {
        String studentid;        
        public StudentResult(String studentid)
        {
            InitializeComponent();
            dg2.Hide();
            this.studentid = studentid;
        }

       

        private void loadExamResult(String sessionid)
        {
            String query = "select question,a.answer,q.answer,a.result from answers a inner join questions q on q.questionid = a.questionid where sessionid = @sessionid";
            SqlCommand cmd = new SqlCommand(query, connection.DBConnection.cnn);            
            cmd.Parameters.AddWithValue("@sessionid", sessionid);
            SqlDataReader reader = cmd.ExecuteReader();
            dg2.Rows.Clear();
            dg2.Show();
            while (reader.Read())
            {
                String score = "Correct";
                if (reader.GetInt16(3) == 0)
                {
                    score = "Incorrect";
                }
                String[] a = new String[] { reader.GetString(0),reader.GetString(1),reader.GetString(2) ,score};
                dg2.Rows.Add(a);
            }
            reader.Close();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'h1.answers' table. You can move, or remove it, as needed.
            this.answersTableAdapter.Fill(this.h1.answers, int.Parse(studentid));
        }

        private void dg1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String sessionid = dg1.Rows[e.RowIndex].Cells[1].Value.ToString();
            loadExamResult(sessionid);
        }
    }
}

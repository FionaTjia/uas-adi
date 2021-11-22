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
    public partial class StudentHome : Form
    {
        private String studentid;
        private String name;
        private Form parent;
        public StudentHome(String id , String name,Form parent)
        {
            InitializeComponent();
            this.studentid = id;
            this.name = name;
            this.parent = parent;
            loadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Index == e.RowIndex)
                    {
                        r.Selected = true;
                        continue;
                    }
                    r.Selected = false;
                }
                Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
                contextMenuStrip1.Show(point);

                int count = takenExamCount();
                if (count == 1)
                {
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[0].Enabled = false;
                } else if(count == 2)
                {
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[0].Enabled = false;
                }
            }
        }
        private void loadData()
        {
            String query = "select topik from students where student_id = @id";
            SqlCommand cmd = new SqlCommand(query, connection.DBConnection.cnn);
            cmd.Parameters.AddWithValue("@id", studentid);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                String topik = reader.GetString(0);
                dataGridView1.Rows.Add(topik);
            }
            reader.Close();
        }
        private int takenExamCount()
        {
            SqlCommand cmd;
            String topik = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String query = "select sessionid, count(*) from answers where topik = @topik and studentid = @id group by sessionid";
            cmd = new SqlCommand(query, connection.DBConnection.cnn);
            cmd.Parameters.AddWithValue("@topik",topik);
            cmd.Parameters.AddWithValue("@id",studentid);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
            return count;
        }

        private void mulaiUjianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String topik = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Form f = new Exam.Exam(studentid,topik,parent);
            parent.Hide();
            f.Show();
        }
    }
}

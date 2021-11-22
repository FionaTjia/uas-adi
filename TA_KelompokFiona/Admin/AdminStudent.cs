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
using TA_KelompokFiona.connection;
namespace TA_KelompokFiona.Admin
{
    public partial class AdminStudent : Form
    {
        List<TextBox> inputs = new List<TextBox>();
        private bool addNew = true;
       
        public AdminStudent()
        {
            InitializeComponent();
            inputs.Add(txtbNamaStu);
            inputs.Add(txtbEmailStu);
            inputs.Add(txtbPassStu);
            inputs.Add(txtbHPStu);
            editingLabel.Text = "";
            
        }

        private void AdminStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tA_KelompokFionaDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.tA_KelompokFionaDataSet1.students);

        }

        private void adminSaveBtn_Click(object sender, EventArgs e)
        {
            String query;
            SqlCommand cmd;
          
            if (addNew)
            {
                query = "INSERT INTO students(student_name,student_email,student_password,student_phone,topik,active) values(@name,@email,@password,@phone,@topik,1) ";
                cmd = new SqlCommand(query, DBConnection.cnn);
                cmd.Parameters.AddWithValue("@name", inputs[0].Text);
                cmd.Parameters.AddWithValue("@email", inputs[1].Text);
                cmd.Parameters.AddWithValue("@password", inputs[2].Text);
                cmd.Parameters.AddWithValue("@phone", inputs[3].Text);
                cmd.Parameters.AddWithValue("@topik", comboBox1.Text);
            } else
            {
                query = "UPDATE students SET student_name = @name, student_email = @email, student_password = @password, student_phone = @phone , topik = @topik where student_id = @id";
                cmd = new SqlCommand(query, DBConnection.cnn);
                String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", inputs[0].Text);
                cmd.Parameters.AddWithValue("@email", inputs[1].Text);
                cmd.Parameters.AddWithValue("@password", inputs[2].Text);
                cmd.Parameters.AddWithValue("@phone", inputs[3].Text);
                cmd.Parameters.AddWithValue("@topik", comboBox1.Text);
            }
            try
            {
                cmd.ExecuteNonQuery();
            } catch(SqlException err)
            {
                if(err.Number == 2627)
                {
                    MessageBox.Show("Email sudah terdaftar");
                }else 
                MessageBox.Show(err.Message);
            }
            
            clear();
            refresh();
            this.addNew = true;
            editingLabel.Text = "";
        }

        private void clear()
        {
            foreach(TextBox t in inputs)
            {
                t.Text = "";
            }
            comboBox1.SelectedItem = null;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = (String) dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String query = "delete from students where student_id = @Id";
            SqlCommand cmd = new SqlCommand(query, DBConnection.cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            refresh();
        }

        private void aCTIVEDEACTIVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = (String)dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String active = (String)dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (active.Equals("1"))
                active = "0";
            else
                active = "1";

            String query = "update students set active = @active where student_id = @id";
            SqlCommand cmd = new SqlCommand(query, DBConnection.cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@active", active);
            cmd.ExecuteNonQuery();
            refresh();
        }

        private void refresh()
        {            
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            this.studentsTableAdapter.Fill(this.tA_KelompokFionaDataSet1.students);
            dataGridView1.DataSource = studentsBindingSource;          
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    if(r.Index == e.RowIndex)
                    {
                        r.Selected = true;
                        continue;
                    }
                    r.Selected = false;
                }
                Point point= new Point(Cursor.Position.X, Cursor.Position.Y);              
                ctmStudentAdmin.Show(point);                
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addNew = false;
            DataGridViewCellCollection cells = dataGridView1.SelectedRows[0].Cells;
            inputs[0].Text = getCellValue(cells,1);
            inputs[1].Text = getCellValue(cells, 2);
            inputs[2].Text = getCellValue(cells, 3);
            comboBox1.Text = getCellValue(cells, 5);
            inputs[3].Text = getCellValue(cells, 4);
            editingLabel.Text = "Editing student id : " + getCellValue(cells, 0);
        }

        private String getCellValue(DataGridViewCellCollection c, int idx)
        {
            return c[idx].Value.ToString();
        }
    }
}

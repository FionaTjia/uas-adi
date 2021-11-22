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

namespace TA_KelompokFiona.Admin
{
    public partial class AdminQuestions : Form
    {
        private List<String> topik = new List<String>();
        private List<TextBox> inputs = new List<TextBox>();
        private String selectedTopik = null;
        private bool  isEdit = false;
        public AdminQuestions()
        {
            InitializeComponent();
            getTopics();
            loadData();
            inputs.Clear();
            inputs.Add(textBoxA);
            inputs.Add(textBoxB);
            inputs.Add(textBoxC);                        
            editLabel.Text = "";
            comboBox2.SelectedIndex = 0;
            
        }

        private void getTopics()
        {
            String query = "select topik from questions group by topik";
            SqlCommand cmd = new SqlCommand(query,connection.DBConnection.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            topik.Clear();
            while (reader.Read())
            {
                topik.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void loadData()
        {
            
            foreach (String t in topik)
            {                
                dataGridView1.Rows.Add(t);
            }
        }

        private void AdminQuestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tA_KelompokFionaDataSetQuestion.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.All(this.tA_KelompokFionaDataSetQuestion.questions);
            setCount();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTopik = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.questionsTableAdapter.Fill(this.tA_KelompokFionaDataSetQuestion.questions,selectedTopik);
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = questionsBindingSource;
            dataGridView2.Refresh();
            setCount();
        }

        private void setCount()
        {
            setTopikCount();
            setQuestionCount();
        }
        private void setTopikCount()
        {
            topikCountLabel.Text = "Total topik : " + dataGridView1.Rows.Count;
        }

        private void setQuestionCount()
        {
            questionCountLabel.Text = "Total Question : " + dataGridView2.Rows.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String question = richTextBoxQ.Text;
            String a = inputs[0].Text;
            String b = inputs[1].Text;
            String c = inputs[2].Text;
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Masukan jawaban");
                return;
            }
            String answer = comboBox1.SelectedItem.ToString();
            String t = comboBox2.SelectedItem.ToString();
            String query;
            SqlCommand cmd;
            if (!isEdit)
            {
                query = "INSERT INTO questions (question,a,b,c,answer,topik) VALUES(@question,@a,@b,@c,@answer,@topik)";
                cmd = new SqlCommand(query, connection.DBConnection.cnn);
                cmd.Parameters.AddWithValue("@question",question);
                cmd.Parameters.AddWithValue("@a",a);
                cmd.Parameters.AddWithValue("@b",b);
                cmd.Parameters.AddWithValue("@c",c);
                cmd.Parameters.AddWithValue("@answer",answer);
                cmd.Parameters.AddWithValue("@topik",t);
                cmd.ExecuteNonQuery();
            }else
            {
                query = "UPDATE questions SET question = @question, a = @a , b = @b , c = @c , answer = @answer , topik = @topik where questionid = @id";
                cmd = new SqlCommand(query, connection.DBConnection.cnn);
                cmd.Parameters.AddWithValue("@id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@question", question);
                cmd.Parameters.AddWithValue("@a", a);
                cmd.Parameters.AddWithValue("@b", b);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@answer", answer);
                cmd.Parameters.AddWithValue("@topik", t);
                cmd.ExecuteNonQuery();
            }
            clearInput();
            refresh();
        }
        private void refresh()
        {
            dataGridView1.Rows.Clear();
            getTopics();
            loadData();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            if(selectedTopik != null)
            {
                this.questionsTableAdapter.Fill(this.tA_KelompokFionaDataSetQuestion.questions, selectedTopik);
                dataGridView2.DataSource = questionsBindingSource;
            }else
            {
                this.questionsTableAdapter.All(this.tA_KelompokFionaDataSetQuestion.questions);
                dataGridView2.DataSource = tAKelompokFionaDataSetBindingSource;
            }
            setCount();
        }
        private void clearInput()
        {
            this.isEdit = false;
            foreach(TextBox t in inputs)
            {
                t.Text = "";
            }
            richTextBoxQ.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedIndex = 0;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            String query = "delete from questions where questionid = @id";
            SqlCommand cmd = new SqlCommand(query,connection.DBConnection.cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            refresh();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow r in dataGridView2.Rows)
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
            }
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            DataGridViewCellCollection c = dataGridView2.SelectedRows[0].Cells;
            isEdit = true;
            richTextBoxQ.Text = getCellValue(c,1);
            inputs[0].Text = getCellValue(c,2);
            inputs[1].Text = getCellValue(c, 3);
            inputs[2].Text = getCellValue(c, 4);
            comboBox1.Text = getCellValue(c, 5);
            comboBox2.Text = getCellValue(c, 6);
            editLabel.Text = "Editing uestionid : " + id;
        }

        private String getCellValue(DataGridViewCellCollection c, int idx)
        {
            return c[idx].Value.ToString();
        }
    }    
}

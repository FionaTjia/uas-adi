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

namespace TA_KelompokFiona.Exam
{
    public partial class Exam : Form
    {
        private String sessionid;
        private String topik;
        private String id;
        private List<Questions> questions = new List<Questions>();
        private DateTime startTime;
        private Form parent;
        private int page = 0;
        private Dictionary<int, string> answers = new Dictionary<int, string>();

        public Exam(String id,String topik,Form parent)
        {
            InitializeComponent();
            this.id = id;
            this.topik = topik;
            generateSessionId();
            getSoal();
            loadQuestion();
            setBtn();
            startTime = DateTime.Now;
            timer1.Start();
            this.parent = parent;
        }

        private void generateSessionId()
        {
            this.sessionid = System.Guid.NewGuid().ToString();
        }

        private void getSoal()
        {
            String query = "select top 10 * from questions where topik = @topik order by newid()";
            SqlCommand cmd = new SqlCommand(query,connection.DBConnection.cnn);
            String t = this.topik.Trim();
            cmd.Parameters.AddWithValue("@topik", t);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var q = new Questions(reader);
                questions.Add(q);
            }
            reader.Close();
            
        }

        public class Questions
        {
            public String id { get; set; }
            public String q { get; set; }
            public String a { get; set; }
            public String b { get; set; }
            public String c { get; set; }
            public String ans
            {
                get; set;
            }
            public Questions(SqlDataReader reader)
            {
                this.id = reader.GetInt32(0).ToString();
                this.q = reader.GetString(1);
                this.a = reader.GetString(2);
                this.b = reader.GetString(3);
                this.c = reader.GetString(4);
                this.ans = reader.GetString(5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            TimeSpan ts = currenTime - startTime;
            
            int seconds = (int)(60 - (Math.Truncate(ts.TotalSeconds) % 60));
            int minutes = (int)(19 - Math.Truncate(ts.TotalMinutes));
            timerLabel.Text = minutes + ":" + seconds;
            if(seconds <= 0 && minutes <= 0 )
            {
                timer1.Stop();
                saveAnswer();
            }
        }

        private void loadQuestion()
        {
            Questions q = questions[page];
            noLabel.Text = (page + 1) + ".";
            qT.Text = q.q;
            rA.Text = q.a;
            rB.Text = q.b;
            rC.Text = q.c;
            if (answers.ContainsKey(page))
            {
                String a;
                answers.TryGetValue(page, out a);
                if (a == "a")
                    rA.Checked = true;
                else if (a == "b")
                    rB.Checked = true;
                else if (a == "c")
                    rC.Checked = true;
            }
            else 
                foreach (Control c in radioP.Controls)
                {                                
                    if(c is RadioButton)
                    {
                        RadioButton r = (RadioButton) c;
                        r.Checked = false;
                    }
                }            
        }

        private bool canNext()
        {
            return page < questions.Count() - 1;
        }

        private bool canPrev()
        {
            return page != 0;
        }

        private void nB_Click(object sender, EventArgs e)
        {
            this.page++;
            setBtn();
            loadQuestion();
        }

        private void rA_CheckedChanged(object sender, EventArgs e)
        {
            if (rA.Checked)
            {

                answers[page] = "a";
            }
        }

        private void rB_CheckedChanged(object sender, EventArgs e)
        {
            if(rB.Checked)
            {
                answers[page] = "b";                
            }
        }

        private void rC_CheckedChanged(object sender, EventArgs e)
        {
            if (rC.Checked)
            {
                answers[page] = "c";
            }
        }

        private void saveAnswer()
        {            
            for (int i = 0; i < 10; i++)
            {
                if (answers.ContainsKey(i))
                {
                    String query = "INSERT INTO answers(sessionid,topik,studentid,questionid,answer,result) " +
                        "values(@sessionid,@topik,@studentid,@questionid,@answer,@result)";
                    SqlCommand cmd = new SqlCommand(query, connection.DBConnection.cnn);
                    string studentAnswer;
                    answers.TryGetValue(i, out studentAnswer);
                    cmd.Parameters.AddWithValue("@sessionid", sessionid);
                    cmd.Parameters.AddWithValue("@topik", topik);
                    cmd.Parameters.AddWithValue("@studentid", id);
                    cmd.Parameters.AddWithValue("@questionid", questions[i].id);

                    cmd.Parameters.AddWithValue("@answer", studentAnswer);
                    int result = 0;
                    if (studentAnswer == questions[i].ans)
                        result = 1;
                    cmd.Parameters.AddWithValue("@result", result);
                    cmd.ExecuteNonQuery();
                }                      
            }
            Form f = new ExamResult(answers,questions,this,parent);
            f.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            List<String> lines = new List<String>();
            for (int i = 0; i < 10; i++)
            {
                if (!answers.ContainsKey(i))
                {
                    flag = false;
                    lines.Add((i + 1 ).ToString()); 
                }
            }
            if(flag)
                saveAnswer();
            else
                MessageBox.Show("Soal " + String.Join(",",lines) + " Belom dijawab");
        }

        private void pB_Click(object sender, EventArgs e)
        {
            this.page--;
            setBtn();
            loadQuestion();
        }
        private void setBtn()
        {
            if (canNext())
            {
                nB.Enabled = true;
            }
            else
            {
                nB.Enabled = false;
            }
            if (canPrev())
            {
                pB.Enabled = true;
            }
            else
            {
                pB.Enabled = false;
            }
        }
    }
}

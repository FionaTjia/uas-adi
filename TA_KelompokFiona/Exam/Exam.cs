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
        private int page= 0;


        public Exam(String id,String topik,Form parent)
        {
            InitializeComponent();
            this.id = id;
            this.topik = topik;
            generateSessionId();
            getSoal();
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
            String query = "select top 10 percent * from questions where topik = @topik order by newid()";
            SqlCommand cmd = new SqlCommand(query,connection.DBConnection.cnn);
            cmd.Parameters.AddWithValue("@topik", this.topik);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var q = new Questions(reader);
                questions.Add(q);
            }
            reader.Close();

        }

        private class Questions
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
                this.a = reader.GetString(1);
                this.b = reader.GetString(2);
                this.c = reader.GetString(3);
                this.ans = reader.GetString(4);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            TimeSpan ts = currenTime - startTime;
            
            String seconds = (60 - (Math.Truncate(ts.TotalSeconds) % 60)).ToString();
            String minutes = (19 - Math.Truncate(ts.TotalMinutes)).ToString();
            timerLabel.Text = minutes + ":" + seconds;
        }

        private void loadQuestion()
        {
            Questions q = questions[page];
            qT.Text = q.q;
            rA.Text = q.a;
            rB.Text = q.b;
            rC.Text = q.c;
            foreach(Control c in radioP.Controls)
            {
                if(c is RadioButton)
                {
                    //c.
                }
            }
        }

        private bool canNext()
        {
            return page < questions.Count();
        }

        private bool canPrev()
        {
            return page != 0;
        }
    }
}

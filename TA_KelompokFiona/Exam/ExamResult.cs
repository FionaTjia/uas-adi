using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_KelompokFiona.Exam
{
    public partial class ExamResult : Form
    {
        Dictionary<int, string> answers;
        List<Exam.Questions> questions;
        int correctCount = 0;
        Form parent;
        Form mainForm;
        public ExamResult(Dictionary<int,string> answers, List<Exam.Questions> questions,Form parent,Form mainForm)
        {
            InitializeComponent();
            this.answers = answers;
            this.questions = questions;
            this.parent = parent;
            this.mainForm = mainForm;
            this.loadData();
        }

        private void loadData()
        {
            int idx = 1;
            foreach(Exam.Questions q in this.questions)
            {
                string answer;
                answers.TryGetValue(idx - 1, out answer);
                string[] row = new string[] { idx.ToString() , q.q , answer , q.ans};
                if(answer == q.ans)
                {
                    this.correctCount += 1 ;
                }
                dataGridView1.Rows.Add(row);
                idx += 1;
            }
            label1.Text = "Correct Count : " + this.correctCount.ToString();
            label2.Text = "False Count : " + (10 - this.correctCount).ToString();
            int score = this.correctCount * 10;
            label3.Text = "Score Count : " + score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            destroy();
        }

        private void destroy()
        {            
            this.Dispose();
            this.parent.Dispose();
            this.mainForm.Show();
        }

        private void ExamResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            destroy();
        }
    }
}

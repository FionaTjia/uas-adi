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
    public partial class StudentPage : Form
    {
        private String name;
        private String id;
        public StudentPage(String id,String name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            StudentHome f = new StudentHome(id, name,this);
            f.TopLevel = false;
            tabPage1.Controls.Add(f);
            f.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                StudentHome f= new StudentHome(id,name,this);
                f.TopLevel = false;
                tabPage1.Controls.Add(f);
                f.Show();
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                StudentResult f = new StudentResult(this.id);
                f.TopLevel = false;
                tabPage2.Controls.Add(f);
                f.Show();
            }
        }
    }
}

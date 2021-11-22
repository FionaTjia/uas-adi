using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_KelompokFiona.Admin
{
    public partial class AdminPage : Form
    {
        private String id, name;
        public AdminPage(String id, String name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            AdminHome adminHome = new AdminHome(name);
            adminHome.TopLevel = false;
            tabPage1.Controls.Add(adminHome);
            adminHome.Show();
        }

        private void selectedTabIndexChange(object sneder, EventArgs e)
        {
            if(adminTab.SelectedIndex == 0)
            {
                AdminHome adminHome = new AdminHome(name);
                adminHome.TopLevel = false;
                tabPage1.Controls.Add(adminHome);
                adminHome.Show();
            } else if(adminTab.SelectedIndex == 1)
            {
                AdminStudent adminStud = new AdminStudent();
                adminStud.TopLevel = false;
                tabPage2.Controls.Add(adminStud);
                adminStud.Show();
            } else if(adminTab.SelectedIndex == 2)
            {
                AdminQuestions aq = new AdminQuestions();
                aq.TopLevel = false;
                tabPage4.Controls.Add(aq);
                aq.Show();
            }
        }
    }
}
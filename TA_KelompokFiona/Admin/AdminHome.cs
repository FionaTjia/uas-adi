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
    public partial class AdminHome : Form
    {

        public AdminHome(String name)
        {
            InitializeComponent();
            adminNameLabel.Text = "Hello, " + name;
        }
    }
}

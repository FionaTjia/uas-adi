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

namespace TA_KelompokFiona
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginUserId.Text = "1";
            LoginPassword.Text = "123";
            LoginBtn.PerformClick();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String userid = LoginUserId.Text;
            String password = LoginPassword.Text;
            String query;
            SqlCommand command;
            SqlDataReader reader;
            if (!userid.Contains("AD-"))
            {
                query = "select * from students where student_password = @password and student_id = @userid and active = 1";
                command = new SqlCommand(query, DBConnection.cnn);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userid", userid);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // open studnet form
                    Console.WriteLine("Student LOGIN OK");
                    reader.Read();
                    String id = reader.GetInt32(0).ToString();
                    String name = reader.GetString(1);
                    reader.Close();
                    Form student = new Student.StudentPage(id,name);
                    
                    this.Hide();

                    student.Show();
                }              
                else
                {
                    LoginMsg.Text = "Username atau password salah dong....";
                }
                reader.Close();
            }
            else {
                query = "select * from admin where admin_id = @adminid and admin_password = @password";
                command = new SqlCommand(query, DBConnection.cnn);
                command.Parameters.AddWithValue("@password", password);
                userid = userid.Substring(3, userid.Length - 3);
                command.Parameters.AddWithValue("@adminid", userid);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    // open admin form
                    Console.WriteLine("ADMIN LOGIN OK");
                    Form admin = new Admin.AdminPage(reader.GetString(0), reader.GetString(1));
                    this.Hide();
                    
                    admin.Show();
                } else
                {
                    LoginMsg.Text = "Username atau password salah dong....";
                }
                reader.Close();

            }
        }

        private void rRegister_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO students(student_name,student_email,student_password,student_phone,topik,active) values(@name,@email,@password,@phone,@topik,0) ";
            SqlCommand cmd = new SqlCommand(query, DBConnection.cnn);
            cmd.Parameters.AddWithValue("@name", rName.Text);
            cmd.Parameters.AddWithValue("@email", rEmail.Text);
            cmd.Parameters.AddWithValue("@password", rPassword.Text);
            cmd.Parameters.AddWithValue("@phone", rPhone.Text);
            cmd.Parameters.AddWithValue("@topik", rTopik.SelectedItem.ToString());
            
            try{
                cmd.ExecuteNonQuery();
            } catch(SqlException err){
                if(err.ErrorCode == 2627){
                    MessageBox.Show("Email telah terdaftar");
                }
            }
            rName.Text = "";
            rEmail.Text = "";
            rPassword.Text = ""; 
            rPhone.Text = "";
            rTopik.SelectedItem = null;
        }
    }
}

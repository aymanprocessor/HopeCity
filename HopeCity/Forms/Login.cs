using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


namespace HopeCity
{
    public partial class Login : Form
    {
        private language language;
        private common com;

        public Login()
        {
            InitializeComponent();
          
          
        }

        private void Login_Load(object sender, EventArgs e)
        {
            com = new common();
            language = new language();

            btnSignin.ButtonText = Properties.strings.login_btn_signin;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                using (SqlCeConnection conn = new SqlCeConnection(com.getConnectionString()))
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        conn.Open();
                        var reader = cmd.ExecuteScalar().ToString();
                        if (reader == "1")
                        {
                            Main main = new Main();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(Properties.strings.login_msg_invlidUaernamePassword);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jThinButton1_Click_1(object sender, EventArgs e)
        {
            using (SqlCeConnection myConnection = new SqlCeConnection(Properties.Settings.Default.hccs))
            {
                string oString = "SELECT COUNT(*) FROM users WHERE username=@user AND password=@pass";
                SqlCeCommand oCmd = new SqlCeCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@user", txtUsername.Text);
                oCmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                myConnection.Open();
                var reader = oCmd.ExecuteScalar().ToString();
                if (reader == "1")
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

                myConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection myConnection = new SqlCeConnection(Properties.Settings.Default.hccs))
            {
                string oString = "SELECT COUNT(*) FROM users WHERE username=@user AND password=@pass";
                SqlCeCommand oCmd = new SqlCeCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@user", txtUsername.Text);
                oCmd.Parameters.AddWithValue("@pass", txtPassword);
                myConnection.Open();
                var reader = oCmd.ExecuteScalar().ToString();
                if (reader == "1")
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

                myConnection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
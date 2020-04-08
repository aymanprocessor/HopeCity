using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HopeCity
{
    public partial class Register : MaterialForm
    {
        private common com;

        public Register()
        {
            InitializeComponent();
            Theme th = new Theme(this);
            th.apply();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            com = new common();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show(Properties.strings.register_msg_passwordNotMatch, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sql = "insert into users (username,password,role) Values (@username,@password,@role);";
                using (SqlCeConnection conn = new SqlCeConnection(com.getConnectionString()))
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", "specialist");
                        conn.Open();
                        short result = (short)cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(Properties.strings.register_msg_registerSuccessfully, "خطأ", MessageBoxButtons.OK);
                            Hide();
                            Login login = new Login();
                            login.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void show()
        {
            throw new NotImplementedException();
        }
    }
}
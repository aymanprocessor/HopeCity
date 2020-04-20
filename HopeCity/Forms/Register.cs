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
using HopeCity.Forms;

namespace HopeCity
{
    public partial class Register : Form
    {
        private common com;
        private Loginn login;

        public Register()
        {
            InitializeComponent();
        }

        public Register(Loginn _Loginn)
        {
            InitializeComponent();
            login = _Loginn;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            com = new common();

            btnSignup.ButtonText = Properties.strings.register_btn_signup;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
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

        //internal void show()
        //{
        //    throw new NotImplementedException();
        //}

        public void Alert(string msg, Alert.enmType type)
        {
            Alert frm = new Alert();
            frm.showAlert(msg, type);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            login.Show();
        }

        private void txtConfirmPassword_OnValueChanged_1(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            login.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            user userModel = new user()
            {
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim()
            };

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                using (hcDataContext db = new hcDataContext())
                {
                    db.users.InsertOnSubmit(userModel);
                    db.SubmitChanges();
                    Alert("Successfully registered", Forms.Alert.enmType.Success);
                    login.Show();
                    Hide();
                }
            }
        }
    }
}
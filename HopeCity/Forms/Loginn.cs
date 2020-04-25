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
using HopeCity.Forms;
using System.Data.Entity.Validation;

namespace HopeCity
{
    public partial class Loginn : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;

                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        private language language;
        private common com;
        private user userModel = new user();

        //private void dropShadow(object sender, PaintEventArgs e)
        //{
        //    Form panel = (Form)sender;
        //    Color[] shadow = new Color[3];
        //    shadow[0] = Color.FromArgb(181, 181, 181);
        //    shadow[1] = Color.FromArgb(195, 195, 195);
        //    shadow[2] = Color.FromArgb(211, 211, 211);
        //    Pen pen = new Pen(shadow[0]);
        //    using (pen)
        //    {
        //        foreach (Form p in panel.Controls.OfType<Form>())
        //        {
        //            Point pt = p.Location;
        //            pt.Y += p.Height;
        //            for (var sp = 0; sp < 3; sp++)
        //            {
        //                pen.Color = shadow[sp];
        //                e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
        //                pt.Y++;
        //            }
        //        }
        //    }
        //}

        public Loginn()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSignin;
            com = new common();
            language = new language();

            btnSignin.ButtonText = Properties.strings.login_btn_signin;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                //using (SqlCeConnection conn = new SqlCeConnection(com.getConnectionString()))
                //{
                //    using (SqlCeCommand cmd = new SqlCeCommand(sql, conn))
                //    {
                //        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                //        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                //        conn.Open();
                //        var reader = cmd.ExecuteScalar().ToString();
                //        if (reader == "1")
                //        {
                //            Main main = new Main();
                //            main.Show();
                //            this.Hide();
                //        }
                //        else
                //        {
                //            MessageBox.Show(Properties.strings.login_msg_invlidUaernamePassword);
                //        }
                //    }

                using (hcDataContext db = new hcDataContext())
                {
                    var count = db.users.Where(x => x.username == txtUsername.Text.Trim() && x.password == txtPassword.Text.Trim()).Count();
                    if (count > 0)
                    {
                        Properties.Settings.Default.currentuser = txtUsername.Text.Trim();
                        Properties.Settings.Default.Save();
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else if (count == 0)
                    {
                        userModel = db.users.Where(x => x.username == txtUsername.Text.Trim()).FirstOrDefault();
                        if (userModel == null)
                        {
                            //MessageBox.Show("user not found");
                            com.Alert("User Not Found", Alert.enmType.Error);
                        }
                        else
                        {
                            if (userModel.password != txtPassword.Text.Trim())
                            {
                                //MessageBox.Show("wrong password");
                                com.Alert("Wrong Password", Alert.enmType.Error);
                            }
                        }
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        // get the error message
                        string errorMessage = validationError.ErrorMessage;
                        MessageBox.Show(errorMessage);
                    }
                }
            }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_OnValueChanged_1(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                txtPassword.PasswordChar = '*';
            }
           
        }
    }
}
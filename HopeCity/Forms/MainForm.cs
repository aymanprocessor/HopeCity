using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class MainForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;

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

                case 0x84:
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < cCaption)
                    {
                        m.Result = (IntPtr)2;  // HTCAPTION
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                        return;
                    }
                    break;

                default: break;
            }

            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        private common com = new common();

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        public void showForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Visible = true;
            // form.Location = new Point((mainPanel.Width - form.Width) / 2, 0);
            form.Size = new Size(mainPanel.Width, mainPanel.Height);
            mainPanel.Controls.Add(form);
        }

        public void removeForm()
        {
            mainPanel.Controls.Clear();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            {
                removeForm();
                Form form = new Students();
                showForm(form);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            removeForm();
            Form form = new StudentDetail();
            showForm(form);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            removeForm();
            Form form = new Students(this);
            showForm(form);
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkWindowsState();
            loadProfileImage();
            lblCurrentUser.Text = Properties.Settings.Default.currentuser;
            removeForm();
            Form form = new Students(this);
            showForm(form);
        }

        private void checkWindowsState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                picMaximize.Visible = false;
                picRestore.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                picMaximize.Visible = true;
                picRestore.Visible = false;
            }
        }

        private void picRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            checkWindowsState();
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            checkWindowsState();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void loadProfileImage()
        {
            using (hcDataContext db = new hcDataContext())
            {
                var result = db.users.Where(x => x.username == Properties.Settings.Default.currentuser).Select(x => x.profile_image).FirstOrDefault();
                if (result != null)
                {
                    bunifuImageButton1.Image = com.byteToImage(result.ToArray());
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginn loginn = new Loginn();
            loginn.Show();
            Hide();
        }

        private void changeProfilePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] img = File.ReadAllBytes(openFileDialog1.FileName);
                using (hcDataContext db = new hcDataContext())
                {
                    var userModel = db.users.Where(x => x.username == Properties.Settings.Default.currentuser).FirstOrDefault();
                    if (userModel != null)
                        userModel.profile_image = img;
                    db.SubmitChanges();

                    Byte[] data = new Byte[0];
                    data = (Byte[])(userModel.profile_image.ToArray());
                    MemoryStream mem = new MemoryStream(data);
                    bunifuImageButton1.Image = Image.FromStream(mem);
                }
            }
        }
    }
}
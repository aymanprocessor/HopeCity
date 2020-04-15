using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        private void showForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Visible = true;
            // form.Location = new Point((mainPanel.Width - form.Width) / 2, 0);
            form.Size = new Size(mainPanel.Width, mainPanel.Height);
            mainPanel.Controls.Add(form);
        }

        private void removeForm()
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
            Form form = new Students();
            showForm(form);
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkWindowsState();
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
    }
}
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
    public partial class StudentMain : Form
    {
        private student student;
        private MainForm mainForm;
        private StudentDetail StudentDetail;
        private Tests Tests = new Tests();

        public StudentMain()
        {
            InitializeComponent();
        }

        public StudentMain(student _student, MainForm _mainForm)
        {
            InitializeComponent();
            StudentDetail = new StudentDetail(_student);
            student = _student;
            mainForm = _mainForm;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            removeForm();
            showForm(StudentDetail);
        }

        public void showForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Visible = true;
            // form.Location = new Point((mainPanel.Width - form.Width) / 2, 0);
            form.Size = new Size(MainPanel.Width, MainPanel.Height);
            form.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(form);
        }

        public void removeForm()
        {
            MainPanel.Controls.Clear();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            removeForm();
            showForm(StudentDetail);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            removeForm();
            showForm(Tests);
        }
    }
}
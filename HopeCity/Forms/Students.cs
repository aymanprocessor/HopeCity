using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class Students : Form
    {
        private student studentModel = new student();
        private MainForm mainForm;

        public Students()
        {
            InitializeComponent();
        }

        public Students(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MiniNewStudent miniNewStudent = new MiniNewStudent();
            if (miniNewStudent.ShowDialog() == DialogResult.OK)
            {
                populate();
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Text = "";
            bunifuCircleProgress1.SubScriptText = "";
            populate();
        }

        private void populate()
        {
            dgStudent.AutoGenerateColumns = false;
            using (hcDataContext db = new hcDataContext())
            {
                dgStudent.DataSource = db.students;
                bunifuCircleProgress1.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dgStudent.CurrentRow.Index != -1)
            {
                using (hcDataContext db = new hcDataContext())
                {
                    var id = db.students.FirstOrDefault(x => x.Id.Equals(dgStudent.CurrentRow.Cells["NatID"].Value));
                    db.students.DeleteOnSubmit(id);
                    db.SubmitChanges();

                    populate();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgStudent.CurrentRow.Index > -1)
            {
                using (hcDataContext db = new hcDataContext())
                {
                    student result = db.students.FirstOrDefault(x => x.Id.Equals(dgStudent.CurrentRow.Cells["NatID"].Value));
                    mainForm.removeForm();
                    Form form = new StudentDetail(result, mainForm);
                    mainForm.showForm(form);
                }
            }
        }

        private void dgStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
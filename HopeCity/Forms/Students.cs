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
        private son sonModel = new son();

        public Students()
        {
            InitializeComponent();
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
            populate();
        }

        private void populate()
        {
            dgStudent.AutoGenerateColumns = false;
            using (HopecityEntities db = new HopecityEntities())
            {
                dgStudent.DataSource = db.sons.ToList<son>();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dgStudent.CurrentRow.Index != -1)
            {
                sonModel.Id = dgStudent.CurrentRow.Cells["NatID"].Value.ToString();
                using (HopecityEntities db = new HopecityEntities())
                {
                    if (db.Entry(sonModel).State == EntityState.Detached)
                        db.sons.Attach(sonModel);
                    db.Entry(sonModel).State = EntityState.Deleted;
                    db.SaveChanges();
                    populate();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class MiniNewStudent : Form
    {
        public MiniNewStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            son sonModel = new son();
            sonModel.name = txtName.Text.Trim();
            sonModel.gender = cbGender.Text.Trim();
            sonModel.nat = txtNational.Text.Trim();
            sonModel.dob = txtBOD.Text.Trim();
            sonModel.Id = txtNationalId.Text.Trim();
            sonModel.date = DateTime.Now.ToShortDateString();
            using (HopecityEntities db = new HopecityEntities())
            {
                try
                {
                    db.sons.Add(sonModel);
                    db.SaveChanges();
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MiniNewStudent_Load(object sender, EventArgs e)
        {
        }
    }
}
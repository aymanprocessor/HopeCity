using FluentValidation.Results;
using HopeCity.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class MiniNewStudent : Form
    {
        private common com = new common();
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

        public MiniNewStudent()
        {
            InitializeComponent();

            Label lbl = new Label();
            lbl.Location = new Point(txtNationalId.Location.X, txtNationalId.Location.Y + txtNationalId.Height + 5);
            lbl.Text = "Error Error";
            lbl.ForeColor = Color.Red;

            //this.Controls.Add(lbl);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student studentModel = new student();

            try
            {
                studentModel.Id = txtNationalId.Text.Trim();
                studentModel.name = txtName.Text.Trim();
                studentModel.gender = cbGender.selectedValue.Trim();
                studentModel.nat = txtNational.Text.Trim();
                //studentModel.dob =  DateTime.ParseExact(txtDOB.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture).Date;
                if (validDOB(txtDOB.Text.Trim()) != null)
                {
                    studentModel.dob = validDOB(txtDOB.Text.Trim()).Value.Date;
                }
               
                studentModel.date = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Validate
            StudentValidator validator = new StudentValidator();

            var result = validator.Validate(studentModel);

            if (result.IsValid == false)
            {
                //foreach (ValidationFailure failure in result.Errors)
                //{
                //    //com.Alert($"{failure.ErrorMessage}", Alert.enmType.Error);
                //    MessageBox.Show($"{failure.ErrorMessage}");
                //}

                MessageBox.Show($"{result.Errors[0].ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            //Insert
            using (hcDataContext db = new hcDataContext())
            {
                try
                {
                    db.students.InsertOnSubmit(studentModel);
                    db.SubmitChanges();
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
            btnAdd.ButtonText = Properties.strings.ministudent_btn_add;
            btnCancel.ButtonText = Properties.strings.ministudent_btn_cancel;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
        }

        private DateTime? validDOB(string strDateTime)
        {
            string[] formats = {
                "d/M/yyyy",
                "dd/MM/yyyy",
                "MM/dd/yyyy",
                "M/d/yyyy"
                           };

            DateTime dateValue;

            foreach (string dateStringFormat in formats)
            {
                if (DateTime.TryParseExact(strDateTime, dateStringFormat,
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None,
                                           out dateValue))
                {
                    //Console.WriteLine("Converted '{0}' to {1}.", dateStringFormat, dateValue.ToString("yyyy-MM-dd"));
                    return dateValue;
                }
            }
            return null;
        }
    }
}
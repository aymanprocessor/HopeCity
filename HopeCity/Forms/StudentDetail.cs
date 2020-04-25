using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HopeCity.Forms
{
    public partial class StudentDetail : Form
    {
        private student student;

        public StudentDetail()
        {
            InitializeComponent();
        }

        public StudentDetail(student _student)
        {
            InitializeComponent();
            student = _student;
        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {
            lblNatioanlId.Text = student.Id;
            tbName.Text = student.name;
            ddGender.Text = student.gender;
            tbDOB.Text = student.dob.ToShortDateString();
            lblAge.Text = CalculateAge(student.dob).ToString();
            tbNational.Text = student.nat;
            tbBroNum.Text = student.nos;
            tbRank.Text = student.orderrr;
            tbCity.Text = student.address;

            //DAD
            tbDjob.Text = student.djob;
            tbDedu.Text = student.dedu;
            tbDcity.Text = student.daddress;
            tbDtel.Text = student.dtelephone;
            tbDmob.Text = student.dmobile;

            //MOM
            tbMjob.Text = student.mjob;
            tbMedu.Text = student.medu;
            tbMcity.Text = student.maddress;
            tbMmob.Text = student.mmobile;
            tbMname.Text = student.mname;

            //OTHER
            cbDad.Checked = student.withdad == true ? true : false;
            cbMum.Checked = student.withmom == true ? true : false;
            cbOther.Checked = student.withother == true ? true : false;
            tbWhocare.Text = student.whocare;
            tbProblem.Text = student.problem;
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (hcDataContext db = new hcDataContext())
            {
                var studentModel = db.students.FirstOrDefault(x => x.Id == lblNatioanlId.Text.Trim());

                studentModel.name = tbName.Text;
                studentModel.gender = ddGender.Text;
                studentModel.dob = DateTime.ParseExact(tbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                studentModel.nat = tbNational.Text;
                studentModel.nos = tbBroNum.Text;
                studentModel.orderrr = tbRank.Text;
                studentModel.address = tbCity.Text;

                //DAD
                studentModel.djob = tbDjob.Text;
                studentModel.dedu = tbDedu.Text;
                studentModel.daddress = tbDcity.Text;
                studentModel.dtelephone = tbDtel.Text;
                studentModel.dmobile = tbDmob.Text;

                //MOM
                studentModel.mjob = tbMjob.Text;
                studentModel.medu = tbMedu.Text;
                studentModel.maddress = tbMcity.Text;
                studentModel.mmobile = tbMmob.Text;
                studentModel.mname = tbMname.Text;

                //OTHER
                studentModel.withdad = cbDad.Checked == true ? true : false;
                studentModel.withmom = cbMum.Checked == true ? true : false;
                studentModel.withother = cbOther.Checked == true ? true : false;
                studentModel.whocare = tbWhocare.Text;
                studentModel.problem = tbProblem.Text;

                db.SubmitChanges();
            }
        }
    }
}
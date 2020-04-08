using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity
{
    public partial class newtest : Form
    {
        public newtest()
        {
            InitializeComponent();
        }

        private void newtest_Load(object sender, EventArgs e)
        {
            //errorProvider1.ContainerControl = this;
            //using (SqlConnection con = new SqlConnection(Properties.Settings.Default.hccs))
            //{
            //    var select = "SELECT * FROM test";
            //    var dataAdapter = new SqlDataAdapter(select, con);
            //    var ds = new DataSet();
            //    dataAdapter.Fill(ds);
            //    dataGridView1.ReadOnly = true;
            //    dataGridView1.DataSource = ds.Tables[0];
            //}

            // label10.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 >= 0) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.hccs))
            {
                if (validate())
                {
                    var sql = "insert into dbo.son (date, name, gender, dob, age, nat, nos, orderrr, address, djob, dedu, daddress, dtelephone, dmobile, mname, mjob, medu, maddress, mmobile, withdad, withmom, withother, whocare, problem) OUTPUT INSERTED.ID " +
                        " values (@date, @name, @gender, @dob, @age, @nat, @nos, @orderrr, @address, @djob, @dedu, @daddress, @dtelephone, @dmobile, @mname, @mjob, @medu, @maddress, @mmobile, @withdad, @withmom, @withother, @whocare, @problem);";

                    using (SqlCommand command = new SqlCommand(sql, myConnection))
                    {
                        //command.Parameters.AddWithValue("@date", label10.Text);
                        command.Parameters.AddWithValue("@name", tbName.Text);
                        command.Parameters.AddWithValue("@gender", cbGender.Text);
                        command.Parameters.AddWithValue("@dob", dtpDOB.Value);
                        command.Parameters.AddWithValue("@age", tbAge.Text);
                        command.Parameters.AddWithValue("@nat", tbNational.Text);
                        command.Parameters.AddWithValue("@nos", rtbBroNum.Text);
                        command.Parameters.AddWithValue("@orderrr", tbRank.Text);
                        command.Parameters.AddWithValue("@address", tbCity.Text);
                        command.Parameters.AddWithValue("@djob", tbDjob.Text);
                        command.Parameters.AddWithValue("@dedu", tbDedu.Text);
                        command.Parameters.AddWithValue("@daddress", tbDcity.Text);
                        command.Parameters.AddWithValue("@dtelephone", tbDtel.Text);
                        command.Parameters.AddWithValue("@dmobile", tbDmob.Text);
                        command.Parameters.AddWithValue("@mname", tbMname.Text);
                        command.Parameters.AddWithValue("@mjob", tbMjob.Text);
                        command.Parameters.AddWithValue("@medu", tbMedu.Text);
                        command.Parameters.AddWithValue("@maddress", tbMcity.Text);
                        command.Parameters.AddWithValue("@mmobile", tbMmob.Text);
                        command.Parameters.AddWithValue("@withdad", cbDad.Checked);
                        command.Parameters.AddWithValue("@withmom", cbMum.Checked);
                        command.Parameters.AddWithValue("@withother", cbOther.Checked);
                        command.Parameters.AddWithValue("@whocare", tbWhocare.Text);
                        command.Parameters.AddWithValue("@problem", rtbProblem.Text);

                        myConnection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result < 0)
                            MessageBox.Show("Error inserting data into Database!");
                        else if
                            (result >= 1)
                        {
                            MessageBox.Show("Successful");

                            new questions().Show();
                        }
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sql1 = "select SCOPE_IDENTITY()";

            using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.hccs))
            {
                using (SqlCommand command = new SqlCommand(sql1, myConnection))
                {
                    myConnection.Open();
                    var result = command.ExecuteScalar();
                    MessageBox.Show(result.ToString());
                }
            }
        }

        private void validate(TextBox tb, String msg)
        {
            if (tb.Text == "")
            {
                MessageBox.Show(msg);
            }
            return;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
        }

        private bool validate()
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Please Fill Name");
                return false;
            }

            if (tbNational.Text == "")
            {
                MessageBox.Show("Please Fill Nationality");
                return false;
            }

            if (rtbBroNum.Text == "")
            {
                MessageBox.Show("Please Fill Brothers");
                return false;
            }

            if (tbRank.Text == "")
            {
                MessageBox.Show("Please Fill Rank");
                return false;
            }

            if (tbCity.Text == "")
            {
                MessageBox.Show("Please Fill City");
                return false;
            }

            if (tbAge.Text == "")
            {
                MessageBox.Show("Please Fill Age");
                return false;
            }

            if (tbDjob.Text == "")
            {
                MessageBox.Show("Please Fill Dad`s Job");
                return false;
            }

            if (tbDedu.Text == "")
            {
                MessageBox.Show("Please Fill Dad`s Education");
                return false;
            }

            if (tbDcity.Text == "")
            {
                MessageBox.Show("Please Fill Dad`s City");
                return false;
            }

            if (tbDtel.Text == "")
            {
                MessageBox.Show("Please Fill Dad`s Phone");
                return false;
            }

            if (tbDmob.Text == "")
            {
                MessageBox.Show("Please Fill Dad`s Mobile");
                return false;
            }

            if (tbMname.Text == "")
            {
                MessageBox.Show("Please Mum`s Name");
                return false;
            }

            if (tbMjob.Text == "")
            {
                MessageBox.Show("Please Fill Mum`s Job");
                return false;
            }

            if (tbMedu.Text == "")
            {
                MessageBox.Show("Please Fill Mum`s Education");
                return false;
            }

            if (tbMcity.Text == "")
            {
                MessageBox.Show("Please Fill Mum`s City");
                return false;
            }

            if (tbMmob.Text == "")
            {
                MessageBox.Show("Please Fill Mum`s Mobile");
                return false;
            }

            if (!(cbDad.Checked || cbMum.Checked || cbOther.Checked))
            {
                MessageBox.Show("Please Fill With Who Box");
                return false;
            }

            if (tbWhocare.Text == "")
            {
                MessageBox.Show("Please Fill Who Care Box");
                return false;
            }

            if (rtbProblem.Text == "")
            {
                MessageBox.Show("Please Fill Problem");
                return false;
            }

            return true;
        }
    }
}
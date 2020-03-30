using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity
{
    public partial class Ar_Eng : MaterialForm
    {
        private language language;

        public Ar_Eng()
        {
            InitializeComponent();
            Theme theme = new Theme(this);
            theme.apply();
        }

        private void Ar_Eng_Load(object sender, EventArgs e)
        {
            language = new language();
            if (language.getFirstTime() == "false")
            {
                Hide();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            language language = new language();
            language.updateConfig("language", "ar-EG");
            FirstTime(false);
            Application.Restart();
            //Login login = new Login();
            //login.Show();
            //Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            language language = new language();
            language.updateConfig("language", "en-US");
            FirstTime(false);
            Application.Restart();

            //Login login = new Login();
            //login.Show();
            //Hide();
        }

        private void FirstTime(bool yes_no)
        {
            Properties.Settings.Default.firstTime = yes_no;
            Properties.Settings.Default.Save();
        }
    }
}
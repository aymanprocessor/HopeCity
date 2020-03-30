using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity
{
    class Theme
    {
        MaterialForm form;
        public Theme(MaterialForm _form)
        {
            form = _form;

        }
        
        public void apply()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.ROBOTO_REGULAR_11 = new System.Drawing.Font("Arial", 15);
            materialSkinManager.ROBOTO_MEDIUM_10 = new System.Drawing.Font("Arial", 15,System.Drawing.FontStyle.Bold);
            //materialSkinManager.ROBOTO_MEDIUM_11 = new System.Drawing.Font("Arial", 15);
            //materialSkinManager.ROBOTO_MEDIUM_12 = new System.Drawing.Font("Arial", 15);
            //materialSkinManager.ROBOTO_REGULAR_11 = new System.Drawing.Font("Arial", 15);
        }

    }
}

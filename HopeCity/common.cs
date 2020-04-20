using HopeCity.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeCity
{
    internal class common
    {
        private string filename, password, connstr;

        public common()
        {
            filename = Environment.CurrentDirectory + "\\hopecity_db.sdf";
            password = "H0p3c!ty";
            connstr = $"Data Source={filename};Password={password}";
        }

        public string getConnectionString()
        {
            return connstr;
        }

        public Image byteToImage(Byte[] img)
        {
            Byte[] data = new Byte[0];
            data = (Byte[])(img);
            MemoryStream mem = new MemoryStream(data);
            return Image.FromStream(mem);
        }

        public void Alert(string msg, Alert.enmType type)
        {
            Alert frm = new Alert();
            frm.showAlert(msg, type);
        }
    }
}
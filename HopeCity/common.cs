using System;
using System.Collections.Generic;
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
    }
}
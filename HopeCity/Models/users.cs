using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SQLite;

namespace HopeCity.Models
{
    public class users
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string username { get; set; }
        public string password { get; set; }
    }
}
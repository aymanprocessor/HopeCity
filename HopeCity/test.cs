﻿using System;
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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("age");
            dt.Columns.Add("phone");

            dt.Rows.Add("alaa", "25", "010256483");
            dt.Rows.Add("ayman", "25", "0102563");
            dt.Rows.Add("karim", "25", "0102563");

            dataGridView1.DataSource = dt;
        }
    }
}

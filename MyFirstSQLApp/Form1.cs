using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace MyFirstSQLApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string connection = Connect.ConStr("DapperDb");
            //label1.Text = connection;

            using(IDbConnection connection=new SqlConnection(Connect.ConStr("DapperDb")))
            {
                var obj=connection.Query<Sample>("Select firstname from Sample").ToList();
                lstDemo.DataSource=obj;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

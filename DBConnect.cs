using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GoMartApplication
{
    class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=HARAPRIYA-PC\SQLEXPRESS;Initial Catalog=GoMartDB;Integrated Security=True;TrustServerCertificate=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseSCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IMS_FinalProject
{
    class Connection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Data source = MSI\SQLEXPRESS; Initial Catalog = INVSYSTEM; Integrated Security = true";
            return Conn;
        }
        public static string type;
    }
}

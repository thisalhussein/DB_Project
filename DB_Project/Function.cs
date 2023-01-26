using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project
{
    internal class Function
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable td;
        private SqlDataAdapter sda;
        private string ConStr;
        public Function()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alhussein\Documents\EmpDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
        }
    }
}

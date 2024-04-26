using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySanBong
{
    class Control_SQL
    {
        static string sv = @"DESKTOP-IK7MKG5\SQLEXPRESS2012";
        static string dtb = "QuanLySanBong";
        static string con = "Data Source=" + sv + ";Initial Catalog=" + dtb + ";Integrated Security=True ";
        public SqlConnection KetNoi()
        {
            SqlConnection connsql = new SqlConnection(con);
            return connsql;
        }
    }
}

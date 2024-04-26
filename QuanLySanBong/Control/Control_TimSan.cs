using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySanBong
{
    class Control_TimSan
    {
        Control_SQL connect = new Control_SQL();
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cB;
        public DataTable select1(string table)
        {
            ds = new DataSet();
            string selectSan = "select TenSan as N'Tên Sân' ,Gia as N'Giá' ,TrangThai as N'Trạng Thái' ,MoTa as N'Mô Tả'   from " + table;
            SqlCommand cmd = new SqlCommand(selectSan, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,table);
            dt = ds.Tables[table];
            return dt;

        }
        public DataTable select2(string table)
        {
            ds = new DataSet();
            string selectSan = "select* from " + table;
            SqlCommand cmd = new SqlCommand(selectSan, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;

        }
        public DataTable selectchange (string table,string ma,string change)
        {
            ds = new DataSet();
            string selectString = "select* from " + table + " where " + ma + "='" + change + "'";
            SqlCommand cmd = new SqlCommand(selectString, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }

        
    }
}

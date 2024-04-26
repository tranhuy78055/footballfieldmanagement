using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySanBong
{
    class Control_HoaDon
    {
        Control_SQL connect = new Control_SQL();
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cB;
        public DataTable select(string table)
        {
            ds = new DataSet();
            string selectString = "select*From " + table;
            SqlCommand cmd = new SqlCommand(selectString, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
  
        public DataTable selectedChance(string table, string ma, string change)
        {
            ds = new DataSet();
            string selectString = "select* from " + table + " where " + ma + "='" + change + "'";
            SqlCommand cmd = new SqlCommand(selectString, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
        public bool checkTrungma(string ma, string table)
        {
            DataRow drCheck = ds.Tables[table].Rows.Find(ma);
            if (drCheck != null)
            {
                return true;
            }
            return false;
        }
        public void insert(Model_HoaDon hd , string table)
        {
            DataRow dr = ds.Tables[table].NewRow();
            dr[0] = hd.IdHD;
            dr[1] = hd.IdKH;
            dr[2] = hd.IdSan;
            dr[3] = hd.Ngaydat;
            dr[4] = hd.TgNhan;
            dr[5] = hd.TgTra;
            dr[6] = hd.TongTien;
            dr[7] = hd.Ngaylap;
            ds.Tables[table].Rows.Add(dr);
            cB = new SqlCommandBuilder(da);

        }
        public void update(Model_HoaDon hd, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(hd.IdHD);
            if (dr != null)
            {
                dr[1] = hd.IdKH;
                dr[2] = hd.IdSan;
                dr[6] = hd.TongTien;
            }
            cB = new SqlCommandBuilder(da);

        }
        public void delete(Model_HoaDon hd, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(hd.IdHD);
            if (dr != null)
            {
                dr.Delete();
            }
            cB = new SqlCommandBuilder(da);

        }
        public void luu(string table)
        {
            string selectLuu = "select* from " + table;
            da = new SqlDataAdapter(selectLuu, connect.KetNoi());
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
    }
}

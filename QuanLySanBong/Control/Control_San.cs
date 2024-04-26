using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySanBong
{
    class Control_San
    {
        Control_SQL conn = new Control_SQL();
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cB;

        public DataTable select(string table)
        {
            ds = new DataSet();
            string selectString = "select * From " + table;
            SqlCommand cmd = new SqlCommand(selectString, conn.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
        public DataTable selectedChance(string table, string ma, string change)
        {
            ds = new DataSet();
            string selectString = "select * from " + table + " where " + ma + "='" + change + "'";
            SqlCommand cmd = new SqlCommand(selectString, conn.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
        public bool checkTrungID(string ma, string table)
        {
            DataRow drCheck = ds.Tables[table].Rows.Find(ma);
            if (drCheck != null)
            {
                return true;
            }
            return false;
        }
        public void insert(Model_San sv, string table)
        {
            DataRow dr = ds.Tables[table].NewRow();
            dr[0] = sv.IdSan;
            dr[1] = sv.IdChuSan;
            dr[2] = sv.IdLoaiSan;
            dr[3] = sv.TenSan;
            dr[4] = sv.Gia;
            dr[5] = sv.TrangThai;
            dr[6] = sv.Hinh;
            dr[7] = sv.MoTa;
            ds.Tables[table].Rows.Add(dr);
            cB = new SqlCommandBuilder(da);

        }
        public void update(Model_San sv, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(sv.IdSan);
            if (dr != null)
            {
                dr[1] = sv.IdChuSan;
                dr[2] = sv.IdLoaiSan;
                dr[3] = sv.TenSan;
                dr[4] = sv.Gia;
                dr[5] = sv.TrangThai;
                dr[6] = sv.Hinh;
                dr[7] = sv.MoTa;
            }
            cB = new SqlCommandBuilder(da);

        }
        public void delete(Model_San sv, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(sv.IdLoaiSan);
            if (dr != null)
            {
                dr.Delete();
            }
            cB = new SqlCommandBuilder(da);

        }
        public void luu(string table)
        {
            string selectLuu = "select * from " + table;
            da = new SqlDataAdapter(selectLuu, conn.KetNoi());
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }


        internal void insert(Model_LoaiSan newsv, string table)
        {
            throw new NotImplementedException();
        }
    }
}



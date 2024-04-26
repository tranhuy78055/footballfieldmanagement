using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySanBong
{
    public class ConTrol_KhachHang
    {
        Control_SQL connect = new Control_SQL();
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cB;
        public DataTable select(string table)
        {
            ds = new DataSet();
            string selectkh = "select* from " +table;
            SqlCommand cmd = new SqlCommand(selectkh,connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,table);
            dt = ds.Tables[table];
            return dt;

        }
        public DataTable selectchage(string table,string ma,string change)
        {
            ds = new DataSet();
            string selcectkh = "select *from " + table + "where " + ma + "='" + change+"'";
            SqlCommand cmd = new SqlCommand(selcectkh, connect.KetNoi());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }
        public bool checkTrungma(string table, string ma)
        {
            DataRow check=ds.Tables[table].Rows.Find(ma);

            if(check!=null)
            {
                return true;
            }
            return false;
        }
        public void insert(Model_KhachHang kh,string table)
        {
            DataRow dr=ds.Tables[table].NewRow();
            dr[0]=kh.IdKH;
            dr[1]=kh.HoTen;
            dr[2]=kh.GioiTinh;
            dr[4]=kh.Email;
            dr[3]=kh.SDT;
            dr[5]=kh.DiaChi;
            ds.Tables[table].Rows.Add(dr);
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public void update(Model_KhachHang kh,string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(kh.IdKH);
            if(dr!=null)
            {
                dr[1] = kh.HoTen;
                dr[2] = kh.GioiTinh;
                dr[4] = kh.Email;
                dr[3] = kh.SDT;
                dr[5] = kh.DiaChi;
            }
         
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public void delete(Model_KhachHang kh,string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(kh.IdKH);
            if(dr!=null)
            {
                dr.Delete();
            }
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
        public void save(string table)
        {
            string select = "select*from " + table;
            da = new SqlDataAdapter(select, connect.KetNoi());
            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }
    }
}

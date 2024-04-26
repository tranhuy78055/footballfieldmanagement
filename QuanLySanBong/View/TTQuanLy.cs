using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLySanBong.View
{
    public partial class TTQuanLy : Form
    {
            SqlConnection connsql;
            public TTQuanLy()
        {
            string sv = @"DESKTOP-IK7MKG5\SQLEXPRESS2012";
            string dtb = "QuanLySanBong";
            string con = "Data Source=" + sv + ";Initial Catalog=" + dtb + ";Integrated Security=True ";
            connsql = new SqlConnection(con);
            InitializeComponent();
        }
        private string _sDT, _makh, gioitinh;


        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }



        public string Makh
        {
            get { return _makh; }
            set { _makh = value; }
        }

        void Chon_GioiTinh()
        {
            if (rdo_Nam.Checked == true)
            {
                gioitinh = rdo_Nam.Text;
            }
            else
                if(rdo_nu.Checked==true)
                {
                    gioitinh = rdo_nu.Text;
                }
                else
                {
                    gioitinh = rdo_khac.Text;
                }
        }
        void load_maKH()
        {
            connsql.Open();
            string selectmaKH = "select * from ADDMIN where SDT='" +_sDT+ "'";
            SqlCommand cmd = new SqlCommand(selectmaKH, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
           while(rd.Read())
           {
               txt_mkh.Text = rd["IdAM"].ToString().Trim();
               txt_tenkh.Text = rd["HoTen"].ToString().Trim();
               if (rd["GioiTinh"].ToString().Trim() == "Nam")
                   rdo_Nam.Checked = true;
               else
                   if (rd["GioiTinh"].ToString().Trim() == "Nữ")
                       rdo_nu.Checked = true;
                   else
                       rdo_khac.Checked = true;
               txt_email.Text = rd["Email"].ToString().Trim();
               txt_diachi.Text = rd["DiaChi"].ToString().Trim();
               dateTimePicker1.Text = rd["NgaySinh"].ToString().Trim();

           }
           connsql.Close();
        }

        void updateTTKH()
        {
           
            try
            {
                connsql.Open();
                string update = "update ADDMIN set Hoten=N'" + txt_tenkh.Text + "',GioiTinh=N'" + gioitinh.Trim() + "',Email=N'" + txt_email.Text + "',DiaChi=N'" + txt_diachi.Text + "',NgaySinh='"+dateTimePicker1.Text+"' where IdAM='" + txt_mkh.Text + "'";
                SqlCommand cmd = new SqlCommand(update, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("cập nhật thất bại !");
                connsql.Close();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            Chon_GioiTinh();
            updateTTKH();
           MenuQL Child = new MenuQL();
        


        }

        private void TTKHACHHANG_Load(object sender, EventArgs e)
        {
            if (rdo_khac.Checked == false && rdo_Nam.Checked == false && rdo_nu.Checked == false)
                rdo_Nam.Checked = true;
            txt_sdt.Text = _sDT;
            load_maKH();
        }

  

      
    }
}

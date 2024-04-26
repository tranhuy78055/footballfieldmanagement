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
    public partial class TTKhachHang : Form
    {
  
        SqlConnection connsql;
        public TTKhachHang()
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
            string selectmaKH = "select * from KHACHHANG where SDT='" +_sDT+ "'";
            SqlCommand cmd = new SqlCommand(selectmaKH, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
           while(rd.Read())
           {
               txt_mkh.Text = rd["IdKH"].ToString().Trim();
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


           }
           connsql.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        void updateTTKH()
        {
           
            try
            {
                connsql.Open();
                string update = "update KHACHHANG set Hoten='" + txt_tenkh.Text + "',GioiTinh=N'" + gioitinh.Trim() + "',Email=N'" + txt_email.Text + "',DiaChi=N'" + txt_diachi.Text + "' where IdKH='" + txt_mkh.Text + "'";
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
            MenuKH Child = new MenuKH();
            Child.TenKH = txt_tenkh.Text;


        }

        private void TTKhachHang_Load(object sender, EventArgs e)
        {
            if (rdo_khac.Checked == false && rdo_Nam.Checked == false && rdo_nu.Checked == false)
                rdo_Nam.Checked = true;
            txt_sdt.Text = _sDT;
            load_maKH();
        }

      
    }
}

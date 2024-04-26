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
    public partial class DangNhap : Form
    {

        SqlConnection connsql;
        string tenkh;
        public DangNhap()
        {
            string con = @"Data Source=DESKTOP-IK7MKG5\SQLEXPRESS2012;Initial Catalog=QuanLySanBong;Integrated Security=True";
            connsql = new SqlConnection(con);
            InitializeComponent();

        }
        void loadTen()
        {
            
            connsql.Open();
            string selectmaKH = "select * from KHACHHANG where SDT='"+ txt_sdt.Text +"'";
            SqlCommand cmd = new SqlCommand(selectmaKH, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tenkh = rd["HoTen"].ToString().Trim();
            }
            connsql.Close();

        }
    
        void KTDC()
        {
            try
            {
                connsql.Open();
       
                string s = "select * from TAIKHOAN where SDT ='" +txt_sdt.Text.Trim() + "' and MatKhau ='" + txt_mk.Text.Trim()+ "'";
                SqlCommand cmd = new SqlCommand(s, connsql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {

                    if (dr["vaitro"].ToString().Trim() == "addmin".Trim())
                    {
                        this.Hide();
                        MenuQL Child = new MenuQL();
                        Child.SDT = txt_sdt.Text.Trim();
                        this.Hide();
                        Child.Show();
                    }
                    else
                    {
                       
                       MenuKH Child = new MenuKH();
                        Child.SDT = txt_sdt.Text.Trim();
                        Child.TenKH = tenkh;
                        this.Hide();
                        Child.Show();
                      
                    }
                }
                connsql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
        private void btn_dn_Click(object sender, EventArgs e)
        {
            loadTen();
            KTDC();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy DK = new DangKy();
            DK.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

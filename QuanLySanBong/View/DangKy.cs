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
    public partial class  DangKy : Form
    {
        string _makh;
        ConTrol_KhachHang kh = new ConTrol_KhachHang();
        SqlConnection connsql;
        public DangKy()
        {
            string con = @"Data Source=DESKTOP-IK7MKG5\SQLEXPRESS2012;Initial Catalog=QuanLySanBong;Integrated Security=True";
            connsql = new SqlConnection(con);
            InitializeComponent();
        }

     

          
        public bool KT_TrungSDT(string ma)
        {
            connsql.Open();
            string selectKT = "select*from TAIKHOAN where SDT='"+ma+"'";
            SqlCommand cmd = new SqlCommand(selectKT, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
                if(rd.HasRows)
                {
                    connsql.Close();
                    return false;
                }
                else
                {
                    connsql.Close();
                    return true;
                }
           
        }
        void insertTK()
        {
            try
            {
                if (KT_TrungSDT(txt_SDT.Text) == true)
                {
                    connsql.Open();

                    String insertString;
                    insertString = "insert into TAIKHOAN values('" + txt_SDT.Text + "','" + txt_MK.Text + "','user')";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    //Kiem tra ket noi truoc khi dong
                    connsql.Close();
                    //Hien thi thong bao
                    MessageBox.Show("Đăng ký thành công");
                    this.Hide();
                    DangNhap DN = new DangNhap();
                    DN.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
                
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }
        void DemKH()
        {
            string selectHD = "select *from KHACHHANG";
            SqlCommand cmd = new SqlCommand(selectHD, connsql);
            connsql.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            int i = 1;
            while (rd.Read() == true)
            {
                i++;
            }
            if (i >= 10 && i < 100)
            {
                _makh = "KH0" + i;
            }
            else
                if (i >= 100)
                {
                    _makh = "KH" + i;
                }
                else
                {
                    _makh = "KH00" + i;
                }
            connsql.Close();
        }
        void insertKH()
        {
            
            try
            {

                connsql.Open();
                string insertstrKH = "insert into KHACHHANG values('" + _makh + "',NULL,NULL,'" + txt_SDT.Text + "',NULL,NULL)";
                SqlCommand cmd = new SqlCommand(insertstrKH, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi!");
            }
        }

        private void txt_SDT_Leave(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "")
            {
                txt_SDT.Text = "Nhập số điện thoại";
                txt_SDT.ForeColor = Color.Gray;
            }
            else
                txt_SDT.ForeColor = Color.Black;

        }

        private void txt_MK_Leave(object sender, EventArgs e)
        {
            if (txt_MK.Text == "")
            {
                txt_MK.Text = "Nhập Mật Khẩu";
                txt_MK.ForeColor = Color.Gray;
            }
            else
                txt_MK.ForeColor = Color.Black;
        }

        private void txt_SDT_Enter(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "Nhập số điện thoại")
                txt_SDT.Text = "";
            txt_SDT.ForeColor = Color.Black;
        }

        private void txt_MK_Enter(object sender, EventArgs e)
        {
            if (txt_MK.Text == "Nhập Mật Khẩu")
                txt_MK.Text = "";
            txt_MK.ForeColor = Color.Black;
        }
        void batloi()
        {
            txt_SDT.MaxLength = 10;
            if(txt_SDT.Text.Length<10)
            {
                MessageBox.Show("Loi");

            }
        }
        private void btn_dk_Click_1(object sender, EventArgs e)
        {
            batloi();
            if(KT_TrungSDT(txt_SDT.Text)==false)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }
            else
          if(textBox1.Text == txt_MK.Text)
                {
            insertTK();
            insertKH();
                }
          else
          {
              MessageBox.Show("Mật khẩu không trùng khớp");
          }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap DN = new DangNhap();
            DN.Show();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            DemKH();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập chữ!");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập Lại Mật Khẩu")
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập Lại Mật Khẩu";
                textBox1.ForeColor = Color.Gray;
            }
            else
                textBox1.ForeColor = Color.Black;
        }
    }
}

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
    public partial class KHThanhToan : Form
    {

        SqlConnection connsql;
        public KHThanhToan()
        {
            string sv = @"DESKTOP-IK7MKG5\SQLEXPRESS2012";
            string dtb = "QuanLySanBong";
            string con = "Data Source=" + sv + ";Initial Catalog=" + dtb + ";Integrated Security=True ";
            connsql = new SqlConnection(con);
            InitializeComponent();
        }
        private string _san, _ngaydatsan, _tgnhan, _giantra, _masan, _mahd, _sDT,_makh;

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }
        private float _tongTien, gia,_tgda;
        public string Mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }

        public string Masan
        {
            get { return _masan; }
            set { _masan = value; }
        }

        public string San
        {
            get { return _san; }
            set { _san = value; }
        }

        public string Ngaydatsan
        {
            get { return _ngaydatsan; }
            set { _ngaydatsan = value; }
        }

        public string Tgnhan
        {
            get { return _tgnhan; }
            set { _tgnhan = value; }
        }

        public string Giantra
        {
            get { return _giantra; }
            set { _giantra = value; }
        }
        
      

  

        void load_MaHoaDon()
        {
            string selectHD = "select *from HOADON";
            SqlCommand cmd = new SqlCommand(selectHD, connsql);
            connsql.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            int i = 1;
            while(rd.Read()==true)
            {
                i++;
            }
            if(i>=10 && i<100)
            {
                _mahd = "HD0" + i;
            }
            else
                if(i>=100)
                {
                    _mahd = "HD" + i;
                }
                else
                {
                    _mahd = "HD00" + i;
                }
            connsql.Close();
          
        }
        void ThoiGianDa()
        {
            try
            {
                connsql.Open();
                string selectTGD = "DECLARE @GIO1 FLOAT, @PHUT1 FLOAT, @GIA1 FLOAT SET @GIO1=(SELECT DATEPART(HOUR,'" + _giantra + "')-DATEPART(HOUR,'" + _tgnhan + "')) SET @PHUT1= (SELECT DATEPART(MINUTE,'" + _giantra + "')-DATEPART(minute,'" + _tgnhan + "')) SELECT (@GIO1+(@PHUT1/60)) as'TGDa'";
                SqlCommand cmd = new SqlCommand(selectTGD, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    _tgda = float.Parse(rd["TGDa"].ToString());
                }
                connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!");
            }
        }
        void loadMaKH()
        {
            try
            {
                connsql.Open();
                string selectTT = "select*from KHACHHANG WHERE SDT='"+_sDT+"'";
                SqlCommand cmd = new SqlCommand(selectTT, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    _makh = rd["IdKH"].ToString().Trim();
                }
                connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!");
            }
        }
        void TongTienHD()
        {
             try
            {
                connsql.Open();
                string selectTT = "DECLARE @GIO1 FLOAT, @PHUT1 FLOAT, @GIA1 FLOAT SET @GIO1=(SELECT DATEPART(HOUR,'" + _giantra + "')-DATEPART(HOUR,'" + _tgnhan + "')) SET @PHUT1= (SELECT DATEPART(MINUTE,'" + _giantra + "')-DATEPART(minute,'" + _tgnhan + "')) SELECT (@GIO1+(@PHUT1/60))*"+gia+" as'TongTien'";
                SqlCommand cmd = new SqlCommand(selectTT, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                 while(rd.Read()==true)
                 {
                   _tongTien=float.Parse(rd["TongTien"].ToString());
                 }
                connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!");
            }

        }
        void Gia()
        {
            try
            {
                connsql.Open();
                string selectTT = "select Gia From SAN where IdSan='"+_masan+"'";
                SqlCommand cmd = new SqlCommand(selectTT, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    gia = float.Parse(rd["Gia"].ToString());
                }
                connsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!");
            }
        }

        void Insert_HD()
        {
            try
            {
                connsql.Open();
                string insertHD = "insert into HOADON values('"+_mahd+"','"+_makh+"','" + _masan + "','" + _ngaydatsan + "','" + Tgnhan + "','" + _giantra + "'," + _tongTien + ",'"+DateTime.Today.ToString()+"')";
                SqlCommand cmd = new SqlCommand(insertHD, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();
                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!");
            }

        }


        private void KHThanhToan_Load(object sender, EventArgs e)
        {
            loadMaKH();
            load_MaHoaDon();
            ThoiGianDa();
            Gia();
            TongTienHD();     
            txt_sogioda.Text = _tgda.ToString();
            txt_gia.Text = gia.ToString();
            txt_san.Text = _san;
            txt_ngaydat.Text = _ngaydatsan;
            txt_tgnhansan.Text = _tgnhan;
            txt_tgtrasan.Text = _giantra;
            txt_Tongtien.Text = _tongTien.ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Insert_HD();
            this.Close();
        }

   
    }
}

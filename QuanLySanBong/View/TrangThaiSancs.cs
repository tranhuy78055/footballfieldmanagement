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
    public partial class TrangThaiSancs : Form
    {
      
        SqlConnection connsql;
        public int demhoadon = 1;
        private string _sDT;

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }
        public TrangThaiSancs()
        {
              string sv = @"DESKTOP-IK7MKG5\SQLEXPRESS2012";
            string dtb = "QuanLySanBong";
           string con = "Data Source=" + sv + ";Initial Catalog=" + dtb + ";Integrated Security=True ";
           connsql = new SqlConnection(con);
            InitializeComponent();
        }
        void load_colorbtn()
        {
            btn_san51.BackColor = Color.Green;
            btn_san51.Enabled = true;
            btn_san52.BackColor = Color.Green;
            btn_san53.BackColor = Color.Green;
            btn_san54.BackColor = Color.Green;
            btn_san55.BackColor = Color.Green;
            btn_san71.BackColor = Color.Green;
            btn_san72.BackColor = Color.Green;
            btn_san73.BackColor = Color.Green;
            btn_san74.BackColor = Color.Green;
            btn_san75.BackColor = Color.Green;
            btn_san51.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san52.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san53.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san54.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san55.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san71.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san72.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san73.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san74.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
            btn_san75.BackgroundImage = QuanLySanBong.Properties.Resources.san_icon;
   
            btn_san52.Enabled = true;
            btn_san53.Enabled = true;
            btn_san54.Enabled = true;
            btn_san55.Enabled = true;
            btn_san71.Enabled = true;
            btn_san72.Enabled = true;
            btn_san73.Enabled = true;
            btn_san74.Enabled = true;
            btn_san75.Enabled = true;
        }
        void load_AllButton()
        {


            try
            {
                string selectbt = "select IdSan from HOADON where NgayDatSan='" + dtp_ngay.Text + "' and ('" + maskedTextBox1.Text + "' between TGNhanSan and TGTraSan  or '" + maskedTextBox2.Text + "' between TGNhanSan and TGTraSan)";
                SqlCommand cmd = new SqlCommand(selectbt, connsql);
                int i = 1;
                connsql.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                string btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10;

                while (rd.Read() == true)
                {
                    if (rd["IdSan"].ToString().Trim() == "S001")
                    {
                        btn1 = rd["IdSan"].ToString().Trim();
                        btn_san51.BackColor = Color.Red;
                        btn_san51.BackgroundImage = base.BackgroundImage;

                        btn_san51.Enabled = false;
                    }
                    if (rd["IdSan"].ToString().Trim() == "S002")
                    {
                        btn2 = rd["IdSan"].ToString().Trim();
                        btn_san52.BackColor = Color.Red;
                        btn_san52.Enabled = false;
                        btn_san52.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S003")
                    {
                        btn3 = rd["IdSan"].ToString().Trim();
                        btn_san53.BackColor = Color.Red;
                        btn_san53.Enabled = false;
                        btn_san53.BackgroundImage = base.BackgroundImage;
      
                    }
                    if (rd["IdSan"].ToString().Trim() == "S004")
                    {
                        btn4 = rd["IdSan"].ToString().Trim();
                        btn_san54.BackColor = Color.Red;
                        btn_san54.Enabled = false;
                        btn_san54.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S005")
                    {
                        btn5 = rd["IdSan"].ToString().Trim();
                        btn_san55.BackColor = Color.Red;
                        btn_san55.Enabled = false;
                        btn_san55.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S006")
                    {
                        btn6 = rd["IdSan"].ToString().Trim();
                        btn_san71.BackColor = Color.Red;
                        btn_san71.Enabled = false;
                        btn_san71.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S007")
                    {
                        btn7 = rd["IdSan"].ToString().Trim();
                        btn_san72.BackColor = Color.Red;
                        btn_san72.Enabled = false;
                        btn_san72.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S008")
                    {
                        btn8 = rd["IdSan"].ToString().Trim();
                        btn_san73.BackColor = Color.Red;
                        btn_san73.Enabled = false;
                        btn_san73.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S009")
                    {
                        btn9 = rd["IdSan"].ToString().Trim();
                        btn_san74.BackColor = Color.Red;
                        btn_san74.Enabled = false;
                        btn_san74.BackgroundImage = base.BackgroundImage;

                    }
                    if (rd["IdSan"].ToString().Trim() == "S010")
                    {
                        btn10 = rd["IdSan"].ToString().Trim();
                        btn_san75.BackColor = Color.Red;
                        btn_san75.Enabled = false;
                        btn_san75.BackgroundImage = base.BackgroundImage;

                    }
                    i++;
                }
                connsql.Close();
            }
           catch(Exception ex)
            {
                MessageBox.Show("Yêu cầu nhập đúng ngày giờ!");
                connsql.Close();
            }
     

        }
        public int DHD()
        {
            return demhoadon;
        }
        private void dtp_tg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrangThaiSancs_Load(object sender, EventArgs e)
        {
            load_colorbtn();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            load_colorbtn();
            load_AllButton();

        }

        private void btn_san51_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san51.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S001";
            Child.Show();

        }

        private void btn_san52_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san52.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S002";
            Child.Show();
        }

        private void btn_san53_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san53.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S003";
            Child.Show();
        }

        private void btn_san54_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san54.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S004";
            Child.Show();
        }

        private void btn_san55_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san55.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S005";
            Child.Show();
        }

        private void btn_san72_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san72.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S007";
            Child.Show();
        }

        private void btn_san71_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san71.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S006";
            Child.Show();
        }

        private void btn_san73_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san73.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S008";
            Child.Show();
        }

        private void btn_san74_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san74.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S009";
            Child.Show();
        }

        private void btn_san75_Click(object sender, EventArgs e)
        {
            KHThanhToan Child = new KHThanhToan();
            Child.SDT = _sDT;
            Child.San = btn_san75.Text;
            Child.Ngaydatsan = dtp_ngay.Text;
            Child.Tgnhan = maskedTextBox1.Text;
            Child.Giantra = maskedTextBox2.Text;
            Child.Masan = "S010";
            Child.Show();
        }

    }
}

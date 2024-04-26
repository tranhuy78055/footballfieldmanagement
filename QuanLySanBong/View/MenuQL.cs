using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBong.View
{
    public partial class MenuQL : Form
    {
        public MenuQL()
        {
            InitializeComponent();
        }
        private string _sDT, _tenQL;

        public string TenQL
        {
            get { return _tenQL; }
            set { _tenQL = value; }
        }

       

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }
        private Form currentFormChild;
        private void OpenchildForm( Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenchildForm(new KhachHang());
            label_Tc.Text = quảnLýKháchHàngToolStripMenuItem.Text;
        }

        private void quảnLýSânBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenchildForm(new SanBong());
            label_Tc.Text = quảnLýSânBóngToolStripMenuItem.Text;
        }

        private void quảnLýLoạiSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenchildForm(new LoaiSan());
            label_Tc.Text = quảnLýLoạiSânToolStripMenuItem.Text;
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenchildForm(new HoaDon());
            label_Tc.Text = quảnLýHóaĐơnToolStripMenuItem.Text;
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuQL_Load(object sender, EventArgs e)
        {
            TTKhachHang Child = new TTKhachHang();
            Child.SDT = _sDT;
        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_imgQL_Click(object sender, EventArgs e)
        {
            TTQuanLy Child = new TTQuanLy();
            Child.SDT = _sDT;
            currentFormChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(Child);
            panel_Body.Tag = Child;
            Child.BringToFront();
            label_Tc.Text = "Thông Tin Quản Lý";
            Child.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            label_Tc.Text = "Trang Chủ";
        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenchildForm(new TK_HoaDon());

        }
    }
}

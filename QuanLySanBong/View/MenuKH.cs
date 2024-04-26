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
    public partial class MenuKH : Form
    {
        public MenuKH()
        {
            InitializeComponent();
        }
        private string _sDT, _tenKH;

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        private Form currentFormChild;
        private void OpenchildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            label_TC.Text = "Trang Chủ";
            lb_tenql.Text = "Xin chào " + _tenKH;
            if (lb_tenql.Text == "Xin chào ")
            {
                lb_tenql.Text = "Vui lòng điền đầy đủ thông tin cá nhân !";
                lb_tenql.ForeColor = Color.Red;
            }
           
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_datsan_Click(object sender, EventArgs e)
        {
            TrangThaiSancs Child = new TrangThaiSancs();
            Child.SDT = _sDT;
            currentFormChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(Child);
            panel_body.Tag = Child;
            Child.BringToFront();
            label_TC.Text = btn_datsan.Text;
            Child.Show();
         
        }

        private void btn_imgQL_Click(object sender, EventArgs e)
        {
            TTKhachHang Child = new TTKhachHang();
            Child.SDT = _sDT;
            currentFormChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(Child);
            panel_body.Tag = Child;
            Child.BringToFront();
            label_TC.Text = "Thông Tin khách hàng";
            Child.Show();

        }

        private void MenuKH_Load(object sender, EventArgs e)
        {
            lb_tenql.Text = "Xin chào " + _tenKH;
        
        
        }
    }
}

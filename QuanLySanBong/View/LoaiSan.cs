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
    public partial class LoaiSan : Form
    {
        Control_SQL connect = new Control_SQL();
        DataColumn[] key = new DataColumn[1];
        Control_LoaiSan ls = new Control_LoaiSan();
        string table = "LOAISAN";
        public LoaiSan()
        {
            InitializeComponent();
        }
        void addHeader()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("IdLoaiSan", "Id Loại Sân");
            dataGridView1.Columns[0].DataPropertyName = "IdLoaiSan";
            dataGridView1.Columns.Add("TenLoaiSan", "Tên Loại Sân");
            dataGridView1.Columns[1].DataPropertyName = "TenLoaiSan";
            dataGridView1.Columns.Add("SoLuongSan", "Số lượng sân");
            dataGridView1.Columns[2].DataPropertyName = "SoLuongSan";
            dataGridView1.Columns.Add("ThongTin", "Thông Tin");
            dataGridView1.Columns[3].DataPropertyName = "ThongTin";
            dataGridView1.Columns.Add("Ghichu", "Ghi chú");
            dataGridView1.Columns[4].DataPropertyName = "Ghichu";
        }
        void loadidloaisan()
        {
            DataTable dtls = ls.select(table);
            dataGridView1.DataSource = dtls;
            key[0] = dtls.Columns[0];
            dtls.PrimaryKey = key;
        }
        void loadSantheoLoaiSan()
        {
            addHeader();
            loadidloaisan();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Model_LoaiSan newls = new Model_LoaiSan();
                newls.IdLoaiSan = txtid.Text;   
                newls.TenLoaiSan = txt_tensan.Text;
                newls.SoLuongSan = txt_sls.Text;
                newls.ThongTin = txtthongtin.Text;
                newls.GhiChu = txtghichu.Text;
                if (ls.checkTrungID(newls.IdLoaiSan, table) == true)
                {
                    MessageBox.Show("Trùng id rồi ");
                    return;
                }
                ls.insert(newls, table);
                lưuToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Model_LoaiSan deletels = new Model_LoaiSan();
                deletels.IdLoaiSan = txtid.Text;
                deletels.TenLoaiSan = txt_tensan.Text;
                deletels.ThongTin = txtthongtin.Text;
                deletels.GhiChu = txtghichu.Text;
                if (ls.checkTrungID(deletels.IdLoaiSan, table) == false)
                {
                    MessageBox.Show("Id cần xóa không Khớp");
                    return;
                }

                ls.delete(deletels, table);
                lưuToolStripMenuItem.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Model_LoaiSan updatels = new Model_LoaiSan();
                updatels.IdLoaiSan = txtid.Text;
                updatels.TenLoaiSan = txt_tensan.Text;
                updatels.SoLuongSan = txt_sls.Text;
                updatels.ThongTin = txtthongtin.Text;
                updatels.GhiChu = txtghichu.Text;
                if (ls.checkTrungID(updatels.IdLoaiSan, table) == false)
                {
                    MessageBox.Show("Id cần sửa không Khớp");
                    return;
                }

                ls.update(updatels, table);
                lưuToolStripMenuItem.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ls.luu(table);
                MessageBox.Show("Lưu Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tensan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_sls.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtthongtin.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtghichu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
    
                sửaToolStripMenuItem.Enabled = true;
                lưuToolStripMenuItem.Enabled = true;
                xóaToolStripMenuItem.Enabled = true;
            }
        }
        
        private void LoaiSan_Load(object sender, EventArgs e)
        {
            loadidloaisan();
            loadSantheoLoaiSan();
          
        }

  

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}

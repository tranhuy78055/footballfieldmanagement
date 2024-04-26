using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBong
{
    public class Model_LoaiSan
    {
        string _idLoaiSan, _idTenLoaiSan, _thongTin, _ghiChu, _soLuongSan;

        public string SoLuongSan
        {
            get { return _soLuongSan; }
            set { _soLuongSan = value; }
        }

        public string IdLoaiSan
        {
            get { return _idLoaiSan; }
            set { _idLoaiSan = value; }
        }

        public string TenLoaiSan
        {
            get { return _idTenLoaiSan; }
            set { _idTenLoaiSan = value; }
        }

        public string ThongTin
        {
            get { return _thongTin; }
            set { _thongTin = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public Model_LoaiSan()
        {

        }
        public Model_LoaiSan(string idloaisan, string idtenloaisan, string thongtin, string ghichu,string soluong)
        {
            this.IdLoaiSan = idloaisan;
            this.TenLoaiSan = idtenloaisan;
            this.ThongTin = thongtin;
            this.GhiChu = ghichu;
            this.SoLuongSan = soluong;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBong
{
    class Model_San
    {
        string _idSan, _idChuSan, _idLoaiSan, _tenSan, _gia, _trangThai, _hinh, _moTa;

        public string IdSan
        {
            get { return _idSan; }
            set { _idSan = value; }
        }

        public string IdChuSan
        {
            get { return _idChuSan; }
            set { _idChuSan = value; }
        }

        public string IdLoaiSan
        {
            get { return _idLoaiSan; }
            set { _idLoaiSan = value; }
        }

        public string TenSan
        {
            get { return _tenSan; }
            set { _tenSan = value; }
        }

        public string Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public string Hinh
        {
            get { return _hinh; }
            set { _hinh = value; }
        }

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        public Model_San()
        {

        }
        public Model_San(string idsan, string idchusan, string idloaisan, string tensan, string gia, string trangthai, string hinh, string mota)
        {
            this.IdSan = idsan;
            this.IdChuSan = idchusan;
            this.IdLoaiSan = idloaisan;
            this.TenSan = tensan;
            this.Gia = gia;
            this.TrangThai = trangthai;
            this.Hinh = hinh;
            this.MoTa = mota;
        }
    }
}

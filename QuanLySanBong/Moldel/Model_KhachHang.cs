using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBong
{
    public class Model_KhachHang
    {
        string _idKH, _hoTen, _gioiTinh, _sDT, _email, _diaChi;

        public string IdKH
        {
            get { return _idKH; }
            set { _idKH = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public Model_KhachHang()
        {

        }
        public Model_KhachHang( string idkh,string hoten,string gioitinh,string sdt,string email,string diachi)
        {
            this.IdKH = idkh;
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.SDT = sdt;
            this.Email = email;
            this.DiaChi = diachi;
        }
    }
}

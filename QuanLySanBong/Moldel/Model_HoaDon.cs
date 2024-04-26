using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBong
{
    class Model_HoaDon
    {
        string _idHD, _idKH, _idSan, _ngaydat, _tgNhan, _tgTra, _tongTien, _ngaylap;

        public string Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }

        public string IdHD
        {
            get { return _idHD; }
            set { _idHD = value; }
        }

        public string IdKH
        {
            get { return _idKH; }
            set { _idKH = value; }
        }

        public string IdSan
        {
            get { return _idSan; }
            set { _idSan = value; }
        }

        public string Ngaydat
        {
            get { return _ngaydat; }
            set { _ngaydat = value; }
        }

        public string TgNhan
        {
            get { return _tgNhan; }
            set { _tgNhan = value; }
        }

        public string TgTra
        {
            get { return _tgTra; }
            set { _tgTra = value; }
        }

        public string TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        public Model_HoaDon()
        {

        }
        public Model_HoaDon(string idhd,string idkh,string idsan,string ngaydat,string tgnhan,string tgtra,string tongtien)
        {
            this.IdHD = idhd;
            this.IdKH = idkh;
            this.IdSan=idsan;
            this.Ngaydat = ngaydat;
            this.TgNhan = tgnhan;
            this.TgTra = tgtra;
            this.TongTien = tongtien;
        }
    }
}

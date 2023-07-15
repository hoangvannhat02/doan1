using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.KhaiBao
{
    class khachhang
    {
        private string tenkh;
        private string makh;
        private int tuoikh;
        private string gioitinhkh;
        private string quequankh;
        private string sodtkh;
        public khachhang() { }
        public khachhang(khachhang kh)
        {
            this.makh = kh.makh;
            this.tenkh = kh.tenkh;
            this.gioitinhkh = kh.gioitinhkh;
            this.sodtkh = kh.sodtkh;
            this.tuoikh = kh.tuoikh;
            this.quequankh = kh.quequankh;
        }
        public khachhang(string makh, string tenkh, int tuoikh, string gioitinhkh, string quequankh, string sodtkh)
        {
            this.tenkh = tenkh;
            this.makh = makh;
            this.tuoikh = tuoikh;
            this.gioitinhkh = gioitinhkh;
            this.quequankh = quequankh;
            this.sodtkh = sodtkh;
        }
        public string MaKH
        {
            get { return makh; }
            set
            {
                if (value != "")
                    makh = value;
            }
        }
        public string NameKH
        {
            get { return tenkh; }
            set
            {
                if (value != "")
                    tenkh = value;
            }
        }
        public int TuoiKH
        {
            get { return tuoikh; }
            set
            {
                tuoikh = value;
            }
        }
        public string Qq
        {
            get { return quequankh; }
            set
            {
                if (value != "")
                    quequankh = value;
            }
        }
        public string Sdt
        {
            get { return sodtkh; }
            set
            {
                sodtkh = value;
            }
        }
        public string GT
        {
            get { return gioitinhkh; }
            set
            {
                gioitinhkh = value;
            }
        }
    }
}

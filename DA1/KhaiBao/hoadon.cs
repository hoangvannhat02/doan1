using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.KhaiBao
{
    class hoadon
    {
        private string mahd, makh, mahh, tenhh, tenkh,quekh,manv,tennv;
        private DateTime ngayban;
        private double soluong,gia,tongtien;
        public string GMahd
        {
            get { return mahd; }
            set {if(value!="")
                mahd = value; }
        }
        public string GMakh
        {
            get { return makh; }
            set { makh = value; }
        }
        public string GMahh
        {
            get { return mahh; }
            set { mahh = value; }
        }
        public string GManv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string GTennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string GTenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        public string GQuekh
        {
            get { return quekh; }
            set { quekh = value; }
        }
        public string GTenhh
        {
            get { return tenhh; }
            set { tenhh = value; }
        }
        public double Ggia
        {
            get { return gia; }
            set { gia = value; }
        }
        public DateTime GNgayban
        {
            get { return ngayban; }
            set { ngayban = value; }
        }
        public double Gsl
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public double Gtongtien
        {
            get { return tongtien=Ggia * Gsl; }
            set { tongtien = value; }
        }
        public hoadon() { }
        public hoadon(string mahd,string makh,string tenkh,string quekh,string manv,string tennv,DateTime ngayban,string mahh,string tenhh,double soluong,double gia,double tongtien)
        {
            this.mahd = mahd;
            this.makh = makh;
            this.tenkh = tenkh;
            this.quekh = quekh;
            this.manv = manv;
            this.tennv = tennv;
            this.ngayban = ngayban;
            this.mahh = mahh;
            this.tenhh = tenhh;
            this.soluong = soluong;
            this.gia = gia;
            this.tongtien = tongtien;
        }
        public hoadon(hoadon hd)
        {
            this.mahd = hd.mahd;
            this.makh = hd.makh;
            this.mahh = hd.mahh;
            this.tenkh = hd.tenkh;
            this.GQuekh = hd.GQuekh;
            this.GManv = hd.GManv;
            this.GTennv = hd.GTennv;
            this.ngayban = hd.ngayban;
            this.mahh = hd.mahh;
            this.tenhh = hd.tenhh;
            this.soluong = hd.soluong;
            this.Gtongtien = hd.Gtongtien;
        }
    }
}

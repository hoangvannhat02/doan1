using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.KhaiBao
{
    //Khai báo các thông tin của hàng hóa
    class hanghoa
    {
        private string ten;
        private string ma;
        private double soluong;
        private double giathanh;
        private DateTime ngaynhap;
        private string xuatxu;
        public string Ten
        {
            get { return ten; }
            set
            {
                if (value != "")
                    ten = value;
            }
        }
        public string Ma
        {
            get { return ma; }
            set
            {
                if (value != "")
                    ma = value;
            }
        }
        public DateTime Ngay
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        public string Xuatxu
        {
            get { return xuatxu; }
            set
            {
                xuatxu = value;
            }
        }
        public double SL
        {
            get { return soluong; }
            set
            {
                soluong = value;
            }
        }
        public double Gia
        {
            get { return giathanh; }
            set
            {
                giathanh = value;
            }
        }
        public hanghoa() { }
        public hanghoa(hanghoa hh)
        {
            this.ma = hh.ma;
            this.ten = hh.ten;
            this.soluong = hh.soluong;
            this.giathanh = hh.giathanh;
            this.xuatxu = hh.xuatxu;
            this.ngaynhap = hh.ngaynhap;
        }
        public hanghoa(string ma, string ten, string xuatxu, DateTime ngaynhap, double soluong, double giathanh)
        {
            this.soluong = soluong;
            this.giathanh = giathanh;
            this.ten = ten;
            this.ma = ma;
            this.ngaynhap = ngaynhap;
            this.xuatxu = xuatxu;
        }
    }
}

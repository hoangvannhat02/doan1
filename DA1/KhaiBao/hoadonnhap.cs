using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.KhaiBao
{
    class hoadonnhap
    {
        private string mahdn, manv, tennv, mahh, tenhh, xuatxu;
        private double sl, gia;
        private DateTime ngaynhap;
        public string MaHD
        {
            get { return mahdn; }
            set
            {
                 mahdn = value;
            }
        }
        public string MaNV
        {
            get { return manv; }
            set
            {
                 manv = value;
            }
        }
        public string TenNV
        {
            get { return tennv; }
            set
            {
                 tennv = value;
            }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public string MaHH
        {
            get { return mahh; }
            set
            {
                mahh = value;
            }
        }
        public string TenHH
        {
            get { return tenhh; }
            set
            {
                 tenhh = value;
            }
        }
        public string XuatXu
        {
            get { return xuatxu; }
            set
            {
                 xuatxu = value;
            }
        }
        public double SL
        {
            get { return sl; }
            set { sl = value; }
        }
        public DateTime Ngay
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        public hoadonnhap()
        {

        }
        public hoadonnhap(string mahdn, string manv, string tennv, DateTime ngaynhap, string mahh, string tenhh, string xuatxu, double sl, double gia)
        {
            this.mahdn = mahdn;
            this.manv = manv;
            this.tennv = tennv;
            this.ngaynhap = ngaynhap;
            this.mahh = mahh;
            this.tenhh = tenhh;
            this.xuatxu = xuatxu;
            this.sl = sl;
            this.gia = gia;
        }
        public hoadonnhap(hoadonnhap hdn)
        {
            this.mahdn = hdn.mahdn;
            this.manv = hdn.manv;
            this.TenNV = hdn.TenNV;
            this.mahh = hdn.mahh;
            this.tenhh = hdn.tenhh;
            this.ngaynhap = hdn.ngaynhap;
            this.xuatxu = hdn.xuatxu;
            this.sl = hdn.sl;
            this.gia = hdn.gia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.Business.Interface;
using DA1.DAL;

namespace DA1.Business
{
    class HoaDonBLL : IHoaDonBLL
    {
        private HoaDonDAL dshd = new HoaDonDAL();
        public List<hoadon> GetDataHD()
        {
            return dshd.GetDataHD();
        }
        public bool Checkmahd(string ma)
        {
            bool check = false;
            List<hoadon> listhd = GetDataHD();
            for (int i = 0; i < listhd.Count; i++)
            {
                if (listhd[i].GMahd == ma)
                {
                    check = true;
                }
            }
            return check;
        }
        public bool Checksl(double x)
        {
            bool kt = false;
            hanghoaBLL hh = new hanghoaBLL();
            List<hanghoa> dshh = hh.GetDataHH();
            for (int i = 0; i < dshh.Count; i++)
            {
                if (dshh[i].SL - x < 0)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public void Them(hoadon hd)
        {
            dshd.Them(hd);
        }
        public void Xoa(string ma)
        {
            dshd.Xoa(ma);
        }
        public void Updatesl(hoadon hd)
        {
            hanghoaBLL dshh = new hanghoaBLL();
            hanghoaDAL dshhdal = new hanghoaDAL();
            List<hanghoa> list = dshh.GetDataHH();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ma == hd.GMahh)
                {
                    double sl = list[i].SL;
                    sl -= hd.Gsl;
                    list[i].SL = sl;
                }
            }
            dshhdal.Them2(list);
        }
        public double GGia(string x)
        {
            double kq = 0;
            hanghoaBLL dshh = new hanghoaBLL();
            List<hanghoa> list = dshh.GetDataHH();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ma.Equals(x))
                {
                    kq += list[i].Gia*1.2;
                }
            }
            return kq;
        }
        public List<hoadon> Tim(string ma)
        {
            List<hoadon> listhd = GetDataHD();
            List<hoadon> kq = new List<hoadon>();
            for (int i = 0; i < listhd.Count; i++)
            {
                if (listhd[i].GMahd.Contains(ma)||listhd[i].GMahh.Contains(ma)||listhd[i].GMakh.Contains(ma)||listhd[i].GManv.Contains(ma)||listhd[i].GTenhh.ToLower() == ma.ToLower() || listhd[i].GTenkh.ToLower() == ma.ToLower() || listhd[i].GTennv.ToLower() == ma.ToLower()||listhd[i].GNgayban.ToString("dd/MM/yyyy")==ma)
                {
                    kq.Add(listhd[i]);
                }
            }
            return kq;
        }
        public bool Checkngay(DateTime t)
        {
            bool kt = false;
            List<hoadon> hd = GetDataHD();
            for (int i = 0; i < hd.Count; i++)
            {
                if (hd[i].GNgayban == t)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool Checkthang(int month,int year)
        {
            bool kt = false;
            List<hoadon> hd = GetDataHD();
            for (int i = 0; i < hd.Count; i++)
            {
                if (hd[i].GNgayban.Month==month&&hd[i].GNgayban.Year==year)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public double Doanhthungay(DateTime t)
        {
            double tong = 0;
            List<hoadon> hd = GetDataHD();
            for (int i = 0; i < hd.Count; i++)
            {
                if (hd[i].GNgayban == t)
                {
                    tong += hd[i].Gtongtien - hd[i].Gtongtien / hd[i].Gsl/1.2;
                }
            }
            return tong;
        }
        public double Doanhthuthang(int month,int year)
        {
            double tong = 0;
            List<hoadon> hd = GetDataHD();
            for (int i = 0; i < hd.Count; i++)
            {
                if (hd[i].GNgayban.Month == month&&hd[i].GNgayban.Year== year)
                {
                    tong += hd[i].Gtongtien - hd[i].Gtongtien / hd[i].Gsl/1.2;
                }
                else
                {
                    return tong;
                }
            }
            return tong;
        }
    }
}

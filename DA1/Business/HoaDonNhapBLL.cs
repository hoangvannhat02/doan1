using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.Business.Interface;
using DA1.KhaiBao;
using DA1.DAL;

namespace DA1.Business
{
    class HoaDonNhapBLL:IHoaDonNhap
    {
        private HoaDonNhapDAL hd = new HoaDonNhapDAL(); 
        public List<hoadonnhap> GetDataHDN()
        {
            return hd.GetDataHDN();
        }
        public void Them(hoadonnhap hdn)
        {
            hd.Them(hdn);
        }
        public void Xoa(string ma)
        {
            hd.Xoa(ma);
        }
        public bool CheckMahd(string ma)
        {
            bool check = false;
            List<hoadonnhap> list = GetDataHDN();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaHD.Equals(ma))
                {   
                    check = true;
                    break;
                }
            }
            return check;
        }
        public List<hoadonnhap> Tim(string ma)
        {
            List<hoadonnhap> list = hd.GetDataHDN();
            List<hoadonnhap> kq = new List<hoadonnhap>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaHD.Equals(ma)||list[i].MaHH.Equals(ma)||list[i].MaNV.Equals(ma)||list[i].TenHH.ToLower()==ma.ToLower()||list[i].TenNV.ToLower()==ma.ToLower()||list[i].XuatXu.ToLower()==ma.ToLower()||list[i].Ngay.ToString("dd/MM/yyyy")==ma)
                {
                    kq.Add(list[i]);
                }
            }
            return kq;
        }
        public string Gtennv(hoadonnhap hdn)
        {
            string kq = "";
            nhanvienBLL dsnv = new nhanvienBLL();
            List<nhanvien> listnv = dsnv.GetDataNV();
            for (int i = 0; i < listnv.Count; i++)
            {
                if (listnv[i].Ma == hdn.MaNV)
                {
                    kq = listnv[i].Ten;
                }
            }
            return kq;
        }
        public void Updatesl(hoadonnhap hdn)
        {
            hanghoaBLL dshh = new hanghoaBLL();
            hanghoaDAL dshhdal = new hanghoaDAL();
            List<hanghoa> list = dshh.GetDataHH();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ma.Equals(hdn.MaHH))
                {
                    double sl = list[i].SL;
                    sl += hdn.SL;
                    list[i].SL = sl;
                }
            }
            dshhdal.Them2(list);
        }
    }
}

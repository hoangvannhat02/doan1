using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.Business.Interface;
using DA1.DAL.Interface;
using DA1.DAL;

namespace DA1.Business
{
    class nhanvienBLL : INhanVien
    {
        private INhanVienDAL nhanvien = new nhanvienDAL();
        public List<nhanvien> GetDataNV()
        {
            return nhanvien.GetDataNV();
        }
        public bool CheckMaNv(string manv)
        {
            List<nhanvien> listnv = nhanvien.GetDataNV();
            bool check = false;
            for (int i = 0; i < listnv.Count; i++)
            {
                if (listnv[i].Ma.Equals(manv))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void Xoa(string manv)
        {
            if (CheckMaNv(manv))
            {
                nhanvien.Xoa(manv);
            }
            else
            {
                throw new Exception("Mã không hợp lệ!");
            }
        }
        public void Them(nhanvien nv)
        {
            nhanvien.Them(nv);
        }
        public void Sua(nhanvien nv)
        {
            nhanvien.Sua(nv);
        }
        //Tìm kiếm theo: mã, tên, địa chỉ, sđt
        public List<nhanvien> TimKiem(string x)
        {
            //Tạo 1 list để lấy toàn bộ dữ liệu của hhách hàng
            List<nhanvien> datanv = nhanvien.GetDataNV();
            //hhởi tạo 1 list kq để lưu kết quả 
            List<nhanvien> kq = new List<nhanvien>();
            for (int i = 0; i < datanv.Count; i++)
            {
                if(datanv[i].Ma.Contains(x) || datanv[i].Ten.ToUpper().Contains(x.ToUpper()) || datanv[i].Que.ToUpper().Contains(x.ToUpper()) || datanv[i].SDT.ToString().Contains(x))
                {
                    kq.Add(datanv[i]);
                }
            }
            return kq;
        }
        public string Gtennv(string x)
        {
            string kq = "";
            nhanvienBLL dsnv = new nhanvienBLL();
            List<nhanvien> listnv = dsnv.GetDataNV();
            for (int i = 0; i < listnv.Count; i++)
            {
                if (listnv[i].Ma == x)
                {
                    kq = listnv[i].Ten;
                }
            }
            return kq;
        }
    }
}

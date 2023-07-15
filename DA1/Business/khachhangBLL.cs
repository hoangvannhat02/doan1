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
    class khachhangBLL : IKhachHang
    {
        private IKhachHangDAL khbll = new khachhangDAL();
        public List<khachhang> GetDataKH()
        {
            return khbll.GetDataKH();
        }
        public bool Checkmakh(string ma)
        {
            bool check = false;
            List<khachhang> dskh = GetDataKH();
            for (int i = 0; i < dskh.Count; i++)
            {
                if (dskh[i].MaKH.Equals(ma))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void Xoa(string makh)
        {
            if (Checkmakh(makh))
            {
                khbll.Xoa(makh);
            }
            else
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }
        }
        public void Them(khachhang kh)
        {
            if (kh.NameKH != " "&& kh.MaKH != " ")
            {
                khbll.Them(kh);
            }
            else
            {
                Console.WriteLine("Dữ liệu không hợp lệ");
            }
        }
        public void Sua(khachhang kh)
        {

            khbll.Sua(kh);

        }
        public List<khachhang> TimKiem(string x)
        {
            //Tạo 1 list để lấy toàn bộ dữ liệu của khách hàng
            List<khachhang> datakh = khbll.GetDataKH();
            //khởi tạo 1 list kq để lưu kết quả 
            List<khachhang> kq = new List<khachhang>();
            for (int i = 0; i < datakh.Count; i++)
            {
                if(datakh[i].MaKH.Contains(x) || datakh[i].NameKH.ToUpper().Contains(x.ToUpper()) || datakh[i].Qq.ToUpper().Contains(x.ToUpper()) || datakh[i].Sdt.ToString().Contains(x))
                {
                    kq.Add(datakh[i]);
                }
            }
            return kq;
        }
        public string GTenkh(string x)
        {
            string kq = "";
            khachhangBLL dskh = new khachhangBLL();
            List<khachhang> listkh = dskh.GetDataKH();
            for (int i = 0; i < listkh.Count; i++)
            {
                if (listkh[i].MaKH == x)
                {
                    kq = listkh[i].NameKH;
                }
            }
            return kq;
        }
        public string GQuekh(string x)
        {
            string kq = "";
            khachhangBLL dskh = new khachhangBLL();
            List<khachhang> listkh = dskh.GetDataKH();
            for (int i = 0; i < listkh.Count; i++)
            {
                if (listkh[i].MaKH == x)
                {
                    kq = listkh[i].Qq;
                }
            }
            return kq;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.Business.Interface;
using DA1.Business;
using DA1.DAL;

namespace DA1.Business
{
    class hanghoaBLL : Ihanghoa
    {
        private hanghoaDAL dshh = new hanghoaDAL();
        public List<hanghoa> GetDataHH()
        {
            return dshh.GetDataHH();
        }
        public void Xoa(string mahh)
        {
            dshh.Xoa(mahh);
        }
        public bool CheckMa(string ma)
        {
            bool check = false;
            List<hanghoa> list = dshh.GetDataHH();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ma.Equals(ma))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void Them(hanghoa hh)
        {
            if (hh.Ten != ""&&hh.Ma!="")
            {
                dshh.Them(hh);
            }
            else
            {
                throw new Exception("Dữ liệu không hợp lệ");
            }
        }
        public void Sua(hanghoa hh)
        {
            dshh.Sua(hh);
        }
        public List<hanghoa> Tim(string y)
        {
            List<hanghoa> datahh = dshh.GetDataHH();
            List<hanghoa> kq = new List<hanghoa>();
            for (int i = 0; i < datahh.Count; i++)
            {
                if (datahh[i].Ma.Equals(y)||datahh[i].Ten.ToUpper().Contains(y.ToUpper())||datahh[i].Xuatxu.ToUpper().Contains(y.ToUpper())||datahh[i].Gia.ToString().Equals(y)||datahh[i].Ngay.ToString("dd/MM/yyyy")==y)
                {
                    kq.Add(datahh[i]);
                }
            }
            return kq;
        }
        public string GXXu(string x)
        {
            string xx = "";
            List<hanghoa> ds = dshh.GetDataHH();
            for (int i = 0; i <ds.Count; i++)
            {
                if (ds[i].Ma.Equals(x))
                {
                    xx = ds[i].Xuatxu;
                }
            }
            return xx;
        }
        public string Gettenhh(string x)
        {
            string kq = "";
            hanghoaBLL dshh = new hanghoaBLL();
            List<hanghoa> list = dshh.GetDataHH();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ma.Equals(x))
                {
                    kq = list[i].Ten;
                }
            }
            return kq;
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
                    kq = list[i].Gia;
                }
            }
            return kq;
        }
        public List<hanghoa> ThongKe()
        {
            List<hanghoa> hh = dshh.GetDataHH();
            List<hanghoa> kq = new List<hanghoa>();
            for (int i = 0; i < hh.Count; i++)
            {
                if (hh[i].SL <= 10)
                {
                    kq.Add(hh[i]);
                }
            }
            return kq;
        }
    }
}

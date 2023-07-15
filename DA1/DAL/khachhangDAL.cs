using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DA1.KhaiBao;
using DA1.DAL.Interface;
namespace DA1.DAL
{
    class khachhangDAL : IKhachHangDAL
    {
        private string tep = @"Data\khachhang.txt";
        public List<khachhang> GetDataKH()
        {
            // Tạo một list để lưu dữ liệu từ tệp
            List<khachhang> dskh = new List<khachhang>();
            //Mở tệp
            StreamReader p = File.OpenText(tep);
            string s = p.ReadLine();
            //Kiểm tra tệp có tồn tại hay không nếu không gán bằng null
            if (!File.Exists(tep))
            {
                dskh = null;
            }
            while (s != null)
            {
                if (s != "")
                {
                    string[] x = s.Split('#');
                    khachhang kh = new khachhang(x[0], x[1], int.Parse(x[2]), x[3], x[4],x[5]);
                    dskh.Add(kh);
                }
                s = p.ReadLine();
            }
            p.Close();
            return dskh;
        }
        public void Them(khachhang kh)
        {
            StreamWriter wt = new StreamWriter(tep, true);
            wt.WriteLine(kh.MaKH + "#" + kh.NameKH + "#" + kh.TuoiKH + "#" + kh.GT + "#" + kh.Qq + "#" + kh.Sdt);
            wt.Close();
        }
        public void Them2(List<khachhang> listkh)
        {
            StreamWriter sw = new StreamWriter(tep, false);
            for (int i = 0; i < listkh.Count; i++)
            {
                sw.WriteLine(listkh[i].MaKH + "#" + listkh[i].NameKH + "#" + listkh[i].TuoiKH + "#" + listkh[i].GT + "#" + listkh[i].Qq + "#" + listkh[i].Sdt);
            }
            sw.Close();
        }
        public void Xoa(string makh)
        {
            List<khachhang> dskh = GetDataKH();
            for (int i = 0; i < dskh.Count; i++)
            {
                if (dskh[i].MaKH.Equals(makh))
                {
                    dskh.RemoveAt(i);
                    Them2(dskh);
                }
            }          
        }
        //Sửa 
        public void Sua(khachhang kh)
        {
            List<khachhang> dskh = GetDataKH();
            for (int i = 0; i < dskh.Count; i++)
            {
                if (dskh[i].MaKH == kh.MaKH)
                {
                    dskh[i].NameKH = kh.NameKH;
                    dskh[i].TuoiKH = kh.TuoiKH;
                    dskh[i].GT = kh.GT;
                    dskh[i].Qq = kh.Qq;
                    dskh[i].Sdt = kh.Sdt;
                }
            }
            Them2(dskh);
        }
    }
}

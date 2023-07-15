using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.DAL.Interface;
using DA1.KhaiBao;
using System.IO;

namespace DA1.DAL
{
    class HoaDonNhapDAL:IHoaDonNhapDAL
    {
        private string teptxt = @"Data\hoadonnhap.txt";
        public List<hoadonnhap> GetDataHDN()
        {
            List<hoadonnhap> list = new List<hoadonnhap>();
            StreamReader sr = File.OpenText(teptxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] x = s.Split('#');
                  
                    hoadonnhap hdn = new hoadonnhap(x[0], x[1], x[2], DateTime.Parse(x[3]), x[4], x[5], x[6], double.Parse(x[7]), double.Parse(x[8]));
                    list.Add(hdn);
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void Them(hoadonnhap hdn)
        {
            StreamWriter sw = new StreamWriter(teptxt, true);
            sw.WriteLine(hdn.MaHD+"#"+hdn.MaNV+"#"+hdn.TenNV+"#"+hdn.Ngay.ToString("dd/MM/yyyy") + "#"+hdn.MaHH+"#"+hdn.TenHH+"#"+hdn.XuatXu+"#"+hdn.SL +"#"+hdn.Gia);
            sw.Close();
        }
        public void Xoa(string mahdn)
        {
            List<hoadonnhap> hdn = GetDataHDN();
            for (int i = 0; i < hdn.Count; i++)
            {
                if (hdn[i].MaHD == mahdn)
                {
                    hdn.RemoveAt(i);
                    Update(hdn);
                }
            }
        }
        public void Update(List<hoadonnhap> hdn)
        {
            StreamWriter sw = new StreamWriter(teptxt, false);
            for (int i = 0; i < hdn.Count; i++)
            {
                sw.WriteLine(hdn[i].MaHD + "#" + hdn[i].MaNV + "#" + hdn[i].TenNV + "#" + hdn[i].Ngay.ToString("dd/MM/yyyy") + "#" + hdn[i].MaHH + "#" + hdn[i].TenHH + "#" + hdn[i].XuatXu + "#" + hdn[i].SL + "#" + hdn[i].Gia);
            }
            sw.Close();
        }
    }
}

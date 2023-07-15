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
    class HoaDonDAL:IHoaDonDAL
    {
        private string tep = @"Data\hoadon.txt";
        public List<hoadon> GetDataHD()
        {
            List<hoadon> list = new List<hoadon>();
            StreamReader sr = File.OpenText(tep);
            string s = sr.ReadLine();
            if(!File.Exists(tep))
            {
                sr = null;
            }
            while (s != null)
            {
                if (s != "")
                {
                    string[] x = s.Split('#');
                    hoadon hd = new hoadon(x[0], x[1], x[2],x[3],x[4],x[5],DateTime.Parse(x[6]), x[7], x[8], double.Parse(x[9]),double.Parse(x[10]),double.Parse(x[11]));
                    list.Add(hd);
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void Them(hoadon hd)
        {
            StreamWriter sw = new StreamWriter(tep,true);
            sw.WriteLine(hd.GMahd + "#" + hd.GMakh + "#" + hd.GTenkh + "#" + hd.GQuekh + "#"+hd.GManv + "#"+hd.GTennv+ "#"+ hd.GNgayban.ToString("dd/MM/yyyy") + "#" + hd.GMahh + "#" + hd.GTenhh + "#" + hd.Gsl + "#" + hd.Ggia+"#"+hd.Gtongtien);
            sw.Close();
        }
        public void Xoa(string mahd)
        {
            List<hoadon> hd = GetDataHD();
            StreamWriter sw = new StreamWriter(tep, false);
            for (int i = 0; i < hd.Count; i++)
            {
                if (hd[i].GMahd != mahd)
                {
                    sw.WriteLine(hd[i].GMahd + "#" + hd[i].GMakh + "#" + hd[i].GTenkh + "#" + hd[i].GQuekh + "#" + hd[i].GManv + "#" + hd[i].GTennv + "#" + hd[i].GNgayban.ToString("dd/MM/yyyy") + "#" + hd[i].GMahh + "#" + hd[i].GTenhh + "#" + hd[i].Gsl + "#" + hd[i].Ggia + "#" + hd[i].Gtongtien);
                }
            }
            sw.Close();
        }
        public void Update(List<hoadon> list)
        {
            StreamWriter sw = new StreamWriter(tep, false);
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i].GMahd + "#" + list[i].GMakh + "#" + list[i].GTenkh + "#" + list[i].GNgayban.ToString("dd/MM/yyyy") + "#" + list[i].GMahh + "#" + list[i].GTenhh + "#" + list[i].Gsl + "#" + list[i].Ggia + "#" + list[i].Gtongtien);
            }
            sw.Close();
        }
    }
}

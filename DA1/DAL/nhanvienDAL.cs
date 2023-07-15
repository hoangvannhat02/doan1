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
    class nhanvienDAL:INhanVienDAL
    {
        private string tep = @"Data\nhanvien.txt";
        public List<nhanvien> GetDataNV()
        {
            //Tạo 1 list để lưu danh sách thông tin được lấy ra từ tệp
            List<nhanvien> dsnv = new List<nhanvien>();
            StreamReader p = File.OpenText(tep);
            string s = p.ReadLine();
            if (!File.Exists(tep))
            {
                dsnv = null;
            }
            while(s!=null)
            {
                if (s != "")
                {
                    
                    string[] x = s.Split('#');
                    nhanvien nv = new nhanvien(x[0], x[1], int.Parse(x[2]), x[3], x[4], x[5], double.Parse(x[6]),double.Parse(x[7]));
                    dsnv.Add(nv);
                }
                s = p.ReadLine();
            }
            p.Close();
            return dsnv;
        }
        //Ghi nối thêm thông tin vào tệp
        public void Them(nhanvien nv)
        {
            StreamWriter wt = new StreamWriter(tep, true);
            wt.WriteLine(nv.Ma + "#" + nv.Ten + "#" + nv.Tuoi + "#"+nv.Gt+"#" + nv.Que + "#" + nv.SDT+"#"+nv.PC+"#"+nv.lcb);
            wt.Close();
        }
        //Update lại thông tin trong tệp
        public void Them2(List<nhanvien> nv)
        {
            StreamWriter wt = new StreamWriter(tep, false);
            for (int i = 0; i < nv.Count; i++)
            {
                wt.WriteLine(nv[i].Ma + "#" + nv[i].Ten + "#" + nv[i].Tuoi + "#" + nv[i].Gt + "#" + nv[i].Que + "#" + nv[i].SDT + "#" + nv[i].PC+"#"+nv[i].LCB);
            }
            wt.Close();
        }
        //Xóa thông tin theo mã nhập từ bàn phím
        public void Xoa(string manv)
        {
            List<nhanvien> dsnv = GetDataNV();
            for (int i = 0; i < dsnv.Count; i++)
            {
                if (dsnv[i].Ma == manv)
                    dsnv.RemoveAt(i);
                    Them2(dsnv);
            }
        }
        //Sửa thông tin nhân viên
        public void Sua(nhanvien nv)
        {
            List<nhanvien> listnv = GetDataNV();
            for (int i = 0; i < listnv.Count; i++)
            {
                if (listnv[i].Ma == nv.Ma)
                {
                    listnv[i].Ten = nv.Ten;
                    listnv[i].Tuoi = nv.Tuoi;
                    listnv[i].Gt = nv.Gt;
                    listnv[i].Que = nv.Que;
                    listnv[i].SDT = nv.SDT;
                    listnv[i].PC = nv.PC;
                    listnv[i].LCB = nv.LCB;
                    break;
                }
            }
            Them2(listnv);
        }
    }
}

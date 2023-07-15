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
    class hanghoaDAL : IhanghoaDAL
    {
        /// <summary>
        /// Tạo đường dẫn đến tệp hanghoa.txt để thao tác với tệp
        /// </summary>
        private string tentep = @"Data\hanghoa.txt";
        /// <summary>
        /// khởi tạo một hàm kết quả trả về là một danh sách thông tin hàng hóa theo thứ tự đã định sẵn
        /// </summary>
        /// <returns></returns>
        public List<hanghoa> GetDataHH()
        {
            //Tạo 1 list để lưu danh sách hàng hóa
            List<hanghoa> ds = new List<hanghoa>();
            //Mở tệp
            StreamReader sr = File.OpenText(tentep);
            //Đọc dòng đầu
            string s = sr.ReadLine();
            //Ktra nếu k tồn tại file thì gán list = null
            if (!File.Exists(tentep))
            {
                ds = null;
            }
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    hanghoa hh = new hanghoa(a[0],a[1],a[2],DateTime.Parse(a[3]),double.Parse(a[4]),double.Parse(a[5]));
                    ds.Add(hh);
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return ds;
        }
        //Thêm dữ liệu vào tệp
        /// <summary>
        /// Khởi tạo một phương thức với tham số truyền vào là một list danh sách theo thứ tự
        /// Cùng với thao tác với tệp(mở đóng tệp)
        /// </summary>
        /// <param name="hh"></param>
        public void Them(hanghoa hh)
        {
            //Ghi nối vào tệp
            StreamWriter sw = new StreamWriter(tentep, true);
            sw.WriteLine(hh.Ma + "#" + hh.Ten + "#" + hh.Xuatxu + "#" + hh.Ngay.ToString("dd/MM/yyyy") + "#" + hh.SL + "#" + hh.Gia);
            sw.Close();
        }
        /// <summary>
        /// Khỏi tạo một phương thức với tham số truyền vào là một danh sách cho phép ghi đè(thay thế) nội dung của chương trình theo thứ tự định sẵn
        /// </summary>
        /// <param name="dshh"></param>
        //Update lại danh sách
        public void Them2(List<hanghoa> dshh)
        {
            //Ghi đè lên tệp
            StreamWriter sw = new StreamWriter(tentep, false);
            for (int i = 0; i < dshh.Count; i++)
            {
                sw.WriteLine(dshh[i].Ma+"#"+dshh[i].Ten+"#"+dshh[i].Xuatxu + "#" +dshh[i].Ngay.ToString("dd/MM/yyyy")+"#"+dshh[i].SL+"#"+dshh[i].Gia);
            }
            sw.Close();
        }
        /// <summary>
        /// Khởi tạo phương thức với tham số truyền vào là một biến kiểu string(chuỗi ký tự) cho phép lấy dữ liệu từ tệp xong xóa theo vị trí xác định
        /// </summary>
        /// <param name="mahh"></param>
        //Xóa thông tin hàng hóa theo mã hàng hóa
        public void Xoa(string mahh)
        {
            //Lấy dữ liệu từ tệp và lưu vào list
            List<hanghoa> dshh = GetDataHH();
            for (int i = 0; i < dshh.Count; i++)
            {
                if (dshh[i].Ma == mahh)
                {
                    dshh.RemoveAt(i);
                    Them2(dshh);
                }
            }
        }
        /// <summary>
        /// khởi tạo một phương thức với tham số truyền vào là một đối tượng cho phép thay thế các đối tượng này thành đối tượng mới ở trong dữ liệu theo vị trí xác định
        /// </summary>
        /// <param name="hh"></param>
        //Sửa thông tin theo mã của danh sách
        public void Sua(hanghoa hh)
        {
            List<hanghoa> dshh = GetDataHH();
            for (int i = 0; i < dshh.Count; i++)
            {
                if (dshh[i].Ma == hh.Ma)
                {
                    dshh[i].Ten = hh.Ten;
                    dshh[i].SL = hh.SL;
                    dshh[i].Gia = hh.Gia;
                    dshh[i].Ngay = hh.Ngay;
                    dshh[i].Xuatxu = hh.Xuatxu;
                    break;
                }
            }
            Them2(dshh);
        }
    }
}

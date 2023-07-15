using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.DAL;

namespace DA1.Business.Interface
{
    interface IKhachHang
    {
        List<khachhang> GetDataKH();
        void Xoa(string makh);
        void Them(khachhang kh);
        void Sua(khachhang kh);
        bool Checkmakh(string makh);
        List<khachhang> TimKiem(string x);
    }
}

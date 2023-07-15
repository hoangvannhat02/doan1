using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.DAL.Interface
{
    interface IKhachHangDAL
    {
        List<khachhang> GetDataKH();
        void Them(khachhang kh);
        void Xoa(string makh);
        void Sua(khachhang kh);
    }
}

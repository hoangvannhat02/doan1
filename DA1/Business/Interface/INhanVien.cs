using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.DAL;

namespace DA1.Business.Interface
{
    interface INhanVien
    {
        List<nhanvien> GetDataNV();
        void Xoa(string manv);
        void Them(nhanvien nv);
        bool CheckMaNv(string manv);
        void Sua(nhanvien nv);
        List<nhanvien> TimKiem(string x);
    }
}

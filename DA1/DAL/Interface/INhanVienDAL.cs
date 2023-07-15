using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
namespace DA1.DAL.Interface
{
    interface INhanVienDAL
    {
        List<nhanvien> GetDataNV();
        void Them(nhanvien nv);
        void Xoa(string manv);
        void Them2(List<nhanvien> nv);
        void Sua(nhanvien nv);
    }
}

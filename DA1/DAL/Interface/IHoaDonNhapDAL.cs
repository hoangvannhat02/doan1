using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.DAL.Interface
{
    interface IHoaDonNhapDAL
    {
        List<hoadonnhap> GetDataHDN();
        void Them(hoadonnhap hdn);
        //void Sua(hoadonnhap hdn);
        void Xoa(string ma);
        void Update(List<hoadonnhap> listhd);
    }
}

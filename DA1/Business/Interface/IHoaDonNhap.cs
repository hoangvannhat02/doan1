using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.Business.Interface
{
    interface IHoaDonNhap
    {
        List<hoadonnhap> GetDataHDN();
        void Them(hoadonnhap hdn);
        void Xoa(string ma);
        bool CheckMahd(string ma);
        List<hoadonnhap> Tim(string ma);
    }
}

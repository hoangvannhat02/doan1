using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.Business.Interface
{
    interface IHoaDonBLL
    {
        List<hoadon> GetDataHD();
        void Them(hoadon hd);
        void Xoa(string ma);
        List<hoadon> Tim(string ma);
        bool Checkmahd(string ma);
    }
}

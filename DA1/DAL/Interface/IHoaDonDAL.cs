using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.DAL.Interface
{
    interface IHoaDonDAL
    {
        List<hoadon> GetDataHD();
        void Them(hoadon hd);
        void Xoa(string ma);
        void Update(List<hoadon> list);
    }
}

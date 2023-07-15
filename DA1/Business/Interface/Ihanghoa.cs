using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;

namespace DA1.Business.Interface
{
    interface Ihanghoa
    {
        List<hanghoa> GetDataHH();
        void Xoa(string mahh);
        void Them(hanghoa hh);
        void Sua(hanghoa hh);
        bool CheckMa(string ma);
        List<hanghoa> Tim(string mahh);
    }
}

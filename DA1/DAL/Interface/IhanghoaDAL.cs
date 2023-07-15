using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
namespace DA1.DAL.Interface
{
    interface IhanghoaDAL
    {
        List<hanghoa> GetDataHH();
        void Them(hanghoa hh);
        void Xoa(string ma);
        void Sua(hanghoa hh);
        void Them2(List<hanghoa> dshh);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.KhaiBao;
using DA1.Business;

namespace DA1.TienIch
{
    public static class tienich
    {
        public static bool Checkdodaichu(string s,int dodai)
        {
            bool ktra = false;
            if (s.Length > 0 && s.Length <= dodai)
            {
                ktra = true;
            }
            return ktra;
        }
        public static void Xoadong(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
        }
    }
}

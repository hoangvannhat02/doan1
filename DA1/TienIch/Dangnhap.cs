using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.TienIch
{
    public class Dangnhap
    {
        private string tk;
        private string mk;
        public string TK
        {
            get { return tk; }
            set { tk=value; }
        }
        public string MK
        {
            get { return mk; }
            set { mk=value; }
        }

        public Dangnhap()
        {
            tk = "admin";
            mk = "Admin123";
        }
        public bool Login(int x, int y)
        {
            string tk, mk;
            bool check = false;
            int i = 0;
            do
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                           ĐĂNG NHẬP                               │");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("│ Tk:                                                               │");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine("│ Mk:                                                               │");
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.SetCursorPosition(x + 5, y + 3);
                tk = Console.ReadLine();
                Console.SetCursorPosition(x + 5, y + 5);
                mk = Console.ReadLine();
                Console.SetCursorPosition(x = 38, y + 7); Console.Write("Enter để đăng nhập, Esc để thoát: ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                {
                    if(tk == this.tk&&mk==this.mk)
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        i++;
                        check = false;
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine("Tài khoản hoặc mật khẩu không chính xác");
                    }
                }
            } while (i<=3);
            return check;
        }
    }
}

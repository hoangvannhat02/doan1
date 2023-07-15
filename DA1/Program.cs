using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.TienIch;


namespace DA1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dangnhap a = new Dangnhap();
            bool check;
            check = a.Login(4, 3);
            if (check)
            {
                Hien();
            }
            else Environment.Exit(0);
        }
        public static void Hien()
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Chương trình quản lí cửa hàng hoa quả.";
            int x = 1, y = 5;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x + 30, y); Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x + 30, y + 1); Console.WriteLine("|            QUẢN LÝ CỬA HÀNG HOA QUẢ              |");
            Console.SetCursorPosition(x + 30, y + 2); Console.WriteLine("|__________________________________________________|");
            Console.SetCursorPosition(x + 30, y + 3); Console.WriteLine("|  1.Quản lý hoa quả                               |");
            Console.SetCursorPosition(x + 30, y + 4); Console.WriteLine("|  2.Quản lý nhân viên                             |");
            Console.SetCursorPosition(x + 30, y + 5); Console.WriteLine("|  3.Quản lý khách hàng                            |");
            Console.SetCursorPosition(x + 30, y + 6); Console.WriteLine("|  4.Quản lý hóa đơn                               |");
            Console.SetCursorPosition(x + 30, y + 7); Console.WriteLine("|  5.Thống kê                                      |");
            Console.SetCursorPosition(x + 30, y + 8); Console.WriteLine("|  6.Thoát                                         |");
            Console.SetCursorPosition(x + 30, y + 9); Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.ResetColor();
      r:    try
            {
                
                do
                {
                    Console.SetCursorPosition(x + 30, y + 10); Console.Write("Mời chọn chức năng: ");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                            break;
                        case 2:

                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                            break;
                        case 3:
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                            break;
                        case 4:
                            Console.Clear();
                            DA1.Presenasion.menu.mnHD();
                            break;
                        case 5:
                            Console.Clear();
                            DA1.Presenasion.menu.mnThongKe();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(x + 30, y + 13);
                            Console.SetCursorPosition(x + 30, y + 11);
                            Console.WriteLine("Mời chọn lại chức năng từ 1->6");
                            break;

                    }
                } while (true);
            }catch(Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(x + 30, y + 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x + 30, y + 13);
                Console.Write(ex.Message+"Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto r;
            }

        }
    }
}

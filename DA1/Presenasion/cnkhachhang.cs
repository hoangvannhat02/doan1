using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.Business.Interface;
using DA1.Business;
using DA1.KhaiBao;
using System.Text.RegularExpressions;

namespace DA1.Presenasion
{
    class cnkhachhang
    {
        public void Nhap(int x, int y)
        {
            do
            {
                Console.Clear();
                IKhachHang dskh = new khachhangBLL();
                khachhang kh = new khachhang();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                     NHẬP THÔNG TIN KHÁCH HÀNG                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("│ Nhập mã:                                                          │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine("│ Tên:                                                              │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine("│ Tuổi:                                                             │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 8);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine("│ Giới tính(Nam/Nu):                                                │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 11);
                Console.WriteLine("│ Quê quán:                                                         │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 12);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 13);
                Console.WriteLine("│ SDT:                                                              │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 14);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y + 17);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(x, y + 19);
            x:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 11, y + 3);
                        kh.MaKH = Console.ReadLine().Trim();
                        if (dskh.Checkmakh(kh.MaKH))
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã khách hàng bạn nhập đã tồn tại .");
                        }
                        else if (TienIch.tienich.Checkdodaichu(kh.MaKH, 10) == false)
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài chữ tối đa 10 kí tự");
                        }
                        else if (kh.MaKH == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto x;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x+40, y+15);
            y: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 5);
                        kh.NameKH = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(kh.NameKH, 30) == false)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tối đa là 30 kí tự");
                        }
                        else if (kh.NameKH == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto y;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 15);
            z: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 7, y + 7);
                        kh.TuoiKH = int.Parse(Console.ReadLine());
                        if (kh.TuoiKH < 0)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Tuổi không hợp lệ");
                        }
                        else if (kh.TuoiKH == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto z;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 15);
            e: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 20, y + 9);
                        kh.GT = Console.ReadLine().Trim();
                        if (kh.GT == "Nam" || kh.GT == "Nu")
                        {
                            break;
                        }
                        else if (kh.GT == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else
                        {
                            goto e;
                        }
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto e;
                    }
                    else
                        return;
                }
                
                TienIch.tienich.Xoadong(x + 40, y + 15);
            f: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 11, y + 11);
                        kh.Qq = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(kh.Qq, 15) == false)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tối đa là 15 kí tự");
                        }
                        else if (kh.Qq == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto f;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 15);
            g: 
                try
                {
                    Regex r = new Regex(@"^((0)\d{9})$");
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 13);
                        kh.Sdt = Console.ReadLine();
                        if (r.IsMatch(kh.Sdt))
                        {
                            break;
                        }
                        else if (kh.Sdt == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Không hợp lệ .Vui lòng thử lại.");
                        }
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto g;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 15);
                Console.SetCursorPosition(x + 30, y + 15);
                Console.Write("Ấn Enter để thêm thông tin | Esc để quay lại");
                Console.SetCursorPosition(x + 74, y + 15);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter) { dskh.Them(kh); }
                else if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnKhachHang();
                }
            } while (true);
        }
        public void Hien2(int x,int y)
        {
            khachhangBLL dskh = new khachhangBLL();
            List<khachhang> kh = dskh.GetDataKH();
            //Console.Clear();
            Hienkh(kh,x,y);
            //DA1.Program.Hien();
        }
        public void Hienkh(List<khachhang> list,int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                        THÔNG TIN KHÁCH HÀNG                                       |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────┬──────────────────────┬──────┬───────────┬──────────────┬────────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│  Ma KH  |         Tên          | Tuổi | Giới tính │   Quê quán   |      SDT       |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────┼──────────────────────┼──────┼───────────┼──────────────┼────────────────┤");
            int z = y + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0} ", list[i].MaKH);
                Console.SetCursorPosition(x + 10, z);
                Console.WriteLine("|{0} ", list[i].NameKH);
                Console.SetCursorPosition(x + 33, z);
                Console.WriteLine("|{0} ", list[i].TuoiKH);
                Console.SetCursorPosition(x + 40, z);
                Console.WriteLine("|{0} ", list[i].GT);
                Console.SetCursorPosition(x + 52, z);
                Console.WriteLine("|{0} ", list[i].Qq);
                Console.SetCursorPosition(x + 67, z);
                Console.WriteLine("|{0} ", list[i].Sdt);
                Console.SetCursorPosition(x + 84, z);
                Console.WriteLine("|");
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└─────────┴──────────────────────┴──────┴───────────┴──────────────┴────────────────┘");

        }
        public void Xoa()
        {
            string ma = null;
            do
            {
                Console.Clear();
                IKhachHang dskh = new khachhangBLL();
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("| Nhập mã hàng hóa cần xóa:                                         |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("Note: Nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(10,9);
                do
                {
                    Console.SetCursorPosition(37, 2);
                    ma = Console.ReadLine().Trim();
                    if (dskh.Checkmakh(ma))
                    {
                        dskh.Xoa(ma);
                        break;
                    }
                    else if (ma == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnKhachHang();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(10, 5);
                        Console.WriteLine("Mã không hợp lệ vui lòng thử lại.");
                        Console.ResetColor();
                    }
                 
                } while (true);
            } while (true);
        }
        public void Tim()
        {
            string x = "";
            do
            {
                Console.Clear();
                IKhachHang dskh = new khachhangBLL();
                List<khachhang> kh = dskh.TimKiem(x);
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("| Nhập thông tin cần tìm:                                           |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.WriteLine("                Có thể tìm theo: mã, tên, quê quán, số điện thoại.");
                Console.ResetColor();
                Hienkh(kh,10,9);
                Console.SetCursorPosition(35, 2);
                x = Console.ReadLine().Trim();
                if (x == "0")
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnKhachHang();
                }
            } while (true);
        }
        public void Sua()
        {
            do
            {
                Console.Clear();
                khachhang kh = new khachhang();
                khachhangBLL dskh = new khachhangBLL();
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("|               Nhập thông tin khách hàng mới                       |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("| Mã:             Tên:                               Tuổi:          |");
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("| GT(Nam|Nu):        Quê quán:               SDT:                   |");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Hien2(10,12);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                do
                {
                    Console.SetCursorPosition(15, 4);
                    kh.MaKH = Console.ReadLine().Trim();
                    if (dskh.Checkmakh(kh.MaKH))
                    {
                        break;
                    }
                    else if (kh.MaKH == null)
                    {
                        TienIch.tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Không thể bỏ trống phần này");
                    }
                    else if (TienIch.tienich.Checkdodaichu(kh.MaKH, 10) == false)
                    {
                        TienIch.tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Độ dài chữ tối đa 10 kí tự");
                    }
                    else if (kh.MaKH == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnKhachHang();
                    }
                    else
                    {
                        TienIch.tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Mã không tồn tại vui lòng kiểm tra lại dữ liệu nhập vào.");
                    }
                } while (true);
                TienIch.tienich.Xoadong(10, 0);
            y: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(32, 4);
                        kh.NameKH = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(kh.NameKH, 30) == false)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Độ dài tối đa là 30 kí tự");
                        }
                        else if (kh.NameKH == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(10,0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message+ "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto y;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            z: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(68, 4);
                        kh.TuoiKH = int.Parse(Console.ReadLine());
                        if (kh.TuoiKH < 1)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Tuổi không hợp lệ");
                        }
                        else if (kh.TuoiKH == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto z;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            e: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(23, 5);
                        kh.GT = Console.ReadLine().Trim();
                        if (kh.GT == "Nam" || kh.GT == "Nu")
                        {
                            break;
                        }
                        else if (kh.GT == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else
                        {
                            goto e;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto e;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            f: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(40, 5);
                        kh.Qq = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(kh.Qq, 15) == false)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tối đa là 15 kí tự");
                        }
                        else if (kh.Qq == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto f;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
                
               
            g:
                try
                {
                    Regex r = new Regex(@"^((0)\d{9})$");
                    do
                    {
                        Console.SetCursorPosition(59, 5);
                        kh.Sdt = Console.ReadLine();
                        if (r.IsMatch(kh.Sdt))
                        {
                            break;
                        }
                        else if (kh.Sdt == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnKhachHang();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(10,0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Không hợp lệ .Vui lòng thử lại.");
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto g;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
                
                Console.SetCursorPosition(10, 10);
                Console.Write("Ấn enter để sửa - esc quay lại => ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnKhachHang();
                }else if(kt.Key==ConsoleKey.Enter) dskh.Sua(kh);
            } while (true);
        }
    }
}

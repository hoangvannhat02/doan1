using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.Business.Interface;
using DA1.Business;
using DA1.KhaiBao;
using DA1.TienIch;

namespace DA1.Presenasion
{
    //Thực thi giao tiếp với người sử dụng đê giải quyết vấn đề của bài toán với các yêu cầu
    //được đặt ra trong Business
    class cnhanghoa
    {
        public void Nhap()
        {
            int x = 15, y = 5;
            do
            {
                hanghoaBLL dshh = new hanghoaBLL();
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                     NHẬP THÔNG TIN HÀNG HÓA                       │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("│ Mã:                                                               │");
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
                Console.WriteLine("│ Ngày nhập(dd/mm/yyyy):                                            │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 8);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine("│ Xuất xứ:                                                          │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 11);
                Console.WriteLine("│ Số lượng:                                                         │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 12);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 13);
                Console.WriteLine("│ Giá thành:                                                        │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 14);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, y + 17);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(x,y+19);
                hanghoa hh = new hanghoa();
            x: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 5, y + 3);
                        hh.Ma = Console.ReadLine().Trim();
                        if (hh.Ma == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else if (dshh.CheckMa(hh.Ma))
                        {
                            tienich.Xoadong(1, 1);
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã bạn nhập đã tồn tại vui lòng nhập lại mã mới.");
                        }
                        else if (tienich.Checkdodaichu(hh.Ma, 10) == false)
                        {
                            tienich.Xoadong(1, 1);
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài mã không được vượt quá 10.");
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
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
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
            y: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 5);
                        hh.Ten = Console.ReadLine().Trim();
                        if (tienich.Checkdodaichu(hh.Ten, 30) == false)
                        {
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tên không quá 30");
                        }
                        else if (hh.Ten == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn enter để nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto y;
                    }
                    else
                        return;
                }
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
            m:
                try
                {
                    Console.SetCursorPosition(x + 24, y + 7);
                    hh.Ngay = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {

                        goto m;
                    }
                    else
                        return;
                }
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
            n:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 10, y + 9);
                        hh.Xuatxu = Console.ReadLine();
                        if (hh.Xuatxu == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else if (tienich.Checkdodaichu(hh.Xuatxu, 15) == false)
                        {
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài không được quá 15");
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {

                        goto n;
                    }
                    else
                        return;
                }
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
            z:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 12, y + 11);
                        hh.SL = double.Parse(Console.ReadLine());
                        if (hh.SL < 0)
                        {
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >=0");
                        }
                        else if (hh.SL == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
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
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
                Console.SetCursorPosition(1, 1);
            e:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 13, y + 13);
                        hh.Gia = double.Parse(Console.ReadLine());
                        if (hh.Gia == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else if (hh.Gia < 0)
                        {
                            tienich.Xoadong(x + 30, y + 15);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >=0");
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    tienich.Xoadong(1, 1);
                    Console.SetCursorPosition(x + 30, y + 15);
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
                tienich.Xoadong(1, 1);
                tienich.Xoadong(x + 30, y + 15);
                Console.SetCursorPosition(x + 20, y + 15);
                Console.Write("Ấn Enter để thêm thông tin | Esc để quay lại");
                Console.SetCursorPosition(x + 65, y + 15);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHangHoa();
                }
                else if (kt.Key == ConsoleKey.Enter)
                    dshh.Them(hh);
            } while (true);
        }
        public void Hien(List<hanghoa> list, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                                THÔNG TIN HÀNG HÓA                                    |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────────┬───────────────┬───────────────┬───────────────┬──────────────┬───────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│   Ma HH   |    Họ tên     |   Ngày nhập   |    Xuất xứ    | Số lượng(kg) | Giá thành │");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────────┼───────────────┼───────────────┼───────────────┼──────────────┼───────────┤");

            y++;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("|{0} ", list[i].Ma);
                Console.SetCursorPosition(x + 12, y);
                Console.WriteLine("|{0} ", list[i].Ten);
                Console.SetCursorPosition(x + 28, y);
                Console.WriteLine("|{0} ", list[i].Ngay.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(x + 44, y);
                Console.WriteLine("|{0} ", list[i].Xuatxu);
                Console.SetCursorPosition(x + 60, y);
                Console.WriteLine("|{0} ", list[i].SL);
                Console.SetCursorPosition(x + 75, y);
                Console.WriteLine("|{0} ", list[i].Gia);
                Console.SetCursorPosition(x + 87, y);
                Console.WriteLine("|");
                y++;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine("└───────────┴───────────────┴───────────────┴───────────────┴──────────────┴───────────┘");
        }
        public void Hien2(int x, int y)
        {
            Ihanghoa ds = new hanghoaBLL();
            List<hanghoa> dshh = ds.GetDataHH();
            Hien(dshh, x, y);
        }
        public void Xoa()
        {
            string ma = "";
            do
            {
                Console.Clear();
                Ihanghoa dshh = new hanghoaBLL();
                Console.WriteLine();
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập mã hàng hóa cần xóa:                                         |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(5, 10);
                do
                {
                    Console.SetCursorPosition(32, 2);
                    ma = Console.ReadLine().Trim();
                    if (dshh.CheckMa(ma))
                    {
                        dshh.Xoa(ma);
                        break;
                    }
                    else if (ma == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnHangHoa();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(5, 5);
                        Console.WriteLine("Mã không hợp lệ vui lòng thử lại.");
                        Console.ResetColor();
                    }
                } while (true);
            } while (true);
        }
        public void Tim()
        {
            string sp = "";
            do
            {
                Console.Clear();
                Ihanghoa dshh = new hanghoaBLL();
                List<hanghoa> hh = dshh.Tim(sp);
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập thông tin cần tìm:                                           |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập 0 và ấn enter để quay lại.");
                Console.WriteLine("           Có thể tìm theo: mã, tên, giá, xuất xứ, ngày (dd/mm/yyyy)");
                Console.ResetColor();
                Hien(hh, 5, 10);
                Console.SetCursorPosition(31, 2);
                sp = Console.ReadLine().Trim();
                if (sp == "0")
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHangHoa();
                }
            } while (true);
        }
        public void Sua()
        {
            do
            {
                Console.Clear();
                hanghoa hh = new hanghoa();
                Ihanghoa dshh = new hanghoaBLL();
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("|               Nhập thông tin hàng hóa mới                         |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("| Mã:         Tên:                          số lượng(kg):           |");
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("| Xuất xứ:                Ngày nhập(yyyy/mm/dd):                    |");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("| Giá(đ):                                                           |");
                Console.SetCursorPosition(10, 7);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Hien2(10, 12);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                do
                {
                    Console.SetCursorPosition(15, 4);
                    hh.Ma = Console.ReadLine().Trim();
                    if (dshh.CheckMa(hh.Ma))
                    {
                        break;
                    }
                    else if (hh.Ma == null)
                    {
                        tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Không thể bỏ trống phần này");
                    }
                    else if (tienich.Checkdodaichu(hh.Ma, 10) == false)
                    {
                        tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Độ dài tối đa là 10");
                    }
                    else if (hh.Ma == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnHangHoa();
                    }
                    else
                    {
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Mã không tồn tại vui lòng kiểm tra lại dữ liệu nhập vào.");
                    }
                } while (true);
                tienich.Xoadong(10, 0);
                do
                {
                    Console.SetCursorPosition(28, 4);
                    hh.Ten = Console.ReadLine();
                    if (hh.Ten == null)
                    {
                        tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Không thể bỏ trống phần này.");
                    }
                    else if (tienich.Checkdodaichu(hh.Ten, 30) == false)
                    {
                        tienich.Xoadong(10, 0);
                        Console.SetCursorPosition(10, 0);
                        Console.WriteLine("Tối đa là 30 kí tự");
                    }
                    else if (hh.Ten == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnHangHoa();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                tienich.Xoadong(10, 0);
            m:  try
                {
                    do
                    {
                        Console.SetCursorPosition(67, 4);
                        hh.SL = double.Parse(Console.ReadLine());
                        if (hh.SL == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else if (hh.SL < 0)
                        {
                            tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Giá trị nhập không hợp lệ");
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.WriteLine(ex.Message + "Ấn enter để nhập lại.");
                    ConsoleKeyInfo ck = Console.ReadKey();
                    if (ck.Key == ConsoleKey.Enter)
                    {
                        goto m;
                    }
                    else goto m;
                }
                tienich.Xoadong(10, 0);
            n:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(20, 5);
                        hh.Xuatxu = Console.ReadLine();
                        if (hh.Xuatxu == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else if (tienich.Checkdodaichu(hh.Xuatxu, 15) == false)
                        {
                            tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10,0);
                            Console.WriteLine("Độ dài không được quá 15");
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

                        goto n;
                    }
                    else
                        return;
                }
                tienich.Xoadong(10, 0);
            a:
                try
                {
                    Console.SetCursorPosition(58, 5);
                    hh.Ngay = DateTime.Parse(Console.ReadLine());
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

                        goto a;
                    }
                    else
                        return;
                }
                tienich.Xoadong(10, 0);
            l:  try
                {
                    do
                    {
                        Console.SetCursorPosition(19, 6);
                        hh.Gia = double.Parse(Console.ReadLine());
                        if (hh.Gia < 0)
                        {
                            tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Giá trị nhập không hợp lệ");
                        }
                        else if (hh.Gia == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHangHoa();
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.WriteLine(ex.Message + "Ấn enter để nhập lại.");
                    ConsoleKeyInfo ck = Console.ReadKey();
                    if (ck.Key == ConsoleKey.Enter)
                    {
                        goto l;
                    }
                    else goto l;
                }
                tienich.Xoadong(10, 0);
                Console.SetCursorPosition(10, 10);
                Console.Write("Ấn enter để sửa - esc quay lại => ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHangHoa();
                }else if(kt.Key == ConsoleKey.Enter)
                {
                    dshh.Sua(hh);
                }
            } while (true);
        }
        public void ThongKe(int x,int y)
        {
            Console.Clear();
            hanghoaBLL hh = new hanghoaBLL();
            List<hanghoa> list = hh.ThongKe();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                          THỐNG KÊ HÀNG HÓA SẮP - ĐÃ HẾT HÀNG                         |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────────┬───────────────┬───────────────┬───────────────┬──────────────┬───────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│   Ma HH   |    Họ tên     |   Ngày nhập   |    Xuất xứ    | Số lượng(kg) | Giá thành │");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────────┼───────────────┼───────────────┼───────────────┼──────────────┼───────────┤");
            y++;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("|{0} ", list[i].Ma);
                Console.SetCursorPosition(x + 12, y);
                Console.WriteLine("|{0} ", list[i].Ten);
                Console.SetCursorPosition(x + 28, y);
                Console.WriteLine("|{0} ", list[i].Ngay.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(x + 44, y);
                Console.WriteLine("|{0} ", list[i].Xuatxu);
                Console.SetCursorPosition(x + 60, y);
                Console.WriteLine("|{0} ", list[i].SL);
                Console.SetCursorPosition(x + 75, y);
                Console.WriteLine("|{0} ", list[i].Gia);
                Console.SetCursorPosition(x + 87, y);
                Console.WriteLine("|");
                y++;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine("└───────────┴───────────────┴───────────────┴───────────────┴──────────────┴───────────┘");
        }
    }
}

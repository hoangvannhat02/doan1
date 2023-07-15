using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.Business;
using DA1.KhaiBao;

namespace DA1.Presenasion
{
    class cnhoadon
    {
        public void Nhap(int x, int y)
        {
            do
            {
                hanghoaBLL dshh = new hanghoaBLL();
                HoaDonBLL dshd = new HoaDonBLL();
                khachhangBLL dskh = new khachhangBLL();
                nhanvienBLL dsnv = new nhanvienBLL();
                hoadon hd = new hoadon();
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                     NHẬP THÔNG TIN HÓA ĐƠN XUẤT                   │");
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
                Console.WriteLine("│ Mã khách hàng:                                                    │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine("│ Tên khách hàng:                                                   │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 8);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine("│ Quê khách hàng:                                                   │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 11);
                Console.WriteLine("│ Mã nhân viên:                                                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 12);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 13);
                Console.WriteLine("│ Tên nhân viên:                                                    │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 14);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 15);
                Console.WriteLine("│ Ngày xuất(dd/mm/yyyy):                                            │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 16);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 17);
                Console.WriteLine("│ Mã hàng hóa:                                                      │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 18);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 19);
                Console.WriteLine("│ Tên hàng hóa:                                                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 20);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 21);
                Console.WriteLine("│ Số lượng:                                                         │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 22);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 23);
                Console.WriteLine("│ Đơn giá:                                                          │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 24);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 25);
                Console.WriteLine("│ Tổng tiền:                                                        │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 26);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y + 29);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(x, y + 30);
            x: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 10, y + 3);
                        hd.GMahd = Console.ReadLine().Trim();
                        if (dshd.Checkmahd(hd.GMahd))
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã hóa đơn đã tồn tại vui lòng thử lại mã khác.");
                        }
                        else if (TienIch.tienich.Checkdodaichu(hd.GMahd, 10) == false)
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Tối đa 10 kí tự");
                        }
                        else if (hd.GMahd == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDon();
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 27);
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
                TienIch.tienich.Xoadong(x + 40, y + 27);
            y: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 16, y + 5);
                        hd.GMakh = Console.ReadLine().Trim();
                        if (dskh.Checkmakh(hd.GMakh))
                        {
                            break;
                        }
                        else if (hd.GMakh == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDon();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã khách hàng bạn nhập không tồn tại .");
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 27);
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
                Console.SetCursorPosition(x + 17, y + 7);
                Console.Write(dskh.GTenkh(hd.GMakh));
                hd.GTenkh = dskh.GTenkh(hd.GMakh);
                Console.SetCursorPosition(x + 17, y + 9);
                Console.Write(dskh.GQuekh(hd.GMakh));
                hd.GQuekh = dskh.GQuekh(hd.GMakh);
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 27);
            m: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 16, y + 11);
                        hd.GManv = Console.ReadLine().Trim();
                        if (dsnv.CheckMaNv(hd.GManv))
                        {
                            break;
                        }
                        else if (hd.GManv == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDon();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã nhân viên bạn nhập không tồn tại .");
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 27);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto m;
                    }
                    else
                        return;
                }
                Console.SetCursorPosition(x + 16, y + 13);
                Console.Write(dsnv.Gtennv(hd.GManv));
                hd.GTennv = dsnv.Gtennv(hd.GManv);
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 27);
            z: Console.SetCursorPosition(x + 24, y + 15);
                try
                {
                    hd.GNgayban = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 21);
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
                TienIch.tienich.Xoadong(x + 40, y + 27);
            e: try
                {

                    do
                    {
                        Console.SetCursorPosition(x + 14, y + 17);
                        hd.GMahh = Console.ReadLine().Trim();
                        if (hd.GMahh == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDon();
                        }
                        else if (!dshh.CheckMa(hd.GMahh))
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã bạn nhập không tồn tại vui lòng xem lại thông tin khách hàng.");
                        }
                        else
                        {
                            break;
                        }
                    } while (!dshh.CheckMa(hd.GMahh));
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 27);
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
                Console.SetCursorPosition(x + 15, y + 19);
                Console.Write(dshh.Gettenhh(hd.GMahh));
                hd.GTenhh = dshh.Gettenhh(hd.GMahh);
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 27);
            f:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 11, y + 21);
                        hd.Gsl = int.Parse(Console.ReadLine());
                        if (hd.Gsl == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnHoaDon();
                        }
                        else if (dshd.Checksl(hd.Gsl))
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Hàng hóa trong kho không đủ số lượng vui lòng xem lại.");
                        }
                        else if (hd.Gsl < 0)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 27);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >=0");
                        }
                        else break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 27);
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
                TienIch.tienich.Xoadong(x + 40, y + 27);

                Console.SetCursorPosition(x + 11, y + 23);
                Console.Write(dshd.GGia(hd.GMahh));
                hd.Ggia = dshd.GGia(hd.GMahh);
                Console.SetCursorPosition(x + 12, y + 25);
                Console.Write(hd.Gtongtien);

                Console.SetCursorPosition(x + 30, y + 28);
                Console.Write("Ấn Enter để thêm thông tin | Esc để quay lại");
                Console.SetCursorPosition(x + 74, y + 28);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                {
                    dshd.Updatesl(hd);
                    dshd.Them(hd);
                }
                else if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHoaDon();
                }
            } while (true);
        }
        public void Hien(List<hoadon> list, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                                              THÔNG TIN HOA DON XUẤT                                             |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────┬─────┬────────────────┬────────┬─────┬─────────────────┬───────────┬──────┬───────┬────┬─────────┬─────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│Ma HD|mã KH|    Tên KH      | Quê kh |Mã nv|      Tên nv     | Ngày xuất │Mã HH |Tên HH | sl | Đơn giá |Tổng tiền|");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────┼─────┼────────────────┼────────┼─────┼─────────────────┼───────────┼──────┼───────┼────┼─────────┼─────────┤");

            int z = y + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0} ", list[i].GMahd);
                Console.SetCursorPosition(x + 6, z);
                Console.WriteLine("|{0} ", list[i].GMakh);
                Console.SetCursorPosition(x + 12, z);
                Console.WriteLine("|{0} ", list[i].GTenkh);
                Console.SetCursorPosition(x + 29, z);
                Console.WriteLine("|{0} ", list[i].GQuekh);
                Console.SetCursorPosition(x + 38, z);
                Console.WriteLine("|{0} ", list[i].GManv);
                Console.SetCursorPosition(x + 44, z);
                Console.WriteLine("|{0} ", list[i].GTennv);
                Console.SetCursorPosition(x + 62, z);
                Console.WriteLine("|{0} ", list[i].GNgayban.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(x + 74, z);
                Console.WriteLine("|{0} ", list[i].GMahh);
                Console.SetCursorPosition(x + 81, z);
                Console.WriteLine("|{0} ", list[i].GTenhh);
                Console.SetCursorPosition(x + 89, z);
                Console.WriteLine("|{0} ", list[i].Gsl);
                Console.SetCursorPosition(x + 94, z);
                Console.WriteLine("|{0} ", list[i].Ggia);
                Console.SetCursorPosition(x + 104, z);
                Console.WriteLine("|{0} ", list[i].Gtongtien);
                Console.SetCursorPosition(x + 114, z);
                Console.WriteLine("|");
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└─────┴─────┴────────────────┴────────┴─────┴─────────────────┴───────────┴──────┴───────┴────┴─────────┴─────────┘");
        }
        public void Hien2(int x, int y)
        {
            HoaDonBLL hd = new HoaDonBLL();
            List<hoadon> list = hd.GetDataHD();
            Hien(list, x, y);
        }
        public void Xoa()
        {
            do
            {
                string ma;
                Console.Clear();
                HoaDonBLL dshd = new HoaDonBLL();
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập mã hóa đơn cần xóa:                                          |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(5, 10);
                do
                {
                    Console.SetCursorPosition(33, 2);
                    ma = Console.ReadLine().Trim();
                    if (dshd.Checkmahd(ma))
                    {
                        dshd.Xoa(ma);
                        break;
                    }
                    else if (ma == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnHoaDon();
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
            string tensp = "";
            do
            {
                Console.Clear();

                HoaDonBLL dshd = new HoaDonBLL();
                List<hoadon> hd = dshd.Tim(tensp);
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập mã hóa đơn cần tìm:                                          |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.WriteLine("      Có thể tìm theo: mã hd, mã nv, tên nv, mã kh, ngày xuất(dd/mm/yyyy), mã hh, tên hh");
                Console.ResetColor();
                Hien(hd, 5, 10);
                Console.SetCursorPosition(31, 2);
                tensp = Console.ReadLine().Trim();
                if (dshd.Checkmahd(tensp))
                {
                    break;
                }
                else if (tensp == "0")
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHoaDon();
                }
            } while (true);
        }
        public void Xuat(List<hoadon> list)
        {
            int x = 4, y = 3;
            Console.SetCursorPosition(x, y); Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y + 1); Console.WriteLine("|                                                                                        |");
            Console.SetCursorPosition(x, y + 2); Console.WriteLine("|  ------------------------------------------------------------------------------------  |");
            Console.SetCursorPosition(x, y + 3); Console.WriteLine("|                                    VIN MATRT                                           |");
            Console.SetCursorPosition(x, y + 4); Console.WriteLine("|                       Địa chỉ: số 1 - Văn Giang - Hưng Yên                             |");
            Console.SetCursorPosition(x, y + 5); Console.WriteLine("|                  Điện thoại: 0368891123(Tùng), 0376221825(Yến)                         |");
            Console.SetCursorPosition(x, y + 6); Console.WriteLine("|                         HÓA ĐƠN MUA Hàng             Mã HD:                            |");
            Console.SetCursorPosition(x, y + 7); Console.WriteLine("|   Tên khách hàng:                                                                      |");
            Console.SetCursorPosition(x, y + 8); Console.WriteLine("|   Địa chỉ:                                                                             |");
            Console.SetCursorPosition(x, y + 9); Console.WriteLine("|   ┌────────────────────────────────────────────────────────────────────────────────┐   |");
            Console.SetCursorPosition(x, y + 10); Console.WriteLine("|   |     Tên hàng       |    Số lượng (kg)     |   Đơn giá    |     Thành tiền      |   |");
            Console.SetCursorPosition(x, y + 11); Console.WriteLine("|   ├────────────────────┼──────────────────────┼──────────────┼─────────────────────┤   |");
            Console.SetCursorPosition(x, y + 12); Console.WriteLine("|   |                    |                      |              |                     |   |");
            Console.SetCursorPosition(x, y + 13); Console.WriteLine("|   └────────────────────┴──────────────────────┴──────────────┴─────────────────────┘   |");
            Console.SetCursorPosition(x, y + 14); Console.WriteLine("|                                                                                        |");
            Console.SetCursorPosition(x, y + 15); Console.WriteLine("|                                                                                        |");
            Console.SetCursorPosition(x, y + 16); Console.WriteLine("|  ------------------------------------------------------------------------------------  |");
            Console.SetCursorPosition(x, y + 17); Console.WriteLine("|                                                     Ngày:                              |");
            Console.SetCursorPosition(x, y + 18); Console.WriteLine("|                                                             Nhân viên                  |");
            Console.SetCursorPosition(x, y + 19); Console.WriteLine("|                                                                                        |");
            Console.SetCursorPosition(x, y + 20); Console.WriteLine("|                Cảm ơn bạn đã tin tưởng mua hàng của chúng tôi!                         |");
            Console.SetCursorPosition(x, y + 21); Console.WriteLine("|                                                                                        |");
            Console.SetCursorPosition(x, y + 22); Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────┘");
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x + 61, y + 6);
                Console.WriteLine(list[i].GMahd);
                Console.SetCursorPosition(x + 19, y + 7);
                Console.WriteLine(list[i].GTenkh);
                Console.SetCursorPosition(x + 12, y + 8);
                Console.WriteLine(list[i].GQuekh);
                Console.SetCursorPosition(x + 7, y + 12);
                Console.WriteLine(list[i].GTenhh);
                Console.SetCursorPosition(x + 28, y + 12);
                Console.WriteLine(list[i].Gsl);
                Console.SetCursorPosition(x + 50, y + 12);
                Console.WriteLine(list[i].Ggia);
                Console.SetCursorPosition(x + 60, y + 17);
                Console.WriteLine(list[i].GNgayban.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(x + 60, y + 19);
                Console.WriteLine(list[i].GTennv);
                Console.SetCursorPosition(x + 65, y + 12);
                Console.WriteLine(list[i].Gtongtien);
            }
        }
        public void Xuat2()
        {
        X: string x = "";
            Console.Clear();
            HoaDonBLL dshd = new HoaDonBLL();
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("| Nhập mã hóa đơn xuất:                                             |");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
            Console.ResetColor();
            do
            {
                Console.SetCursorPosition(28, 2);
                x = Console.ReadLine().Trim();
                if (dshd.Checkmahd(x))
                {
                    List<hoadon> hd = dshd.Tim(x);
                    Console.Clear();
                    Xuat(hd);
                    break;
                }
                else if (x == "0")
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHoaDon();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Mã không hợp lệ vui lòng thử lại.");
                    Console.ResetColor();
                }
            } while (true);
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(1, 1);
                Console.Write("Note: Ấn enter để quay lại, esc để trở về menu hóa đơn");
                ConsoleKeyInfo kt = Console.ReadKey();
                Console.ResetColor();
                if (kt.Key == ConsoleKey.Enter)
                {
                    goto X;
                }
                else if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHoaDon();
                    break;
                }
            } while (true);
        }
        public void ThongKe(int x, int y)
        {
            Console.Clear();

            int max = 0;
            int m = 0;
            List<int> savedem = new List<int>();
            HoaDonBLL hdbll = new HoaDonBLL();
            List<hoadon> dshd = hdbll.GetDataHD();
            List<bool> a = Checknv(dshd);
            List<int> vitri = new List<int>();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                          THỐNG KÊ NHÂN VIÊN                          |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┬────────────────────┬───────────────┬───────────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│   Ma nv     |      Họ tên        |   số đơn bán  |   Tổng tiền bán   |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┼────────────────────┼───────────────┼───────────────────┤");

            int z = y + 1;
            for (int i = 0; i < dshd.Count; i++)
            {
                double sum = 0;
                int dem = 0;
                if (a[i])
                {
                    for (int j = i; j < dshd.Count; j++)
                    {
                        if (dshd[i].GManv == dshd[j].GManv)
                        {
                            sum += dshd[i].Gtongtien;
                            dem++;
                        }
                    }
                    vitri.Add(i);
                    savedem.Add(dem);
                    for (int n = 0; n < savedem.Count; n++)
                    {
                        if (savedem[n] > max)
                        {
                            max = savedem[n];
                        }
                    }
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine("|{0}", dshd[i].GManv);
                    Console.SetCursorPosition(x + 14, z);
                    Console.WriteLine("|{0}", dshd[i].GTennv);
                    Console.SetCursorPosition(x + 35, z);
                    Console.WriteLine("|      {0}", dem);
                    Console.SetCursorPosition(x + 51, z);
                    Console.WriteLine("|   {0}", sum);
                    Console.SetCursorPosition(x + 71, z);
                    Console.WriteLine("|");
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("├─────────────┴────────────────────┴───────────────┴───────────────────┤");
            z = z + 1;
            for (int u = 0; u < savedem.Count; u++)
            {
                if (savedem[u] == max)
                {
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine($"|nhân viên bán nhiều hóa đơn nhất:                             sl:     |");
                    Console.SetCursorPosition(x + 34, z);
                    Console.WriteLine($"{dshd[vitri[u]].GTennv}");
                    Console.SetCursorPosition(x + 66, z);
                    Console.WriteLine($"{max}");
                    m++;
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────┘");
        X: Console.SetCursorPosition(1, 1);
            Console.Write("Ấn esc để quay lại => ");
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                DA1.Presenasion.menu.mnThongKe();
            }
            else
            {
                goto X;
            }
        }
        public void ThongKehh(int x, int y)
        {
            Console.Clear();

            double max = 0;
            int m = 0;
            List<double> savedem = new List<double>();
            HoaDonBLL hdbll = new HoaDonBLL();
            List<hoadon> dshd = hdbll.GetDataHD();
            List<bool> a = Checkhh(dshd);
            List<int> vitri = new List<int>();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                            THỐNG KÊ HÀNG HÓA                         |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┬────────────────────┬───────────────┬───────────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│   Ma SP     |      Tên sp        |số lg bán(kg)  |   Tổng tiền bán   |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┼────────────────────┼───────────────┼───────────────────┤");

            int z = y + 1;
            for (int i = 0; i < dshd.Count; i++)
            {
                double sum = 0;
                double dem = 0;
                if (a[i])
                {
                    for (int j = i; j < dshd.Count; j++)
                    {
                        if (dshd[i].GMahh == dshd[j].GMahh)
                        {
                            sum += dshd[i].Gtongtien;
                            dem += dshd[i].Gsl;
                        }
                    }
                    vitri.Add(i);
                    savedem.Add(dem);

                    for (int n = 0; n < savedem.Count; n++)
                    {
                        if (savedem[n] > max)
                        {
                            max = savedem[n];
                        }
                    }
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine("|{0}", dshd[i].GMahh);
                    Console.SetCursorPosition(x + 14, z);
                    Console.WriteLine("|{0}", dshd[i].GTenhh);
                    Console.SetCursorPosition(x + 35, z);
                    Console.WriteLine("|      {0}", dem);
                    Console.SetCursorPosition(x + 51, z);
                    Console.WriteLine("|   {0}", sum);
                    Console.SetCursorPosition(x + 71, z);
                    Console.WriteLine("|");
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("├─────────────┴────────────────────┴───────────────┴───────────────────┤");
            z = z + 1;
            for (int u = 0; u < savedem.Count; u++)
            {
                if (savedem[u] == max)
                {
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine($"|Hoa quả được chọn mua nhiều nhất:                             sl:     |");
                    Console.SetCursorPosition(x + 34, z);
                    Console.WriteLine($"{dshd[vitri[u]].GTenhh}");
                    Console.SetCursorPosition(x + 66, z);
                    Console.WriteLine($"{max}");
                    m++;
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────┘");

        }
        public void ThongKekh(int x, int y)
        {
            Console.Clear();

            double max = 0;
            int m = 0;
            List<int> savedem = new List<int>();
            HoaDonBLL hdbll = new HoaDonBLL();
            List<hoadon> dshd = hdbll.GetDataHD();
            List<bool> a = Checkkh(dshd);
            List<int> vitri = new List<int>();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                           THỐNG KÊ KHÁCH HÀNG                        |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┬────────────────────┬───────────────┬───────────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│   Mã KH     | Họ tên khách hàng  |  số lần mua   |   Tổng tiền       |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────────┼────────────────────┼───────────────┼───────────────────┤");

            int z = y + 1;
            for (int i = 0; i < dshd.Count; i++)
            {
                double sum = 0;
                int dem = 0;
                if (a[i])
                {
                    for (int j = i; j < dshd.Count; j++)
                    {
                        if (dshd[i].GMakh == dshd[j].GMakh)
                        {
                            sum += dshd[i].Gtongtien;
                            dem++;
                        }
                    }
                    vitri.Add(i);
                    savedem.Add(dem);

                    for (int n = 0; n < savedem.Count; n++)
                    {
                        if (savedem[n] > max)
                        {
                            max = savedem[n];
                        }
                    }
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine("|{0}", dshd[i].GMakh);
                    Console.SetCursorPosition(x + 14, z);
                    Console.WriteLine("|{0}", dshd[i].GTenkh);
                    Console.SetCursorPosition(x + 35, z);
                    Console.WriteLine("|      {0}", dem);
                    Console.SetCursorPosition(x + 51, z);
                    Console.WriteLine("|   {0}", sum);
                    Console.SetCursorPosition(x + 71, z);
                    Console.WriteLine("|");
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("├─────────────┴────────────────────┴───────────────┴───────────────────┤");
            z = z + 1;
            for (int u = 0; u < savedem.Count; u++)
            {
                if (savedem[u] == max)
                {
                    Console.SetCursorPosition(x, z);
                    Console.WriteLine($"|Khách mua hàng nhiều lần nhất:                        số lần mua:     |");
                    Console.SetCursorPosition(x + 32, z);
                    Console.WriteLine($"{dshd[vitri[u]].GTenkh}");
                    Console.SetCursorPosition(x + 66, z);
                    Console.WriteLine($"{max}");
                    m++;
                    z++;
                }
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────┘");
        X: Console.SetCursorPosition(1, 1);
            Console.Write("Ấn esc để quay lại => ");
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                DA1.Presenasion.menu.mnThongKe();
            }
            else
            {
                goto X;
            }
        }
        public List<bool> Checknv(List<hoadon> hd)
        {

            List<bool> check = new List<bool>(hd.Count);
            for (int i = 0; i < hd.Count; i++)
            {
                bool x = true;
                for (int j = 0; j < i; j++)
                {
                    if (hd[i].GManv == hd[j].GManv)
                    {
                        x = false;
                        break;
                    }
                }
                check.Add(x);
            }
            return check;
        }
        public List<bool> Checkkh(List<hoadon> hd)
        {

            List<bool> check = new List<bool>(hd.Count);
            for (int i = 0; i < hd.Count; i++)
            {
                bool x = true;
                for (int j = 0; j < i; j++)
                {
                    if (hd[i].GMakh == hd[j].GMakh)
                    {
                        x = false;
                        break;
                    }
                }
                check.Add(x);
            }
            return check;
        }
        public List<bool> Checkhh(List<hoadon> hd)
        {

            List<bool> check = new List<bool>(hd.Count);
            for (int i = 0; i < hd.Count; i++)
            {
                bool x = true;
                for (int j = 0; j < i; j++)
                {
                    if (hd[i].GMahh == hd[j].GMahh)
                    {
                        x = false;
                        break;
                    }
                }
                check.Add(x);
            }
            return check;
        }
        public void ThongKeHd(int x, int y)
        {
            Console.Clear();
            HoaDonBLL hd = new HoaDonBLL();
            List<hoadon> dshd = hd.GetDataHD();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                                      THỐNG KÊ HÓA ĐƠN                                         |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───┬─────────┬─────────────────────┬──────────────────────┬──────────┬──────────┬──────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│STT|  mã HD  |      Tên KH         |       Tên NV         | Tên sp   |  sl(kg)  | Thành tiền   |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───┼─────────┼─────────────────────┼──────────────────────┼──────────┼──────────┼──────────────┤");
            double sum = 0;
            int z = y + 1;
            for (int i = 0; i < dshd.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0}", i + 1);
                Console.SetCursorPosition(x + 4, z);
                Console.WriteLine("|{0} ", dshd[i].GMahd);
                Console.SetCursorPosition(x + 14, z);
                Console.WriteLine("|{0} ", dshd[i].GTenkh);
                Console.SetCursorPosition(x + 36, z);
                Console.WriteLine("|{0} ", dshd[i].GTennv);
                Console.SetCursorPosition(x + 59, z);
                Console.WriteLine("|{0} ", dshd[i].GTenhh);
                Console.SetCursorPosition(x + 70, z);
                Console.WriteLine("|{0} ", dshd[i].Gsl);
                Console.SetCursorPosition(x + 81, z);
                Console.WriteLine("|{0} ", dshd[i].Gtongtien);
                Console.SetCursorPosition(x + 96, z);
                Console.WriteLine("|");
                sum += dshd[i].Gtongtien;
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("├───┴─────────┴─────────────────────┴──────────────────────┴──────────┴──────────┴──────────────┤");
            Console.SetCursorPosition(x, z + 1);
            Console.WriteLine("|Số lượng hóa đơn:                                                          Tổng:               |");
            Console.SetCursorPosition(x + 20, z + 1);
            Console.WriteLine(dshd.Count);
            Console.SetCursorPosition(x + 81, z + 1);
            Console.WriteLine(sum);
            Console.SetCursorPosition(x, z + 2);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────────────────────────────┘");
        X: Console.SetCursorPosition(1, 1);
            Console.Write("Ấn esc để quay lại => ");
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                DA1.Presenasion.menu.mnHoaDon();
            }
            else
            {
                goto X;
                 
            }
        }
        public void Thongkengay()
        {
            do
            {
                
                DateTime dt;
                HoaDonBLL hd = new HoaDonBLL();
                Console.SetCursorPosition(4, 3); Console.WriteLine("┌──────────────────────────────────────────────────┐");
                Console.SetCursorPosition(4, 4); Console.WriteLine("|                  THỐNG KÊ DOANH THU              |");
                Console.SetCursorPosition(4, 5); Console.WriteLine("├──────────────────────────────────────────────────┤");
                Console.SetCursorPosition(4, 6); Console.WriteLine("| Nhập ngày thống kê:                  (dd/MM/yyyy)|");
                Console.SetCursorPosition(4, 7); Console.WriteLine("| -------------------------------------------------|");
                Console.SetCursorPosition(4, 8); Console.WriteLine("|                                            (vnđ) |");
                Console.SetCursorPosition(4, 9); Console.WriteLine("|                                                  |");
                Console.SetCursorPosition(4, 10); Console.WriteLine("└──────────────────────────────────────────────────┘");
           x:   try
                {
                    do
                    {
                        
                        Console.SetCursorPosition(25, 6); dt = DateTime.Parse(Console.ReadLine());
                        if (hd.Checkngay(dt))
                        {
                            Console.SetCursorPosition(6, 8); Console.WriteLine("Doanh thu ngày(          ) là:");
                            Console.SetCursorPosition(21, 8); Console.WriteLine(dt.ToString("dd/MM/yyyy"));
                            Console.SetCursorPosition(36, 8); Console.WriteLine(hd.Doanhthungay(dt));
                            break;
                        }
                        else
                            DA1.TienIch.tienich.Xoadong(4, 12);
                            Console.SetCursorPosition(4, 12); Console.Write("Ngày bạn nhập không tồn tại vui lòng thử lại.");
                    } while (true);
                }
                catch(Exception ex)
                {
                    DA1.TienIch.tienich.Xoadong(4, 12);
                    Console.SetCursorPosition(4, 12); Console.Write(ex.Message+"Nhấn enter để nhập lại: ");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Enter)
                    {
                        goto x;
                    }
                }
                DA1.TienIch.tienich.Xoadong(4, 12);
                Console.SetCursorPosition(4, 1); Console.Write("Nhấn enter để nhập lại esc để thoát => ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnthongkedoanhthu();
                }
                DA1.TienIch.tienich.Xoadong(4, 1);
            } while (true);
        }
        public void Thongkethang()
        {
            do
            {
                Console.Clear();
                int month, year;
                HoaDonBLL hd = new HoaDonBLL();
                Console.SetCursorPosition(4, 3); Console.WriteLine("┌──────────────────────────────────────────────────┐");
                Console.SetCursorPosition(4, 4); Console.WriteLine("|                  THỐNG KÊ DOANH THU              |");
                Console.SetCursorPosition(4, 5); Console.WriteLine("├──────────────────────────────────────────────────┤");
                Console.SetCursorPosition(4, 6); Console.WriteLine("| Nhập tháng thống kê:       năm:                  |");
                Console.SetCursorPosition(4, 7); Console.WriteLine("| -------------------------------------------------|");
                Console.SetCursorPosition(4, 8); Console.WriteLine("|                                            (vnđ) |");
                Console.SetCursorPosition(4, 9); Console.WriteLine("|                                                  |");
                Console.SetCursorPosition(4, 10); Console.WriteLine("└──────────────────────────────────────────────────┘");
            x: try
                {
                    do
                    {

                        Console.SetCursorPosition(26, 6); month = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(37, 6); year = int.Parse(Console.ReadLine());
                        if (hd.Checkthang(month, year))
                        {
                            Console.SetCursorPosition(6, 8); Console.WriteLine("Doanh thu tháng(  /    ) là:");
                            Console.SetCursorPosition(23, 8); Console.WriteLine(month);
                            Console.SetCursorPosition(25, 8); Console.WriteLine(year);
                            Console.SetCursorPosition(36, 8); Console.WriteLine(hd.Doanhthuthang(month, year));
                            break;
                        }
                        else
                            DA1.TienIch.tienich.Xoadong(4, 12);
                        Console.SetCursorPosition(4, 12); Console.Write("Tháng bạn nhập không tồn tại vui lòng thử lại.");
                    } while (true);
                }
                catch (Exception ex)
                {
                    DA1.TienIch.tienich.Xoadong(4, 12);
                    Console.SetCursorPosition(4, 12); Console.Write(ex.Message + "Nhấn enter để nhập lại: ");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Enter)
                    {
                        goto x;
                    }
                }
                DA1.TienIch.tienich.Xoadong(4, 12);
                Console.SetCursorPosition(4, 1); Console.Write("Nhấn enter để nhập lại esc để thoát => ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnthongkedoanhthu();
                }
                DA1.TienIch.tienich.Xoadong(4, 12);
            } while (true);
        }
    }
}
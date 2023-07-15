using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA1.Business;
using DA1.KhaiBao;

namespace DA1.Presenasion
{
    class cnhoadonnhap
    {
        public void Nhap(int x, int y)
        {
            do
            {
                Console.Clear();
                HoaDonNhapBLL hd = new HoaDonNhapBLL();
                hoadonnhap hdn = new hoadonnhap();
                hanghoaBLL hh = new hanghoaBLL();
                hanghoa dshh = new hanghoa();
                nhanvienBLL nv = new nhanvienBLL();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                     NHẬP THÔNG TIN HÓA ĐƠN NHẬP                   │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("│ Nhập mã hd:                                                       │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine("│ Mã nhân viên:                                                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine("│ Tên nhân viên:                                                    │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 8);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine("│ Ngày nhập(dd/mm/yyyy):                                            │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 11);
                Console.WriteLine("│ Mã hàng hóa:                                                      │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 12);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 13);
                Console.WriteLine("│ Tên hàng hóa:                                                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 14);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 15);
                Console.WriteLine("│ Xuất xứ:                                                          │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 16);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 17);
                Console.WriteLine("│ Số lượng:                                                         │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 18);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 19);
                Console.WriteLine("│ Giá:                                                              │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 20);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y + 23);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(x, y + 24);
            x: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 13, y + 3);
                        hdn.MaHD = Console.ReadLine().Trim();
                        if (hdn.MaHD == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDonNhap();
                        }
                        else if (hd.CheckMahd(hdn.MaHD))
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x, y + 21);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã hóa đơn đã tồn tại vui lòng thử lại mã khác.");
                        }
                        else if (TienIch.tienich.Checkdodaichu(hdn.MaHD, 10) == false)
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x, y + 21);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Tối đa 10 kí tự");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(x, y + 21);
            y: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 15, y + 5);
                        hdn.MaNV = Console.ReadLine().Trim();
                        if (!nv.CheckMaNv(hdn.MaNV))
                        {
                            TienIch.tienich.Xoadong(x, y + 21);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã nhân viên bạn nhập không tồn tại .");
                        }
                        else if (hdn.MaNV == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDonNhap();
                        }

                        else
                        {
                            break;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                Console.SetCursorPosition(x + 16, y + 7);
                Console.WriteLine(nv.Gtennv(hdn.MaNV));
                hdn.TenNV = nv.Gtennv(hdn.MaNV);
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x, y + 21);
            m: Console.SetCursorPosition(x + 24, y + 9);
                try
                {
                    hdn.Ngay = DateTime.Parse(Console.ReadLine());
                    dshh.Ngay = hdn.Ngay;
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x, y + 21);
            e: try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 14, y + 11);
                        hdn.MaHH = Console.ReadLine().Trim();
                        if (hdn.MaHH == "0")
                        {
                            Console.Clear();
                            menu.mnHoaDonNhap();
                        }
                        else if (hh.CheckMa(hdn.MaHH))
                        {
                            break;
                        }
                        else
                        {
                            dshh.Ma = hdn.MaHH;
                            break;
                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x, y + 21);
            z:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 15, y + 13);
                        if (hh.CheckMa(hdn.MaHH))
                        {
                            Console.Write(hh.Gettenhh(hdn.MaHH));
                            hdn.TenHH = hh.Gettenhh(hdn.MaHH);
                            break;
                        }
                        else
                        {
                            hdn.TenHH = Console.ReadLine();
                            if (hdn.TenHH == "0")
                            {
                                Console.Clear();
                                menu.mnHoaDonNhap();
                            }
                            dshh.Ten = hdn.TenHH;
                            break;
                        }

                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(x, y + 21);
            g:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 10, y + 15);
                        if (hh.CheckMa(hdn.MaHH))
                        {
                            Console.Write(hh.GXXu(hdn.MaHH));
                            hdn.XuatXu = hh.GXXu(hdn.MaHH);
                            break;
                        }
                        else
                        {
                            hdn.XuatXu = Console.ReadLine();
                            if (hdn.XuatXu == "0")
                            {
                                Console.Clear();
                                menu.mnHoaDonNhap();
                            }
                            dshh.Xuatxu = hdn.XuatXu;
                            break;
                        }

                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(x, y + 21);
            f:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 11, y + 17);
                        hdn.SL = double.Parse(Console.ReadLine());
                        if (hdn.SL == 0)
                        {
                            Console.Clear();
                            menu.mnHoaDonNhap();
                        }
                        else if (hdn.SL < 0)
                        {
                            TienIch.tienich.Xoadong(x, y + 21);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >=0");
                        }
                        else if (hh.CheckMa(hdn.MaHH))
                        {
                            break;
                        }
                        else dshh.SL = hdn.SL; break;
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
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
                TienIch.tienich.Xoadong(x, y + 21);
            l:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 19);
                        if (hh.CheckMa(hdn.MaHH))
                        {
                            Console.Write(hh.GGia(hdn.MaHH));
                            hdn.Gia = hh.GGia(hdn.MaHH);
                            break;
                        }
                        else
                        {
                            hdn.Gia = double.Parse(Console.ReadLine());
                            if (hdn.Gia == 0)
                            {
                                Console.Clear();
                                menu.mnHoaDonNhap();
                            }
                            dshh.Gia = hdn.Gia;
                            break;
                        }

                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(x, y + 21);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto l;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x, y + 21);

                Console.SetCursorPosition(x, y + 22);
                Console.Write("Ấn Enter để thêm thông tin | Esc để quay lại ");
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                {
                    if (hh.CheckMa(hdn.MaHH))
                    {
                        hd.Updatesl(hdn);
                    }
                    else hh.Them(dshh);
                    hd.Them(hdn);
                }
                else if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnHoaDonNhap();
                }
            } while (true);
        }
        public void Hien(List<hoadonnhap> list, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                                        THÔNG TIN HÓA ĐƠN NHẬP                                          |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────┬───────┬────────────────────────────┬───────────┬───────┬────────┬─────────────┬──────┬─────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│ Mã HD | mã NV |       Tên NV nhập          | ngày nhập | Mã HH | Tên HH |   Xuất xứ   │sl(kg)| Đơn giá |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───────┼───────┼────────────────────────────┼───────────┼───────┼────────┼─────────────┼──────┼─────────┤");
            int z = y + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0} ", list[i].MaHD);
                Console.SetCursorPosition(x + 8, z);
                Console.WriteLine("|{0} ", list[i].MaNV);
                Console.SetCursorPosition(x + 16, z);
                Console.WriteLine("|{0} ", list[i].TenNV);
                Console.SetCursorPosition(x + 45, z);
                Console.WriteLine("|{0} ", list[i].Ngay.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(x + 57, z);
                Console.WriteLine("|{0} ", list[i].MaHH);
                Console.SetCursorPosition(x + 65, z);
                Console.WriteLine("|{0} ", list[i].TenHH);
                Console.SetCursorPosition(x + 74, z);
                Console.WriteLine("|{0} ", list[i].XuatXu);
                Console.SetCursorPosition(x + 88, z);
                Console.WriteLine("|{0} ", list[i].SL);
                Console.SetCursorPosition(x + 95, z);
                Console.WriteLine("|{0} ", list[i].Gia);
                Console.SetCursorPosition(x + 105, z);
                Console.WriteLine("|");
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└───────┴───────┴────────────────────────────┴───────────┴───────┴────────┴─────────────┴──────┴─────────┘");
        }
        public void Hien2(int x, int y)
        {
            HoaDonNhapBLL hd = new HoaDonNhapBLL();
            List<hoadonnhap> list = hd.GetDataHDN();
            Hien(list, x, y);
        }
        public void Xoa()
        {

            do
            {
                string ma;
                Console.Clear();
                HoaDonNhapBLL dshdn = new HoaDonNhapBLL();
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
                    if (ma == "0")
                    {
                        Console.Clear();
                        menu.mnHoaDonNhap();
                    }
                    else if (dshdn.CheckMahd(ma))
                    {
                        dshdn.Xoa(ma);
                        break;
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
            string masp = "";
            do
            {
                Console.Clear();

                HoaDonNhapBLL dshdn = new HoaDonNhapBLL();
                List<hoadonnhap> hd = dshdn.Tim(masp);
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập mã hóa đơn cần tìm:                                          |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.WriteLine("      Có thể tìm theo: mã hd, mã nv, tên nv, mã kh, ngày nhập(dd/mm/yyyy), mã hh, tên hh, xuất xứ");
                Console.ResetColor();
                Hien(hd, 5, 10);
                Console.SetCursorPosition(31, 2);
                masp = Console.ReadLine().Trim();
                if (masp == "0")
                {
                    Console.Clear();
                    menu.mnHoaDonNhap();
                }
            } while (true);
        }
    }
}

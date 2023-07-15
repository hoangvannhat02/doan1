using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.Presenasion
{
    //Nhập vào và sử dụng các chức năng của menu
    public class menu
    {
        public static void mnHangHoa()
        {
            DA1.Presenasion.cnhanghoa a = new DA1.Presenasion.cnhanghoa();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            QUẢN LÍ HÀNG HÓA                    |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("|1.Nhập thông tin hàng hóa                       |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("|2.Xóa thông tin hàng hóa                        |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("|3.Sửa thông tin hàng hóa                        |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("|4.Hiển thị thông tin hàng hóa                   |");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("|5.Tìm kiếm thông tin hàng hóa                   |");
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("|6.Quay lại Menu chính                           |");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        x: try
            {
                do
                {
                    Console.SetCursorPosition(12, 17);
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            a.Nhap();
                            break;
                        case 2:
                            a.Xoa();
                            break;
                        case 3:
                            a.Sua();
                            break;
                        case 4:
                            Console.Clear();
                            a.Hien2(4, 3);
                        y: Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(1, 1);
                            Console.Write("Note: Ấn esc để quay lại.");
                            Console.ResetColor();
                            ConsoleKeyInfo kt = Console.ReadKey();
                            if (kt.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                mnHangHoa();
                            }
                            else
                            {
                                goto y;
                            }
                            break;
                        case 5:
                            a.Tim();
                            break;
                        case 6:
                            Console.Clear();
                            DA1.Program.Hien();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 21);
                            Console.SetCursorPosition(8, 19);
                            Console.WriteLine("Chỉ có thể chọn từ 1->6");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 19);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 21);
                Console.Write(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto x;
            }
        }
        public static void mnKhachHang()
        {
            DA1.Presenasion.cnkhachhang c = new DA1.Presenasion.cnkhachhang();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            QUẢN LÍ KHÁCH HÀNG                  |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("|1.Nhập thông tin khách hàng                     |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("|2.Xóa thông tin khách hàng                      |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("|3.Tìm kiếm thông tin khách hàng                 |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("|4.Hiển thị thông tin khách hàng                 |");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("|5.Sửa thông tin hàng hóa                        |");
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("|6.Quay lại Menu chính                           |");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        y: try
            {
                do
                {
                    Console.SetCursorPosition(12, 17);
                    Console.Write("Chọn chức năng: ");
                    int kt = int.Parse(Console.ReadLine());
                    switch (kt)
                    {
                        case 1:
                            c.Nhap(0, 3);
                            break;
                        case 2:
                            c.Xoa();
                            break;
                        case 3:
                            c.Tim();
                            break;
                        case 4:
                            Console.Clear();
                            c.Hien2(4, 3);
                        z: Console.SetCursorPosition(1, 1);
                            Console.Write("Ấn esc để quay lại: ");
                            ConsoleKeyInfo check = Console.ReadKey();
                            if (check.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                mnKhachHang();
                            }
                            else
                            {
                                goto z;
                            }
                            break;
                        case 5:
                            c.Sua();
                            break;
                        case 6:
                            Console.Clear();
                            DA1.Program.Hien();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 21);
                            Console.SetCursorPosition(8, 19);
                            Console.WriteLine("Chỉ có thể chọn từ 1->6");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 19);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 21);
                Console.WriteLine(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto y;
            }
        }
        public static void mnNhanVien()
        {
            DA1.Presenasion.cnnhanvien b = new DA1.Presenasion.cnnhanvien();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            QUẢN LÍ NHÂN VIÊN                   |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("|1.Nhập thông tin nhân viên                      |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("|2.Xóa thông tin nhân viên                       |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("|3.Tìm kiếm thông nhân viên                      |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("|4.Hiển thị thông tin nhân viên                  |");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("|5.Sửa thông tin nhân viên                       |");
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("|6.Thống kê lương nhân viên                      |");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 17);
            Console.WriteLine("|7.Quay lại Menu chính                           |");
            Console.SetCursorPosition(8, 18);
            Console.WriteLine("└────────────────────────────────────────────────┘");

        z: try
            {
                do
                {
                    Console.SetCursorPosition(8, 19);
                    Console.Write("Chọn chức năng: ");
                    int check = int.Parse(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            b.Nhap(4, 3);
                            break;
                        case 2:
                            b.Xoa();
                            break;
                        case 3:
                            b.Tim();
                            break;
                        case 4:
                            Console.Clear();
                            b.Hien2(4, 3);
                        m: Console.SetCursorPosition(1, 1);
                            Console.Write("Ấn esc để quay lại: ");
                            ConsoleKeyInfo ktra = Console.ReadKey();
                            if (ktra.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                mnNhanVien();
                            }
                            else
                            {
                                goto m;
                            }
                            break;
                        case 5:
                            b.Sua();
                            break;
                        case 7:
                            DA1.Program.Hien();
                            break;
                        case 6:
                            b.TinhLuong(4, 3);
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 23);
                            Console.SetCursorPosition(8, 21);
                            Console.WriteLine("Chỉ có thể chọn từ 1->7");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 21);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 23);
                Console.WriteLine(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto z;
            }
        }
        public static void mnHoaDon()
        {
            DA1.Presenasion.cnhoadon hd = new cnhoadon();

            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            HÓA ĐƠN XUẤT                |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("|                                        |");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("| 1.Nhập thông tin hóa đơn               |");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("├────────────────────────────────────────┤ ");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("| 2.Hiển thị hóa đơn                     |");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("| 3.Xóa thông tin hóa đơn                |");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("| 4.Tìm thông tin hóa đơn                |");
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("| 5.Xuất hóa đơn                         |");
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("| 6.Thống kê hóa đơn                     |");
            Console.SetCursorPosition(8, 17);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 18);
            Console.WriteLine("| 7.Quay lại                             |");
            Console.SetCursorPosition(8, 19);
            Console.WriteLine("└────────────────────────────────────────┘ ");
            Console.WriteLine();
        m: try
            {
                do
                {
                    Console.SetCursorPosition(8, 21);
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            hd.Nhap(0, 3);
                            break;
                        case 2:
                            Console.Clear();
                            hd.Hien2(1, 3);
                        x: Console.SetCursorPosition(1, 1);
                            Console.Write("Ấn esc để quay lại: ");
                            ConsoleKeyInfo ktra = Console.ReadKey();
                            if (ktra.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                mnHoaDon();
                            }
                            else
                            {
                                goto x;
                            }
                            break;
                        case 3:
                            hd.Xoa();
                            break;
                        case 4:
                            hd.Tim();
                            break;
                        case 5:
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Note: ấn esc để quay lại ");
                            hd.Xuat2();
                            break;
                        case 6:
                            hd.ThongKeHd(4, 3);
                            break;
                        case 7:
                            Console.Clear();
                            DA1.Presenasion.menu.mnHD();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 23);
                            Console.SetCursorPosition(8, 23);
                            Console.WriteLine("Chỉ có thể chọn từ 1->7");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 23);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 23);
                Console.WriteLine(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto m;
            }
        }
        public static void mnHD()
        {
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|                QUẢN LÝ HÓA ĐƠN                 |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("| 1.QUẢN LÝ HÓA ĐƠN NHẬP                         |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("| 2.QUẢN LÝ HÓA ĐƠN XUẤT                         |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("| 3.Quay lại                                     |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        x: try
            {
                do
                {
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            Console.Clear();
                            mnHoaDonNhap();
                            break;
                        case 2:
                            Console.Clear();
                            mnHoaDon();
                            break;
                        case 3:
                            Console.Clear();
                            DA1.Program.Hien();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 14);
                            Console.SetCursorPosition(8, 14);
                            Console.WriteLine("Chỉ có thể chọn từ 1->3");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 14);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 14);
                Console.Write(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto x;
            }
        }
        public static void mnHoaDonNhap()
        {
            DA1.Presenasion.cnhoadonnhap hdn = new cnhoadonnhap();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            HÓA ĐƠN NHẬP                |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("|                                        |");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("| 1.Nhập thông tin hóa đơn               |");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("| 2.Xóa thông tin hóa đơn                |");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("├────────────────────────────────────────┤ ");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("| 3.Hiển thị thông tin hóa đơn           |");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("├────────────────────────────────────────┤ ");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("| 4.Tìm thông tin hóa đơn                |");
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("| 5.Quay lại                             |");
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("└────────────────────────────────────────┘");
            Console.WriteLine();
        m: try
            {
                do
                {
                    Console.SetCursorPosition(8, 17);
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            hdn.Nhap(1, 2);
                            break;
                        case 2:
                            hdn.Xoa();
                            break;
                        case 3:
                            Console.Clear();
                            hdn.Hien2(1, 4);
                        n: Console.SetCursorPosition(1, 1);
                            Console.Write("Ấn esc để quay lại: ");
                            ConsoleKeyInfo ktra = Console.ReadKey();
                            if (ktra.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                mnHoaDonNhap();
                            }
                            else
                            {
                                goto n;
                            }
                            break;
                        case 4:
                            hdn.Tim();
                            break;

                        case 5:
                            Console.Clear();
                            DA1.Presenasion.menu.mnHD();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 19);
                            Console.SetCursorPosition(8, 19);
                            Console.WriteLine("Chỉ có thể chọn từ 1->5");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 19);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 19);
                Console.WriteLine(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto m;
            }
        }
        public static void mnThongKe()
        {
            DA1.Presenasion.cnhanghoa a = new cnhanghoa();
            DA1.Presenasion.cnhoadon c = new DA1.Presenasion.cnhoadon();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|                THỐNG KÊ                        |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("| 1.Thống kê hàng hóa                            |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("| 2.Thống kê nhân viên                           |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("| 3.Thống kê khách hàng                          |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("| 4.Quay lại                                     |");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        x: try
            {
                do
                {
                    Console.SetCursorPosition(8, 14);
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            mnThongkehh();
                            break;
                        case 2:
                            c.ThongKe(4, 3);
                            break;
                        case 3:
                            c.ThongKekh(4, 3);
                            break;
                        case 4:
                            Console.Clear();
                            DA1.Program.Hien();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 16);
                            Console.SetCursorPosition(8, 16);
                            Console.WriteLine("Chỉ có thể chọn từ 1->4");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 16);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 18);
                Console.Write(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto x;
            }
        }
        public static void mnThongkehh()
        {
            DA1.Presenasion.cnhanghoa a = new cnhanghoa();
            DA1.Presenasion.cnhoadon c = new DA1.Presenasion.cnhoadon();
        y: Console.Clear();
            Console.SetCursorPosition(8, 2);
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            THỐNG KÊ HÀNG HÓA                   |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("| 1.Thống kê hàng hóa sắp hết hàng               |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("| 2.Thống kê hàng hóa bán chạy nhất              |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("| 3.Thống kê doanh thu cửa hàng                  |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("| 4.Quay lại                                     |");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        x: try
            {
                do
                {
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Mời bạn chọn chức năng: ");
                    int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            Console.Clear();
                            a.ThongKe(8, 3);
                        m: Console.SetCursorPosition(8, 1);
                            Console.Write("Ấn esc để quay lại: ");
                            ConsoleKeyInfo n = Console.ReadKey();
                            if (n.Key == ConsoleKey.Escape)
                            {
                                goto y;
                            }
                            else
                            {
                                goto m;
                            }
                        case 2:
                            c.ThongKehh(4, 3);
                        n: Console.SetCursorPosition(8, 1);
                            Console.Write("Ấn esc để quay lại => ");
                            ConsoleKeyInfo kt = Console.ReadKey();
                            if (kt.Key == ConsoleKey.Escape)
                            {
                                goto y;
                            }
                            else
                            {
                                goto n;
                            }
                        case 3:
                            Console.Clear();
                            mnthongkedoanhthu();
                            break;
                        case 4:
                            Console.Clear();
                            mnThongKe();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 15);
                            Console.SetCursorPosition(8, 15);
                            Console.WriteLine("Chỉ có thể nhập giá trị từ 1->3.");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 15);
                Console.Write(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto x;
            }
        }
        public static void mnthongkedoanhthu()
        {
            DA1.Presenasion.cnhanghoa a = new cnhanghoa();
            DA1.Presenasion.cnhoadon c = new DA1.Presenasion.cnhoadon();
            Console.Clear();
            Console.SetCursorPosition(8, 2);
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|            THỐNG KÊ DOANH THU                  |");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("| 1.Thống kê doanh thu theo ngày                 |");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("| 2.Thống kê doanh thu theo tháng                |");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("| 3.Quay lại                                     |");
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        x:  try
            {
                do
                {
                    Console.SetCursorPosition(8, 11); Console.Write("Mời bạn chọn chức năng: ");
                    int check = int.Parse(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Console.Clear();
                            c.Thongkengay();
                            break;
                        case 2:
                            c.Thongkethang();
                            break;
                        case 3:
                            Console.Clear();
                            mnThongkehh();
                            break;
                        default:
                            DA1.TienIch.tienich.Xoadong(8, 13);
                            Console.SetCursorPosition(8, 13); Console.Write("Chỉ có thể nhập từ 1->3 ");
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                DA1.TienIch.tienich.Xoadong(8, 13);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(8, 13);
                Console.Write(ex.Message + "Ấn enter để nhập lại");
                Console.ResetColor();
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter)
                    goto x;
            }
        }
    }
}

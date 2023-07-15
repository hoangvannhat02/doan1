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
    class cnnhanvien
    {
        public void Nhap(int x, int y)
        {
            do
            {
                Console.Clear();
                INhanVien dsnv = new nhanvienBLL();
                nhanvien nv = new nhanvien();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("│                     NHẬP THÔNG TIN NHÂN VIÊN                      │");
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
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 15);
                Console.WriteLine("│ Phụ cấp:                                                          │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 16);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(x, y + 17);
                Console.WriteLine("│ Lương cơ bản:                                                     │");
                Console.WriteLine();
                Console.SetCursorPosition(x, y + 18);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y + 21);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(x, y + 22);
            x: try
                {

                    do
                    {
                        Console.SetCursorPosition(x + 5, y + 3);
                        nv.Ma = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(nv.Ma, 10) == false)
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài chữ tối đa 10 kí tự");
                        }
                        else if (dsnv.CheckMaNv(nv.Ma))
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Mã nhân viên bạn nhập đã tồn tại .");
                        }
                        else if (nv.Ma == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            break;
                        }

                    } while (dsnv.CheckMaNv(nv.Ma));
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            y: 
                try
                {
                    
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 5);
                        nv.Ten = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(nv.Ten, 30) == false)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tối đa là 30 kí tự");
                        }
                        else if (nv.Ten == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            z: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 7, y + 7);
                        nv.Tuoi = int.Parse(Console.ReadLine());
                        if (nv.Tuoi < 0)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Tuổi không hợp lệ");
                        }
                        else if (nv.Tuoi == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            e:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 20, y + 9);
                        nv.Gt = Console.ReadLine();
                        if (nv.Gt == "Nam" || nv.Gt == "Nu")
                        {
                            break;
                        }
                        else if (nv.Gt == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            goto e;
                        }
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            f: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 11, y + 11);
                        nv.Que = Console.ReadLine();
                        if (TienIch.tienich.Checkdodaichu(nv.Que, 15) == false)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Độ dài tối đa là 15 kí tự");
                        }
                        else if (nv.Que == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            g: 
                try
                {
                    Console.SetCursorPosition(x + 6, y + 13);
                    nv.SDT = Console.ReadLine();
                    Regex r = new Regex(@"^((0)\d{9})$");
                    do
                    {
                        Console.SetCursorPosition(x + 6, y + 13);
                        nv.SDT = Console.ReadLine();
                        if (r.IsMatch(nv.SDT))
                        {
                            break;
                        }
                        else if (nv.SDT == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(1, 1);
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("sđt nhập không hợp lệ");
                        }

                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
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
                TienIch.tienich.Xoadong(x + 40, y + 19);
            h: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 10, y + 15);
                        nv.PC = double.Parse(Console.ReadLine());
                        if (nv.PC == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else if (nv.PC < 0)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >0");
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto h;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 19);
            i: 
                try
                {
                    do
                    {
                        Console.SetCursorPosition(x + 15, y + 17);
                        nv.LCB = double.Parse(Console.ReadLine());
                        if (nv.LCB == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else if (nv.LCB < 0)
                        {
                            TienIch.tienich.Xoadong(x + 40, y + 19);
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("Giá trị nhập phải >0");
                        }
                        else break;
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(x + 40, y + 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "Ấn Enter đẻ nhập lại.");
                    Console.ResetColor();
                    ConsoleKeyInfo check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Enter)
                    {
                        goto i;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(1, 1);
                TienIch.tienich.Xoadong(x + 40, y + 19);

                Console.SetCursorPosition(x + 10, y + 20);
                Console.Write("Ấn Enter để thêm thông tin | Esc để quay lại:");
                Console.SetCursorPosition(x + 56, y + 20);

                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Enter) { dsnv.Them(nv); }
                else if (kt.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnNhanVien();
                }
            } while (true);
        }
        public void Hien2(int x,int y)
        {

            INhanVien dsnv = new nhanvienBLL();
            List<nhanvien> listnv = dsnv.GetDataNV();
            Hiennv(listnv,x,y);

        }
        public void Hiennv(List<nhanvien> list,int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                                       THÔNG TIN NHÂN VIÊN                                          |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────┬────────────────────┬──────┬───────────┬──────────────┬────────────┬───────────┬──────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│  Ma nv  |      Họ tên        | Tuổi | Giới tính │   Quê quán   |    SDT     |  Phụ cấp  |   LCB    |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├─────────┼────────────────────┼──────┼───────────┼──────────────┼────────────┼───────────┼──────────┤"); 
            int z = y + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0} ", list[i].Ma);
                Console.SetCursorPosition(x + 10, z);
                Console.WriteLine("|{0} ", list[i].Ten);
                Console.SetCursorPosition(x + 31, z);
                Console.WriteLine("|{0} ", list[i].Tuoi);
                Console.SetCursorPosition(x + 38, z);
                Console.WriteLine("|{0} ", list[i].Gt);
                Console.SetCursorPosition(x + 50, z);
                Console.WriteLine("|{0} ", list[i].Que);
                Console.SetCursorPosition(x + 65, z);
                Console.WriteLine("|{0} ", list[i].SDT);
                Console.SetCursorPosition(x + 78, z);
                Console.WriteLine("|{0} ", list[i].PC);
                Console.SetCursorPosition(x + 90, z);
                Console.WriteLine("|{0} ", list[i].LCB);
                Console.SetCursorPosition(x + 101, z);
                Console.WriteLine("|");
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("└─────────┴────────────────────┴──────┴───────────┴──────────────┴────────────┴───────────┴──────────┘");
        }
        public void Xoa()
        {
            string ma = null;
            do
            {
                Console.Clear();
                INhanVien dsnv = new nhanvienBLL();
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("| Nhập mã nhân viên cần xóa:                                        |");
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("Note: Nhập ma = 0 và ấn enter để quay lại.");
                Console.ResetColor();
                Hien2(5,10);
                do
                {
                    Console.SetCursorPosition(33, 2);
                    ma = Console.ReadLine().Trim();
                    if (dsnv.CheckMaNv(ma))
                    {
                        dsnv.Xoa(ma);
                        break;
                    }
                    else if (ma == "0")
                    {
                        Console.Clear();
                        DA1.Presenasion.menu.mnNhanVien();
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
        public void Sua()
        {
            do
            {
                Console.Clear();
                nhanvien nv = new nhanvien();
                nhanvienBLL dsnv = new nhanvienBLL();
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("|               Nhập thông tin nhân viên mới                        |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("├───────────────────────────────────────────────────────────────────┤");
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("| Mã:          Tên:                    Tuổi:       GT(Nam|Nu):      |");
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("| Quê quán:               SDT:                 Phụ cấp:             |");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("| Lương cơ bản:                                                     |");
                Console.SetCursorPosition(10, 7);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Hien2(10,12);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("Note: nhập 0 và ấn enter để quay lại.");
                Console.ResetColor();
            x: try
                {

                    do
                    {
                        Console.SetCursorPosition(15, 4);
                        nv.Ma = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(nv.Ma, 10) == false)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Độ dài chữ tối đa 10 kí tự");
                        }
                        else if (dsnv.CheckMaNv(nv.Ma))
                        {
                            break;
                        }
                        else if (nv.Ma == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Mã nhân viên bạn nhập không tồn tại.");
                        }

                    } while (dsnv.CheckMaNv(nv.Ma));
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
                        goto x;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            y:
                try
                {

                    do
                    {
                        Console.SetCursorPosition(29, 4);
                        nv.Ten = Console.ReadLine().Trim();
                        if (TienIch.tienich.Checkdodaichu(nv.Ten, 30) == false)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Độ dài tối đa là 30 kí tự");
                        }
                        else if (nv.Ten == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
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
                        Console.SetCursorPosition(54, 4);
                        nv.Tuoi = int.Parse(Console.ReadLine());
                        if (nv.Tuoi < 1)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Tuổi không hợp lệ");
                        }
                        else if (nv.Tuoi == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
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
                        Console.SetCursorPosition(72, 4);
                        nv.Gt = Console.ReadLine();
                        if (nv.Gt == "Nam" || nv.Gt == "Nu")
                        {
                            break;
                        }
                        else if (nv.Gt == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            goto e;
                        }
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
                        Console.SetCursorPosition(21, 5);
                        nv.Que = Console.ReadLine();
                        if (TienIch.tienich.Checkdodaichu(nv.Que, 15) == false)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Độ dài tối đa là 15 kí tự");
                        }
                        else if (nv.Que == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
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
                        goto f;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            g:
                try
                {
                    
                    nv.SDT = Console.ReadLine();
                    Regex r = new Regex(@"^((0)\d{9})$");
                    do
                    {
                        Console.SetCursorPosition(40, 5);
                        nv.SDT = Console.ReadLine();
                        if (r.IsMatch(nv.SDT))
                        {
                            break;
                        }
                        else if (nv.SDT == "0")
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("sđt nhập không hợp lệ");
                        }

                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message+ "Ấn Enter đẻ nhập lại.");
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
            h:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(65, 5);
                        nv.PC = double.Parse(Console.ReadLine());
                        if (nv.PC == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else if (nv.PC < 0)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Giá trị nhập phải >0");
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
                        goto h;
                    }
                    else
                        return;
                }
                TienIch.tienich.Xoadong(10, 0);
            i:
                try
                {
                    do
                    {
                        Console.SetCursorPosition(25, 6);
                        nv.LCB = double.Parse(Console.ReadLine());
                        if (nv.LCB == 0)
                        {
                            Console.Clear();
                            DA1.Presenasion.menu.mnNhanVien();
                        }
                        else if (nv.LCB < 0)
                        {
                            TienIch.tienich.Xoadong(10, 0);
                            Console.SetCursorPosition(10, 0);
                            Console.WriteLine("Giá trị nhập phải >0");
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
                        goto i;
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
                    DA1.Presenasion.menu.mnNhanVien();
                }else if(kt.Key==ConsoleKey.Enter) dsnv.Sua(nv);

            } while (true);
        }
        public void Tim()
        {
            string x = "";
            do
            {
                Console.Clear();
                nhanvienBLL dsnv = new nhanvienBLL();
                List<nhanvien> nv = dsnv.TimKiem(x);
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("| Nhập thông tin cần tìm:                                           |");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("Note: Nhập 0 và ấn enter để quay lại.");
                Console.WriteLine("                Có thể tìm theo: mã, tên, quê quán, số điện thoại.");
                Console.ResetColor();
                Hiennv(nv,10,10);

                Console.SetCursorPosition(35, 2);
                x = Console.ReadLine().Trim();
                if (x == "0")
                {
                    Console.Clear();
                    DA1.Presenasion.menu.mnNhanVien();
                }

            } while (true);
        }
        public void TinhLuong(int x,int y  )
        {
            Console.Clear();
            nhanvienBLL dsnv = new nhanvienBLL();
            List<nhanvien> list = dsnv.GetDataNV();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("|                      THỐNG KÊ LƯƠNG NHÂN VIÊN                             |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───┬─────────┬────────────────────┬────────────┬──────────┬────────────────┤");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("│STT|  Ma nv  |      Họ tên        |   Phụ cấp  |   LCB    |     Lương      |");
            Console.SetCursorPosition(x, y += 1);
            Console.WriteLine("├───┼─────────┼────────────────────┼────────────┼──────────┼────────────────┤");
            double sum = 0;
            int z = y + 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(x, z);
                Console.WriteLine("|{0}",i+1);
                Console.SetCursorPosition(x+4, z);
                Console.WriteLine("|{0} ", list[i].Ma);
                Console.SetCursorPosition(x + 14, z);
                Console.WriteLine("|{0} ", list[i].Ten);
                Console.SetCursorPosition(x + 35, z);
                Console.WriteLine("|{0} ", list[i].PC);
                Console.SetCursorPosition(x + 48, z);
                Console.WriteLine("|{0} ", list[i].LCB);
                Console.SetCursorPosition(x + 59, z);
                Console.WriteLine("|{0} ", list[i].TinhLuong());
                Console.SetCursorPosition(x + 76, z);
                Console.WriteLine("|");
                sum += list[i].TinhLuong();
                z++;
            }
            Console.SetCursorPosition(x, z);
            Console.WriteLine("├───┴─────────┴────────────────────┴────────────┴──────────┴────────────────┤");
            Console.SetCursorPosition(x, z+1);
            Console.WriteLine("|Số lượng nhân viên:                                  Tổng:                 |");
            Console.SetCursorPosition(x + 20, z+1);
            Console.WriteLine(list.Count);
            Console.SetCursorPosition(x + 60, z + 1);
            Console.WriteLine(sum);
            Console.SetCursorPosition(x, z+2);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────────┘");
         X: Console.SetCursorPosition(1, 1);
            Console.Write("Ấn esc để quay lại => ");
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                DA1.Presenasion.menu.mnNhanVien();
            }
            else
            {
                goto X;
            }
        }
    }
}

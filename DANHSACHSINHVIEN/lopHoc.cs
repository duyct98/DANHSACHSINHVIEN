using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHSINHVIEN
{
    internal class lopHoc
    {
        public string malop { get; set; }
        public string mota { get; set; }
        public string giangvien { get; set; }
        public string thoigian { get; set; }
        public string ngayhoc { get; set; }
        public string data { get; set; }
        public static void themlop(ref loplist headlop)
        {
            lopHoc lop = new lopHoc();
            
            Console.Write("- Nhap ma lop: ");
            lop.malop = Console.ReadLine();
            Console.Write("- Nhap mo ta lop: ");
            lop.mota = Console.ReadLine();
            Console.Write("- Nhap giang vien: ");
            lop.giangvien = Console.ReadLine();
            Console.Write("- Nhap thoi gian hoc: ");
            lop.thoigian = Console.ReadLine();
            Console.Write("- Nhap ngay hoc ");
            lop.ngayhoc = Console.ReadLine();

            loplist nodenew = new loplist(lop, null);

            
            loplist p = headlop;

            if (headlop == null)
            {

                headlop = nodenew;

            }
            else
            {
                while (p.next != null)
                {

                    p = p.next;
                }
                p.next = nodenew;

            }
            
        }

        public static void xuatThongTin(loplist headlop)
        {
            loplist p = headlop;
            int i = 1;
            Console.WriteLine("{0,-10}{1,-25}{2,-30}{3,-25}{4,-10} \n", "Ma lop", "Mo ta", "Giang vien", "Gio hoc", "Ngay hoc");
            if (headlop == null)
            {
                Console.WriteLine("Danh sach trong !!!");
            }
            else
                while (p != null)
                {

                    Console.WriteLine("{0,-10}{1,-25}{2,-30}{3,-25}{4,-10}", p.data.malop, p.data.mota, p.data.giangvien, p.data.thoigian, p.data.ngayhoc);

                    p = p.next;
                    i++;
                }


        }
    }
    
}

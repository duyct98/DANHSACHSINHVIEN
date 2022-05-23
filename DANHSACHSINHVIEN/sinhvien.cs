using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHSINHVIEN
{
    internal class sinhvien
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string diaChi { get; set; }
        public string ngaySinh { get; set; }
        public string maLop { get; set; }
        public string data { get; set; }

        public static void capnhatthongtin(ref svlist head)
        {
            svlist p = head;
            Console.Write("- Nhap ma sinh vien: ");
            string nhap = Console.ReadLine();
            while (p != null)
            {
                if (nhap == p.data.ma)
                {

                    sinhvien sv = new sinhvien();
                    svlist b = new svlist(sv, null);
                    Console.Write("- Sua ten sinh vien: ");
                    b.data.ten = Console.ReadLine();
                    Console.Write("- Sua dia chi: ");
                    b.data.diaChi = Console.ReadLine();
                    Console.Write("- Sua ngay sinh: ");
                    b.data.ngaySinh = Console.ReadLine();
                    Console.Write("- Sua ma lop: ");
                    b.data.maLop = Console.ReadLine();
                    Console.WriteLine("Ban co muon cap nhat thong tin?(Y/N): ");
                    string xacnhan = Console.ReadLine();
                    if (xacnhan == "Y" || xacnhan == "y")
                    {
                        Console.Write("Thong tin da duoc cap nhat !!");
                        b.next = p.next;
                        b.data.ma = p.data.ma;
                        p.data = b.data;
                    }
                    break;
                }
                p = p.next;
            }

        }

        public static void xuatThongTin(svlist head)
        {
            svlist p = head;
            int i = 1;
            Console.WriteLine("{0,-10}{1,-25}{2,-30}{3,-25}{4,-10} \n", "Ma SV", "Ho ten", "Dia Chi", "Ngay sinh", "Ma lop");
            if (head == null)
            {
                Console.WriteLine("Danh sach trong !!!");
            }
            else
                while (p != null)
                {

                    Console.WriteLine("{0,-10}{1,-25}{2,-30}{3,-25}{4,-10}", p.data.ma, p.data.ten, p.data.diaChi, p.data.ngaySinh, p.data.maLop);

                    p = p.next;
                    i++;
                }


        }

        public static svlist themSinhVien(ref svlist head)
        {
            sinhvien sv = new sinhvien();
            Console.Write("- Nhap ma sinh vien: ");
            sv.ma = Console.ReadLine();
            Console.Write("- Nhap ten sinh vien: ");
            sv.ten = Console.ReadLine();
            Console.Write("- Nhap dia chi: ");
            sv.diaChi = Console.ReadLine();
            Console.Write("- Nhap ngay sinh: ");
            sv.ngaySinh = Console.ReadLine();
            Console.Write("- Nhap ma lop: ");
            sv.maLop = Console.ReadLine();



            svlist nodenew = new svlist(sv, null);
            svlist p = head;

            if (head == null)
            {

                head = nodenew;

            }
            else
            {
                while (p.next != null)
                {

                    p = p.next;
                }
                p.next = nodenew;

            }


            return head;
        }
    }
}

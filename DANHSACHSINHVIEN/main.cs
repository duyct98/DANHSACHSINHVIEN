using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHSINHVIEN
{
    
    
    internal class Program
    {
        public static svlist head = null;
        public static int chon;
            
        public static void menu()
        {
            
            
            
           

            Console.Write("---Chao mung den voi VTC Academy ---\n");
            Console.Write("\n====================================\n");
            Console.Write("1. Quan ly danh sach sinh vien\n2. Quan ly lop hoc\n3. Quan ly diem thi\n0. Thoat\n");
            
        }
        public static void danhSachSinhVien()
        {
            
            Console.Write("\n====================================\n");
            Console.Write("1. Xem danh sach sinh vien\n2. Cap nhat thong tin sinhh vien\n3. Them moi mot sinh vien\n0. Tro ve meu chinh\n");
            
        }

        public static void luachon(ref int chon)
        {

            Console.Write("#Chon: ");
            chon = Convert.ToInt32(Console.ReadLine());
            while (chon > 3 || chon<0 )
            {
                Console.Write("#Chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                
            }
            

        }
        
        
        
        static void Main(string[] args)
        {
            svlist head=null;
            loplist headlop = null;
            chonlai:
            menu();
            luachon(ref chon);
            switch (chon)
            {
                case 1:
                    Console.Clear();
                    
                    danhSachSinhVien();
                    chonlai1:
                    luachon(ref chon);
                    switch (chon)
                    {
                        case 1:
                            sinhvien.xuatThongTin(head);
                            goto chonlai1;
                        case 2:
                            sinhvien.capnhatthongtin(ref head);
                            goto chonlai1;
                        case 3:
                            sinhvien.themSinhVien(ref head);
                            goto chonlai1;
                        case 0:
                            Console.Clear();
                            goto chonlai;

                    }
                    break;
                case 2:
                    lopHoc.themlop(ref headlop);
                    goto chonlai;
                    
                case 3:
                    luachon(ref chon);
                    goto chonlai;
                    
                case 0:
                    break;
            }










            

            


            Console.ReadKey();
        }

    }
}

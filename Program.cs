using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            // tao mang doi tuong Sv
            SV[] sinhvien = new SV[n];
            for (int i = 0; i < n; i++)
            {
                sinhvien[i] = new SV();
                sinhvien[i].nhapthongtin();
                sinhvien[i].tinhTb();
                sinhvien[i].In();
            }
            // tim ra sinh vien nao co diem tung binh thap nhap
            float min = sinhvien[0].tinhTb();
            for (int i = 1; i < n; i++)
            {
                if (sinhvien[i].tinhTb() < min) min = sinhvien[i].tinhTb();
            }
            Console.WriteLine("SV co diem thap nhat la {0}", min);
            //tim ra sinh vien co chua chu 18I
            for (int i = 0; i < n; i++)
            {
                if (sinhvien[i].maSV.Contains("18IT"))
                    Console.WriteLine("SV ma{0} co diem  Tb la {1} co chua chu 18IT", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            // sap xep mang sv theo diem tb tang dan
            SV tmp;
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < n; j++)
                        if (sinhvien[i].tinhTb() > sinhvien[j].tinhTb())
                        {
                            tmp = sinhvien[i];
                            sinhvien[i] = sinhvien[j];
                            sinhvien[j] = tmp;
                        }
                }
            }

            Console.WriteLine("sinh vien sap xep theo thu tu giam dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien ma{0} co diem tb {1} ", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            Console.ReadLine();
        }
    }
}

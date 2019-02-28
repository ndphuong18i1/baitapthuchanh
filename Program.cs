using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // bai 1
            Class1 tong = new Class1();
            tong.nhapn();
            tong.tinhTong();
            tong.inTong();
            tong.tinhTong2();
            tong.tinhTong3();
            tong.tongUoc();

            //bai2
            tientau tau = new tientau();
            tau.nhapthongtin();
            tau.tinhtien();
            tau.Intau();
            Console.ReadLine();
        }
    }
}

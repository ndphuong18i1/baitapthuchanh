using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class tientau
    {
        int soluong;
        String matau;
        public void nhapthongtin()
        {
            Console.WriteLine("nhap ma tau");
            this.matau = Console.ReadLine();
            Console.WriteLine("nhap so luong");
            this.soluong = Convert.ToInt32(Console.ReadLine());

        }
        public float tinhtien()
        {
            float S = 0;
            if (this.soluong < 100)
            {
                S = this.soluong * 100000;
            }
            else
            {
                S = this.soluong * 80000;
            }
            return S;
        }
        public void Intau()
        {
            Console.WriteLine(this.matau);
            Console.WriteLine(this.matau);
            Console.WriteLine(tinhtien());
            Console.WriteLine("tong tien la");
        }
    }
}

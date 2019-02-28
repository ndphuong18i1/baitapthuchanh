using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        int n;
        public void nhapn()
        {
            Console.WriteLine("Nhap n: ");
            this.n = Convert.ToInt32(Console.ReadLine());

        }

        public float tinhTong()
        {
            float S1 = 0;
            float S2 = 0;

            for (int i = 1; i <= this.n; i++)
            {
                if (i % 2 == 0)
                {
                    S1 = S1 + -(i);
                }

                if (i % 2 != 0)
                {
                    S2 = S2 + i;

                }
            }
            return S1 + S2;
        }

        public void inTong()
        {
            Console.WriteLine("Tong la:");
            Console.WriteLine(tinhTong());
            Console.WriteLine("Tong 2 la:");
            Console.WriteLine(tinhTong2());
            Console.WriteLine("Tong 3 la:");
            Console.WriteLine(tinhTong3());
            Console.WriteLine("Tong Uoc la:");
            Console.WriteLine(tongUoc());

        }

        public float tinhTong2()
        {
            float S3 = 0;
            for (float i = 1; i <= this.n; i++)
                S3 = S3 + 1 / (i);
            return S3;
        }

        public float tinhTong3()
        {
            float S4 = 0;
            for (int i = 0; i <= this.n; i++)
                S4 = S4 + (this.n - i);
            return S4;
        }

        public float tongUoc()
        {
            float S5 = 0;
            for (float i = 1; i < this.n; i++)
            {
                if (this.n % i == 0)
                {
                    S5 = S5 + i;
                }

            }
            return S5;
        }
    }
}

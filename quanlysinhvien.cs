using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class quanlysinhvien
    {
        public String maSV;
        public String tenSV;
        public float diemTB;

        //default constructors
        public quanlysinhvien()
        {
            this.maSV = "01";
            this.tenSV = "Ngo duy phuong";
            this.diemTB = (float)8.0;

        }
        //tham so hoa constructors
        public quanlysinhvien(String maSV, String tenSV, float diemTB)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemTB = diemTB;
        }





        public void nhapTT()

        {



            Console.Write("Nhap Ten Sinh Vien: ");
            this.tenSV = Console.ReadLine();

            Console.Write("Nhap ma Sinh Vien: ");
            this.maSV = Console.ReadLine();

            Console.Write("Nhap Diem Sinh Vien:");
            this.diemTB = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("--------------");





        }

        public void In()
        {
            Console.WriteLine("Ma Sinh Vien: {0} ", this.maSV);
            Console.WriteLine("Ten Sinh Vien: {0} ", this.tenSV);
            Console.WriteLine("Diem TB Sinh Vien: {0} ", this.diemTB);
            Console.WriteLine("\n--------------------------\n");

        }

        public float diemtb()
        {
            return this.diemTB;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, luaChon, re;
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Cong:1\nTru:2\nNhan:3\nChia:4\nNhap lua chon: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    re = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, re);
                    break;
                case 2:
                    re = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, re);
                    break;
                case 3:
                    re = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, re);
                    break;
                case 4:
                    float re4;
                    re4 = (float)a / (float)b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, re4);
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le!");
                    break;
            }
            Console.ReadKey();

        }
    }
}

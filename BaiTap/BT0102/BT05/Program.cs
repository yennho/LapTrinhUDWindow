using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("Nhap canh a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c = float.Parse(Console.ReadLine());

            if (laTamGiac(a, b, c) == 1)
            {
                if (laTamGiacVuongCan(a, b, c) == 1)
                {
                    Console.WriteLine("La tam giac VUONG CAN!!");
                }
                else if (laTamGiacDeu(a, b, c) == 1)
                {
                    Console.WriteLine("La tam giac DEU!!");
                }
                else if (laTamGiacVuong(a, b, c) == 1)
                {
                    Console.WriteLine("La tam giac VUONG!!");
                }
                else if (laTamGiacCan(a, b, c) == 1)
                {
                    
                    Console.WriteLine("La tam giac CAN");
                }
                else
                {
                    Console.WriteLine("La tam giac THUONG!!");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la tam giac!!");
            }
            Console.ReadKey();
        }
        static int laTamGiac(float a, float b, float c)
        {
            if (a + b > c || a + c > b || b + c > a) return 1;
            else return 0;          
        }
        static int laTamGiacCan(float a, float b, float c)
        {
            if (a == b || a == c || b == c)  return 1;
            else return 0;
        }
        static int laTamGiacDeu(float a, float b, float c)
        {
            if (a == b && b == c) return 1;
            else return 0;
        }
        static int laTamGiacVuong(float a, float b, float c)
        {
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) return 1;
            else return 0;
        }
        static int laTamGiacVuongCan(float a, float b, float c)
        {
            if (laTamGiacVuong(a, b, c) == 1 && laTamGiacCan(a, b, c) == 1) return 1;
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            do
            {
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
            } while (a < 0);

            do
            {
                Console.Write("Nhap b: ");
                b = int.Parse(Console.ReadLine());
            } while (b < 0);
            do
            {
                Console.Write("Nhap c: ");
                c = int.Parse(Console.ReadLine());
            } while (c < 0);
            do
            {
                Console.Write("Nhap d: ");
                d = int.Parse(Console.ReadLine());
            } while (d < 0);
           
            Console.WriteLine("So lon nhat la: {0}", Math.Max(Math.Max(a, b), Math.Max(c, d)));

            Console.ReadKey();

        }
    }
}

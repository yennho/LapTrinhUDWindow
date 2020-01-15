using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, delta, x1, x2;

            Console.Write("Nhap a: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = Double.Parse(Console.ReadLine());

            Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);

            delta = b * b - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("PTVN");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("PT co nghiem kep x1 = x2 = {0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }

            Console.ReadKey();
        }
    }
}

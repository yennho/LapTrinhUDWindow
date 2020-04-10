using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max = 1;
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());

            for(int i = 1; i <= Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0 && i > max)
                {             
                    max = i;
                }
            }
            Console.WriteLine("USCLN la: {0}", max);
            Console.ReadKey();
        }
    }
}

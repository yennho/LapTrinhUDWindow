using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            int[] fibo = new int[n+1];

            fibo[0] = 1;
            fibo[1] = 1;
            Console.Write("day FIBONACY: {0} {1} ", fibo[0], fibo[1]);
            for (int i = 2; fibo[i - 1] <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                if (fibo[i] <= n)
                {                  
                    Console.Write("{0} ", fibo[i]);
                }
                
            }
           

            Console.ReadKey();
        }
    }
}

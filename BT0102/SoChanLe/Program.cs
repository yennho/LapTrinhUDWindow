using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Nhap so can kiem tra: ");
            try
            {

                do
                {
                    a = int.Parse(Console.ReadLine());

                    if (a < 0)
                    {
                        Console.WriteLine("Nhap so lon hon 0!!!");
                        Console.Write("Nhap lai so can kiem tra: ");
                    }

                } while (a < 0);

                if (a % 2 == 0)
                {
                    Console.WriteLine("{0} so chan", a);
                }
                else
                {
                    Console.WriteLine("{0} so le", a);
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

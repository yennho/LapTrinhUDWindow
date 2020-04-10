using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Onl_Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDate day = new ClassDate();
            day.Nhap();
            day.Xuat();

            if(day.KTDate() == true)
            {
                Console.WriteLine("\nNgay thang hop le!");
            }
            else
            {
                Console.WriteLine("\nNgay thang khong hop le!");
            }
            Console.ReadKey();
        }
    }
}

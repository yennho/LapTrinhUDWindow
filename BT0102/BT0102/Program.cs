using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT0102
{
    class Program
    {
        static void Main(string[] args)
        {
            Double diemToan, diemLy, diemHoa;
            Console.Write("Nhap diem toan: ");
            diemToan = Double.Parse(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            diemLy = Double.Parse(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            diemHoa = Double.Parse(Console.ReadLine());

            Double diemTB = (diemToan + diemLy + diemHoa) / 3;

            Console.WriteLine("Toan: {0}", diemToan);
            Console.WriteLine("Ly: {0}", diemLy);
            Console.WriteLine("Hoa: {0}", diemHoa);
            Console.WriteLine("TBM: {0}", diemTB);
            
            if(diemTB < 5)
            {
                Console.WriteLine("Xep loai: Yeu");
            }
            else if (diemTB >=5 && diemTB < 6.5)
            {
                Console.WriteLine("Xep loai: Trung Binh");
            }
            else if (diemTB >= 6.5 && diemTB < 8)
            {
                Console.WriteLine("Xep loai: Kha");
            }
            else
            {
                Console.WriteLine("Xep loai: Gioi");
            }

            Console.ReadKey();            
        }
    }
}

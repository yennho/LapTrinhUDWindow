using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Onl_Buoi2
{
    class ClassDate
    {
        private int day;
        private int month;
        private int year;


        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public ClassDate()
        {
        }

        public ClassDate(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }

        public void Nhap()
        {
            Console.Write("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("{0}/{1}/{2}", day, month, year);
        }

        public bool KTDate()
        {
            if (day < 1 || day > 31)
            {
                return false;
            }
            else if (month < 1 || month > 12)
            {
                return false;
            }
            else if (year < 1980 || year > 2020)
            {
                return false;
            }
            else return true;
        }
    }
}

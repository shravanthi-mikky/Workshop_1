using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    public class DayOf_Week
    {

        public void DayOfWeekMethod()
        {
            Console.WriteLine("Please enter the Date :");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Month :");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Year :");
            int year = Convert.ToInt32(Console.ReadLine());

            int y0 = year - ((14 - month) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 100);
            int m0 = month + (12 * ((14 - month) / 12)) - 2;
            int d0 = ((date + x + 31 * m0 / 12) % 7);
            Console.WriteLine(d0);
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Day is Sunday!");
                    break;
                case 1:
                    Console.WriteLine("Day is Monday!");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday!");
                    break;
                case 4:
                    Console.WriteLine("Day is Wednesday!");
                    break;
                case 5:
                    Console.WriteLine("Day is Thursday!");
                    break;
                case 6:
                    Console.WriteLine("Day is Friday!");
                    break;
                case 7:
                    Console.WriteLine("Day is Saturday!");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;

            }


        }
    }
}

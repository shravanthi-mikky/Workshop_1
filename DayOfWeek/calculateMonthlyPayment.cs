using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    public class calculateMonthlyPayment
    {
        public static void calculate()
        {
            Console.WriteLine("Please enter the Principle");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Years");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Rate of interest");
            double R = Convert.ToInt32(Console.ReadLine());
            double r = R / (12 * 100);
            double n = 12 * Y;
            double x = Math.Pow((1 + r), -n);
            Console.WriteLine(x);
            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(payment);
        }
    }
}

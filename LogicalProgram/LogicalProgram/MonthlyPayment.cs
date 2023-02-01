using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class MonthlyPayment
    {
        public static void Payment()
        {
            int p, n, y;
            double payment, r, Rate;
            Console.WriteLine("Enter the Principal Amount : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the No.of Years : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest : ");
            Rate = Convert.ToDouble(Console.ReadLine());
            n = 12 * y;
            r = Rate / (12 * 100);
            payment = (p * r) / (1 - (Math.Pow((1 + r), (-n))));
            Console.WriteLine("Monthly Payment : " + payment);
        }
    }
}
        
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ToBinary
    {
        public static void DecimalToBinary()
        {
            string result = "";
            int n, r;
            Console.WriteLine("Enter the Decimal Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                r = n % 2;
                result = Convert.ToString(r) + result;
                n = n / 2;

            }
            Console.WriteLine("Binary Equivalant {0}", result);
        }
    }
}

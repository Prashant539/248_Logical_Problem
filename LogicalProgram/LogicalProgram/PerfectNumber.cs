using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public static void PerfectNumberPrint()
        {
            int  sum = 0;
            Console.WriteLine("Enter the Number to check Perfect Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("Sum of Divisor are {0}", sum);
            if ( sum == number)
            {
                Console.WriteLine("Number is a Perfect number");
            }
            else
            {
                Console.WriteLine("Number is not a Perfect number");
            }

        }
    }
}

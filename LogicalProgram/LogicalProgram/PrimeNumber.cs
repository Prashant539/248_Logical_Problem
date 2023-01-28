using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public static void PrimeNumberPrint()
        {
            int count = 0;
            Console.WriteLine("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("Number is Prime Number");
            }
            else
            {
                Console.WriteLine("Number is not a Prime number");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public static void ReverseNumberPrint()
        {
            int result = 0, reminder;
            Console.WriteLine("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number!=0)
            {
                reminder = number % 10;
                result = result * 10 + reminder;
                number = number / 10;

            }
            Console.WriteLine("Reversed Number: " +result);
          

        }
        
    }
}

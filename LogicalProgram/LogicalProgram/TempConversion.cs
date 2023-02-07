using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class TempConversion
    {
        public static void Temp()
        {
            double c, f;
            Console.WriteLine("Enter the value for Temperature Coversion: ");
            Console.WriteLine("1:Celsius\n2:Faherenhit");
            int conversion = Convert.ToInt32(Console.ReadLine());
            switch(conversion)
            {
                case 1:
                    Console.WriteLine("Enter the Temp for converting the Celsius to Fahrenheit: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = (c * 9 / 5) + 32;
                   
                    Console.WriteLine("{0} Celsius in Fahrenheit is {1}", c, f);
                    break;
                case 2:
                    Console.WriteLine("Enter the Temp for converting the Fahrenheit to Celsius: ");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                   
                    Console.WriteLine("{0} Fahrenheit in Celsius is {1}", f, c);
                    break;

            }
        }
    }
}

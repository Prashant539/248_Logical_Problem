using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class WeekDay
    {
        public static void DayOfWeek()
        {
            Console.WriteLine("Welcome to the Gregorian Calendar");
            Console.WriteLine("For month ,select :1:January Type,2:February Type,3:March Type,4:April Type,5:May Type,6:June Type,7:July ,8:August Type,9:September Type,10:october Type,11:November Type,12:December Type");
            Console.WriteLine("Enter the month ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of the month");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - num) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = num + 12 * ((14 - num) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
    


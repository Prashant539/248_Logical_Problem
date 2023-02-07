using System;
namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Program");
            Console.WriteLine("Please Choose any Option to execute Program");
            Console.WriteLine("1:FibonacciSeries\n2:PerfectNumber\n3:PrimeNumber\n4:ReverseNumber\n5:TempConversion\n6:WeekDay\n7:MonthlyPayment\n8:Binary");
            int Options = Convert.ToInt32(Console.ReadLine());
            switch(Options)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
                case 2:
                    PerfectNumber.PerfectNumberPrint();
                    break;
                case 3:
                    PrimeNumber.PrimeNumberPrint();
                    break;
                case 4:
                    ReverseNumber.ReverseNumberPrint();
                    break;
                case 5:
                    TempConversion.Temp();
                    break;
                case 6:
                    WeekDay.DayOfWeek();
                    break;
                case 7:
                    MonthlyPayment.Payment();
                    break;  
                case 8:
                    ToBinary.DecimalToBinary();
                    break;
            }
            

        }
    }
}

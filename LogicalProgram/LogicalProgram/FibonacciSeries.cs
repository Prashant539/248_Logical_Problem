using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        
        public static void Fibonacci()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for(int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
           
        }
        
    }
}

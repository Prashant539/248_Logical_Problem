﻿using System;
namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Program");
            Console.WriteLine("Please Choose any Option to execute Program");
            Console.WriteLine("1:FibonacciSeries");
            int Options = Convert.ToInt32(Console.ReadLine());
            switch(Options)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
            }
            

        }
    }
}
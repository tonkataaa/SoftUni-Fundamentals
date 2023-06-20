using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Multiplication_Table2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int multiplication = 0;

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    multiplication = number * i;
                    Console.WriteLine("{0} X {1} = {2}", number, i,multiplication);
                }
            }
            else
            {
                multiplication = number * multiplier;
                Console.WriteLine("{0} X {1} = {2}", number, multiplier, multiplication);
            }
            
        }
    }
}

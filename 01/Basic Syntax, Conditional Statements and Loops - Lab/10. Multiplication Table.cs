using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplication = 0;

            for (int i = 1; i <= 10; i++)
            {
                multiplication = n * i;
                Console.WriteLine($"{n} X {i} = {multiplication}");
            }
        }
    }
}

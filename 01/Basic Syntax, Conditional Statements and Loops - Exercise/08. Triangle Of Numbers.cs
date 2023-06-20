using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Write a program, which receives a number – n and prints a triangle from 1 to n.
*/
namespace TriangleofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}

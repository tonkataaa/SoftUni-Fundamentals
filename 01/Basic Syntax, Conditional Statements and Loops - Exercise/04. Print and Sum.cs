using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
Your task is to print two lines:
• On the first line, print all numbers from the start of the sequence to the end inclusive.
• On the second line, print the sum of the sequence in the format: "Sum: {sum}".

Input:
5
10

0
26
*/
namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            float sum = 0;
            for (int i = number1; i < number2; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine(number2);
            sum += number2;

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

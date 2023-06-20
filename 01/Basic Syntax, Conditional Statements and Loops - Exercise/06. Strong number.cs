using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of 
the factorials of each digit is equal to the number itself.
Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
Print "yes", if the number is strong and "no", if the number is not strong.
*/
namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numberCopy = num;
            float factorialSum = 0;

            while (numberCopy > 0)
            {
                int digit = numberCopy % 10;
                numberCopy /= 10;

                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial; 
            }

            string isStrongNumber = factorialSum == numberCopy ? "yes" : "no";
            Console.WriteLine(isStrongNumber);
        }
    }
}

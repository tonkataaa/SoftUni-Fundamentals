using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Write a program that determines if a person is baby, child, teenager, adult or elder based on the given age. 
The boundaries are:
• 0-2 – baby
• 3-13 – child
• 14-19 – teenager
• 20-65 – adult
• >= 66 – elder
All the values are inclusive
*/
namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age >= 3 && age <= 13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age >= 14 && age <= 19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age >= 20 && age <= 65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else if (age >= 66)
            //{
            //    Console.WriteLine("elder");
            //}

            switch (age)
            {

                case 1:
                    if (age >= 0 && age <= 2)
                    Console.WriteLine("baby");
                    break;
                case 2:
                    if (age >= 3 && age <= 13)
                        Console.WriteLine("child");
                    break;
                case 3:
                    if (age >= 14 && age <= 19)
                        Console.WriteLine("teenager");
                    break;
                case 4:
                    if (age >= 20 && age <= 65)
                        Console.WriteLine("adult");
                    break;
                case 5:
                    if (age >= 66)
                        Console.WriteLine("elder");
                    break;
            }
               
        }
    }
}

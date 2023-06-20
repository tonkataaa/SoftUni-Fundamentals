using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Yoda is starting his newly created Jedi academy. So, he asked master John to buy the needed equipment. The number 
of items depends on how many students will sign up. The equipment for each Padawan contains:
• Lightsaber
• Belt
• Robe
You will be given the amount of money John has, the number of students and the prices of each item. Calculate if
John has enough money to buy equipment for each Padawan or how much more money he needs.
There are some additional requirements:
• Lightsabres sometimes break, so John should buy 10% more (taken from the students' count), rounded up
to the next integer.
• Every sixth belt is free.
*/
namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double totalMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            //Solution
            double percent = (double)countOfStudents * 10 / 100;
            double allSabers = countOfStudents + Math.Ceiling(percent);
            double sabers = priceOfLightsaber * allSabers;

            double robes = priceOfRobe * countOfStudents;

            double beltsDiss = countOfStudents - Math.Ceiling((double)(countOfStudents / 6));
            double belts = priceOfBelt * beltsDiss;

            double total = sabers + robes + belts;

            double beltsdiss = countOfStudents - Math.Ceiling((double)(countOfStudents/ 6));

            //Output
            if (total <= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {total - totalMoney:f2}lv more.");                      
            }

        }
    }
}

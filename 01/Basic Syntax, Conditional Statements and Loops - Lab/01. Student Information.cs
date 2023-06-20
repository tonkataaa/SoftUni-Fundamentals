using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}", name, age, averageGrade);
        }
    }
}

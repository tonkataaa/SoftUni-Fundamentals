using System;
using System.Collections.Generic;
using System.Linq;
/*
Create a program which reverses a string and prints it on the console.
*/
namespace _04._Reverse_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Input
			string text = Console.ReadLine();
			
			//Solution
			char[] textArray = text.ToCharArray();
			Array.Reverse(textArray);
			string reversed = new string(textArray);


			//Output
			Console.WriteLine(reversed);
		}
	}
}

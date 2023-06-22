using System;

namespace _03._Gaming_Store
{
// Create a program, which helps you buy the games.The valid games are the following games in this table:
// Name                Price
// OutFall 4           $39.99
// CS: OG             $15.99
// Zplinter Zell      $19.99
// Honored 2          $59.99
// RoverWatch         $29.99
// RoverWatch Origins Edition $39.99
// On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
// Until you receive the command "Game Time", you have to keep buying games. When a game is bought, the user's
// balance decreases by the price of the game.
// Additionally, the program should obey the following conditions:
// • If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next
// line.
// • If at any point, the user has $0 left, print "Out of money!" and end the program.
// • Alternatively, if the user is trying to buy a game that they can't afford, print "Too Expensive" and read
// the next line.
// • If the game exists and the player has the money for it, print "Bought {nameOfGame}".
// When you receive "Game Time", print the user's remaining money and total spent on games, rounded to the 2
// nd
// decimal place.
	internal class Program
	{
		static void Main(string[] args)
		{
			//Input
			decimal balance = decimal.Parse(Console.ReadLine());

			//Solution
			string input;
			decimal totalSpent = 0;
			decimal price = 0;
			while ((input = Console.ReadLine()) != "Game Time")
			{
				if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input != "RoverWatch Origins Edition")
				{
					Console.WriteLine("Not Found");
					continue;
				}
			
				if (input == "OutFall 4")
				{
					price = 39.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

				if (input == "CS: OG")
				{
					price = 15.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

				if (input == "Zplinter Zell")
				{
					price = 19.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

				if (input == "Honored 2")
				{
					price = 59.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

				if (input == "RoverWatch")
				{
					price = 29.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

				if (input == "RoverWatch Origins Edition")
				{
					price = 39.99m;
					if (balance < price)
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					balance -= price;
					totalSpent += price;
					Console.WriteLine($"Bought {input}");
				}

			}
			if (balance <= 0)
			{
				Console.WriteLine("Out of money!");
				
			}
			else
			{
			Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:F2}");
			}
		}
	}
}


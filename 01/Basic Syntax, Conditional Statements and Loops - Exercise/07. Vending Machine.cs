using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace _07.VendingMachine
{
/*
 Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the 
valid ones should be accumulated. Valid coins are:
 • 0.1, 0.2, 0.5, 1 and 2
If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
On the next lines, until the "End" command is given, you will start receiving products, which a customer wants to 
buy. The vending machine has only:
• "Nuts" with a price of 2.0
• "Water" with a price of 0.7
• "Crisps" with a price of 1.5
• "Soda" with a price of 0.8
• "Coke" with a price of 1.0
If the customer tries to purchase a not existing product, print "Invalid product".
When a customer has enough money to buy the selected product, print "Purchased {product name}", 
otherwise print "Sorry, not enough money" and continue to the next line.
When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: 
{money left}".
     
    
Input:    
1
1
0.5
0.6
Start
Coke
Soda
Crisps
End
 */
	class Program
    {
        static void Main(string[] args)
        {
            //Input
            string coins = Console.ReadLine();

            //First loop which is counting coins 
            decimal coinsSum = 0;
            while (coins != "Start")
            {
                if (coins != "0.1" && coins != "0.2" && coins != "0.5" && coins != "1" && coins != "2")
                {
                    Console.WriteLine($"Cannot accept {coins}");            
                }    

                coinsSum = coinsSum + decimal.Parse(coins);  
                coins = Console.ReadLine();
            }

            //Second loop which is buying the products 
            string products = Console.ReadLine();
            while (products != "End")
            {
				if(products == "Nuts")
				{
					if (coinsSum < 2.0m)
					{
						Console.WriteLine("Sorry, not enough money");
						continue;
					}
					coinsSum -= 2.0m;
					Console.WriteLine($"Purchased {products.ToLower()}");

				}
				else if (products == "Water")
				{
					if (coinsSum < 0.7m)
					{
						Console.WriteLine("Sorry, not enough money");
						continue;
					}
					coinsSum -= 0.7m;
					Console.WriteLine($"Purchased {products.ToLower()}");

				}
				else if (products == "Crisps")
				{
					if (coinsSum < 1.5m)
					{
						Console.WriteLine("Sorry, not enough money");
						continue;
					}
					coinsSum -= 1.5m;
					Console.WriteLine($"Purchased {products.ToLower()}");

				}
				else if (products == "Soda")
				{
					if (coinsSum < 0.8m)
					{
						Console.WriteLine("Sorry, not enough money");
						continue;
					}
					coinsSum -= 0.8m;
					Console.WriteLine($"Purchased {products.ToLower()}");

				}
				else if (products == "Coke")
				{
					if (coinsSum < 1.0m)
					{
						Console.WriteLine("Sorry, not enough money");
						continue;
					}
					coinsSum -= 1.0m;
					Console.WriteLine($"Purchased {products.ToLower()}");

				}
				else
				{
					Console.WriteLine("Invalid product");
				}
			}


            //Ouput
            Console.WriteLine($"Change: {coinsSum:f2}");		
		}
    }
}

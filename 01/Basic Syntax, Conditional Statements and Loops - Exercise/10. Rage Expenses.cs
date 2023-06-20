using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
As a MOBA challenger player, Petar has the bad habit of trashing his PC when he loses a game and of rage quiting. 
His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
Every second lost game, Petar trashes his headset.
Every third lost game, Petar trashes his mouse.
When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
Every second time, when he trashes his keyboard, he also trashes his display. 
You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming 
equipment.
*/
namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadset = 0;
            double trashedMouse = 0;
            double trashedKeyboard = 0;
            double trashedDisplay = 0;

            double expenses = 0;
            //Solution
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                }

                if (i % 3 == 0)
                {
                    trashedMouse++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboard++;
                    if (trashedKeyboard % 2 == 0)
                    {
                        trashedDisplay++;
                    }
                }
            }
            expenses = (trashedDisplay * displayPrice) + (trashedHeadset *headsetPrice ) +(trashedKeyboard * keyboardPrice) + (trashedMouse * mousePrice);



            //Output
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

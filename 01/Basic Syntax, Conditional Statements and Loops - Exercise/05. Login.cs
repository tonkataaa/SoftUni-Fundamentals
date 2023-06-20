using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
On the first line, you will be given a username and your task is to try to log in the user. The user's password is the 
username reversed. On the next lines, you will receive passwords:
• If the password is incorrect, print "Incorrect password. Try again.".
• If the password is correct, print "User {username} logged in." and stop the program.
Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} 
blocked!".
Then the program stops.



 * 1st Input:
Acer
login
go
let me in
recA

2nd Input:
momo
omom

 */
namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Incorrect password. Try again."
            //"User {username} logged in."

            string username = Console.ReadLine();
            string password = new string(username.ToCharArray().Reverse().ToArray());
            int attempts = 4;

            while (attempts > 0)
            {
                attempts -= 1;
                string inputPass = Console.ReadLine();
                if (inputPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (attempts == 0)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }

                }
            }


        }
    }
}

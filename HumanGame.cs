using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class HumanGame
    {
        public int ComputerNum()
        {
            Menu menu = new Menu();
            int count = 1;
            int userguess = 0;
            Random random = new Random();
            int computernum = random.Next(1, 1000);

            Console.Write("Guess the number the computer has chosen! Enter a number from 1 to 1000: \n", Console.ForegroundColor = ConsoleColor.White);


            while (userguess != computernum)
            {
                count++;
                //Console.WriteLine($"This is attempt {count}");
                //Console.Write("Guess the number the computer has chosen! Enter a number from 1 to 1000: ", Console.ForegroundColor = ConsoleColor.White);
                try
                {
                    Console.Write("Guess: ", Console.ForegroundColor = ConsoleColor.White);
                    userguess = Int32.Parse(Console.ReadLine());
                    if (userguess > 0 && userguess < 1001)
                    {
                        if (userguess == computernum)
                        {
                            //double average
                            Console.WriteLine($"Congratulations! It took you {count} attempts to guess the correct number!\n");
                            //Console.WriteLine($);
                            Console.WriteLine("Press any key to play again...");
                            Console.ReadLine();
                            menu.MenuOption();

                        }
                        else if(userguess > computernum)
                        {
                            Console.Write($"Attempt {count}: \n");
                            Console.Write("Too high!\n", Console.ForegroundColor = ConsoleColor.DarkRed);
                            
                        }
                        else if (userguess < computernum)
                        {
                            Console.Write($"Attempt {count}: \n");
                            Console.Write("Too low!\n", Console.ForegroundColor = ConsoleColor.DarkRed);
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Are you even trying? Enter a number from 1 to 1000");
                        Console.ReadLine();
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("Invalid input");  
                } 
            }

            return count;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class ComputerGame
    {
        public void ComputerGuess()
        {
            Menu menu = new Menu();
            int usernum = 0;
            Console.Write("\nEnter a number between 1 and 1000: ");
            try
            {
                usernum = Int32.Parse(Console.ReadLine());
                if (usernum > 0 && usernum < 1001)
                {
                    int first = 0;
                    int last = 1000;
                    int count = 1;
                    int middle = -1;

                    while (usernum != middle)
                    {
                        middle = (first + last) / 2;
                        if (middle > usernum)
                        {
                            last = middle;
                            Console.WriteLine($"The Computer guessed {middle} in {count} attempts!");
                            Console.WriteLine($"It has been narrowed down to {first} - {last}!");
                            count++;
                        }
                        else if (middle < usernum)
                        {
                            first = middle;
                            Console.WriteLine($"The Computer guessed {middle} in {count} attempts!");
                            Console.WriteLine($"It has been narrowed down to {last} - {first}!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine($"The computer has guessed {usernum} in {count} attempts!");
                            //Console.ReadLine();
                            Console.WriteLine("Press any key to play again...");
                            Console.ReadLine();
                            menu.MenuOption();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number. Do you even want to play?");
                    Console.ReadLine();
                    ComputerGuess();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.ReadLine();
                ComputerGuess();
            }

        }
    }
}

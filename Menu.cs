using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Menu
    {
        public void MenuOption()
        {
            HumanGame human = new HumanGame();
            int count = 0;
            
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*   *-*-*-*-*-*-*-*    ");
                Console.WriteLine($"   !   ___                  __  __         _           !   !  Attempts: {count} !    ");
                Console.WriteLine($@"   !  / __|_  _ ___ ______ |  \/  |__ _ __| |_ ___ _ _ !   *-*-*-*-*-*-*-*               ");
                Console.WriteLine(@"   ! | (_ | || / -_|_-<_-< | |\/| / _` (_-<  _/ -_) '_|!     ");
                Console.WriteLine(@"   !  \___|\_,_\___/__/__/ |_|  |_\__,_/__/\__\___|_|  !                    ");
                Console.WriteLine(@"   !                                                   !                 ");
                Console.WriteLine("    *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*               \n\n\n    ");

                

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Select 1 to guess a number!                                                   ");
                Console.WriteLine(" Select 2 to have the computer guess your number! \n                                                   ");
                string userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        //Console.Clear();
                        Console.WriteLine("\nAre you smarter than a computer? Try your luck!");
                        human.ComputerNum();
                        break;
                    case "2":
                        //Console.Clear();
                        break;
                    default:
                    Console.WriteLine("That is not an option");
                    Console.ReadLine();
                    Console.Clear();
                    MenuOption();
                        break;

                }
            
        }
        
    }
}

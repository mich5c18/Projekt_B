using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class MainMenu
    {
        public void StartMenu()
        {
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        ShowBudget();
                        break;
                    case "2":
                        BudgetMenu();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadKey();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(@"  ____            _            _     _                                         ");
            Console.WriteLine(@" |  _ \          | |          | |   | |                                        ");
            Console.WriteLine(@" | |_) |_   _  __| | __ _  ___| |_  | |__   ___ _ __ ___  __ _ _ __   ___ _ __ ");
            Console.WriteLine(@" |  _ <| | | |/ _` |/ _` |/ _ \ __| | '_ \ / _ \ '__/ _ \/ _` | '_ \ / _ \ '__|");
            Console.WriteLine(@" | |_) | |_| | (_| | (_| |  __/ |_  | |_) |  __/ | |  __/ (_| | | | |  __/ |   ");
            Console.WriteLine(@" |____/ \__,_|\__,_|\__, |\___|\__| |_.__/ \___|_|  \___|\__, |_| |_|\___|_|   ");
            Console.WriteLine(@"                     __/ |                                __/ |                ");
            Console.WriteLine(@"                    |___/                                |___/                 ");


            Console.WriteLine("\n" + "+=======+============================ +");
            Console.WriteLine("| Punkt | Vælg venligst et menupunkt |");
            Console.WriteLine("+=======+============================ +");
            Console.WriteLine("| 1 | Vis budget |");
            Console.WriteLine("+-------+----------------------------+");
            Console.WriteLine("| 2 | Lav budget |");
            Console.WriteLine("+-------+----------------------------+");
            Console.WriteLine("| 0 | Exit |");
            Console.WriteLine("+-------+----------------------------+");

            //Console.WriteLine("\nVælg venligst en af nedenstående menupunkter:\n");
            //        Console.WriteLine("1. Vis budget.\n");
            //        Console.WriteLine("2. Lav et budget.\n");
            //        Console.WriteLine("0. Exit.\n");
        }
    }
}

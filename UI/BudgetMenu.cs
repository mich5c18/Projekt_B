using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class BudgetMenu
    {
        public void Menu()
        {
            Template budget = new Template();
            bool menuType = true;
            do
            {
                ShowBudgetMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        ShowMenu();
                        menuType = false;
                        break;
                    case "1":
                        budget.TemplateSimple();
                        break;
                    case "2":
                        budget.TemplateAdvanced();
                        break;
                    case "3":
                        budget.TemplatePersonal();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadKey();
                        break;
                }
            } while (menuType);
        }

        private void ShowBudgetMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Vælg hvilket budget du vil lægge ==--");
            Console.WriteLine();
            Console.WriteLine("1. Lav simpelt budget - Simpelt budget som er målrettet mod den hjemmeboende studerende i alderen 18-25.\n");
            Console.WriteLine("2. Lav advanceret budget - Advanceret budget som er målrettet mod den udeboende studerende i alderen 18-25.\n");
            Console.WriteLine("3. Lav eget budget - Lav personligt budget med egne indkomster og udgifter.\n");
            Console.WriteLine("0. Gå tilbage til forrige menu.\n");
        }

        private void ShowBudget()
        {
            Console.Clear();
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.Write("Skriv navnet på det budget du vil hente: ");
            string path = Console.ReadLine();
            budgetRepo.LoadBudget(path);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Domain;


namespace Application
{
    public class BudgetRepository
    {
        public List<Budget> budgets = new List<Budget>();

        //Der skal tilføjes income og expenses til budget.
        public void AddBudget(string name, string type, string breed, string dOB, string weight) //UI må ikke kende til Domain, så man skal give alle parametre, selv om man bare kunne skrive PET pet
        {
            Budget budget = new Budget(name, type, breed, dOB, weight); //Laver en instans af Pet
            budgets.Add(budget); //Tilføjer pet til listen af Pets

            pet.RegisterSubscriber(this); //Bliver til en subscriber til pet
            NotifySubscribers("AddPet"); //Notificere sine subscribers med en besked. Beskeden er ikke vigtigt for en user, de ser den ikke
        }
    }
}

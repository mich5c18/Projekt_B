using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Domain;
using Service;


namespace Application
{
    public class BudgetRepository : ISubscriber, IPublisher
    {
        private List<ISubscriber> observers = new List<ISubscriber>();

        public List<Budget> budgets = new List<Budget>();

        //Der skal tilføjes income og expenses til budget.
        public void AddBudget(double su, double løn, double boligstøtte, double stipendier) //UI må ikke kende til Domain, så man skal give alle parametre, selv om man bare kunne skrive PET pet
        {
            Budget budget = new Budget(su, løn, boligstøtte, stipendier); //Laver en instans af Pet
            budgets.Add(budget); //Tilføjer pet til listen af Pets

            budget.RegisterSubscriber(this); //Bliver til en subscriber til pet
            NotifySubscribers("AddPet"); //Notificere sine subscribers med en besked. Beskeden er ikke vigtigt for en user, de ser den ikke
        }

        public void RegisterSubscriber(ISubscriber o)
        {
            observers.Add(o);
        }

        public void RemoveSubscriber(ISubscriber o)
        {
            observers.Remove(o);
        }

        public void NotifySubscribers(string message)
        {
            foreach (ISubscriber o in observers)
            {
                o.Update(this, message);
            }
        }

        public void Update(IPublisher publisher, string message)
        {
            NotifySubscribers(message);
        }
    }
}

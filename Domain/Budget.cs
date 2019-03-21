using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Domain
{
    public class Budget : IPublisher
    {
        private List<ISubscriber> observers = new List<ISubscriber>();

        private double _sU;
        public double SU {
            get { return _sU; }
            set { _sU = value; NotifySubscribers("SU"); }
        }

        private double _løn;
        public double Løn {
            get { return _løn; }
            set { _løn = value; NotifySubscribers("Løn"); }
        }

        private double _boligstøtte;
        public double Boligstøtte 
        {
            get { return _boligstøtte; }
            set { _boligstøtte = value; NotifySubscribers("Boligstøtte"); }
        }

        private double _stipendier;
        public double Stipendier 
        {
            get { return _stipendier; }
            set { _stipendier = value; NotifySubscribers("Stipendier"); }
        }

        public Budget(double su, double løn, double boligstøtte, double stipendier)
        {
            SU = su;
            Løn = løn;
            Boligstøtte = boligstøtte;
            Stipendier = stipendier;
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
    }
}

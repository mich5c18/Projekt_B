using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Budget
    {
        private double _sU;
        public double SU {
            get { return _sU; }
            set { _sU = value; }
        }

        private double _løn;
        public double Løn {
            get { return _løn; }
            set { _løn = value; }
        }

        private double _boligstøtte;
        public double Boligstøtte 
        {
            get { return _boligstøtte; }
            set { _boligstøtte = value;  }
        }

        private double _stipendier;
        public double Stipendier 
        {
            get { return _stipendier; }
            set { _stipendier = value; }
        }

        public Budget(double su, double løn, double boligstøtte, double stipendier, string weight)
        {
            SU = su;
            Løn = løn;
            Boligstøtte = boligstøtte;
            Stipendier = stipendier;
        }
    }
}

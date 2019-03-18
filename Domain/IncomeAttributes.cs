using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class IncomeAttributes
    {
        private double _sU;
        public double SU 
        {
            get { return _sU; }
            set { _sU = value; }
        }

        private double _løn;
        public double Løn 
        {
            get { return _løn; }
            set { _løn = value; }
        }
    }
}

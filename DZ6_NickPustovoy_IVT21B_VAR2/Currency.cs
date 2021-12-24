using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_NickPustovoy_IVT21B_VAR2
{
    abstract class Currency
    {
        protected decimal Amount;
        protected decimal inRubles;

        public Currency(decimal amount)
        {
            Amount = amount;
        }

        public decimal getAmount()
        {
            return Amount;
        }

        public decimal getinRubles()
        {
            return inRubles;
        }

        abstract public decimal ToRubles();
        
    }
}

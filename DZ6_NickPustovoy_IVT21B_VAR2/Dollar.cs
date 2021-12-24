using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_NickPustovoy_IVT21B_VAR2
{
    class Dollar : Currency
    {
        public Dollar(decimal amount) : base(amount)
        {
            ToRubles();
        }
        override protected void ToRubles()
        {
            inRubles = Amount * 73;
        }
    }
}

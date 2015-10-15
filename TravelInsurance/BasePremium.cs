using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelInsurance
{
    public class BasePremium : Event
    {
        private readonly double Amount;

        public BasePremium(double amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format("BasePremium ({0:0.00}): {0:0.00}", Amount);
        }
    }
}

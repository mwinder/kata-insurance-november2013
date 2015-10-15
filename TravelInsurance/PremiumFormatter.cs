using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelInsurance
{
    class PremiumFormatter
    {
        public string Format(Premium premium)
        {
            var declined = premium.AppliedEvents.OfType<Declined>().FirstOrDefault();
            if (declined != null)
                return declined.ToString();

            var result = "";
            foreach (var item in premium.AppliedEvents)
            {
                result += item.ToString();
                result += Environment.NewLine;
            }

            result += string.Format("Total Premium: {0:0.00}", premium.Amount);

            return result;
        }
    }
}

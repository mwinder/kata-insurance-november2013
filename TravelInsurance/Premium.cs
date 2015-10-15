namespace TravelInsurance
{
    using System;
    using System.Collections.Generic;

    public class Premium
    {
        private double amount;
        private readonly IList<Event> appliedEvents = new List<Event>();

        public Premium(double amount)
        {
            this.amount = amount;

            ApplyEvent(new BasePremium(amount));
        }

        public double Amount
        {
            get { return amount; }
        }

        public IEnumerable<Event> AppliedEvents
        {
            get { return appliedEvents; }
        }

        public void Apply(Rating rating)
        {
            try
            {
                var adjustedAmount = rating.ApplyTo(amount);
                var difference = adjustedAmount - amount;
                amount = adjustedAmount;

                ApplyEvent(new RatingApplied(rating.GetType().Name, adjustedAmount, difference));
            }
            catch (DeclinedException exception)
            {
                ApplyEvent(new Declined(exception.Reason));
            }
        }

        private void ApplyEvent(Event eventToApply)
        {
            appliedEvents.Add(eventToApply);
        }
    }
}

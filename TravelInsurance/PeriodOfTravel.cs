namespace TravelInsurance
{
    using System;

    public class PeriodOfTravel : Rating
    {
        private readonly int duration;

        public PeriodOfTravel(int duration)
        {
            this.duration = duration;
        }

        public double ApplyTo(double amount)
        {
            if (0 <= duration && duration <= 7) return amount * 0.5;
            if (duration <= 14) return amount * 0.9;
            if (duration <= 30) return amount * 1.2;

            throw new DeclinedException("Duration");
        }
    }
}

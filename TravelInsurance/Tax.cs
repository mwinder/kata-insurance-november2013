namespace TravelInsurance
{
    using System;

    public class Tax : Rating
    {
        private double rate;

        public Tax(double rate)
        {
            this.rate = rate;
        }

        public double ApplyTo(double amount)
        {
            return amount * (1 + rate);
        }
    }
}

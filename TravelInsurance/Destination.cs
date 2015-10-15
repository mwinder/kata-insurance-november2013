namespace TravelInsurance
{
    using System;

    public class Destination : Rating
    {
        private readonly string destination;

        public Destination(string destination)
        {
            this.destination = destination;
        }

        public double ApplyTo(double amount)
        {
            if (destination == "UK") return amount * 0.6;
            if (destination == "Europe") return amount;
            if (destination == "Worldwide") return amount * 1.4;

            return -1;
        }
    }
}

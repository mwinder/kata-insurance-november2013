namespace TravelInsurance
{
    using System;

    public class Sex : Rating
    {
        private readonly string gender;

        public Sex(string gender)
        {
            this.gender = gender;
        }

        public double ApplyTo(double amount)
        {
            if (gender == "Male") return amount * 1.2;
            if (gender == "Female") return amount * 0.9;

            throw new InvalidOperationException();
        }
    }
}

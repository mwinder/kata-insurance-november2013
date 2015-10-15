namespace TravelInsurance
{
    using System;

    public class Age : Rating
    {
        private readonly int age;

        public Age(int age)
        {
            this.age = age;
        }

        public double ApplyTo(double amount)
        {
            if (0 <= age && age <= 18) return amount * 1.2;
            if (age <= 45) return amount;
            if (age <= 55) return amount * 1.2;
            if (age <= 65) return amount * 1.8;
            if (age <= 70) return amount * 2;

            throw new DeclinedException("Age");
        }
    }
}

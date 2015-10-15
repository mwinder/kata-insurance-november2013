namespace TravelInsurance
{
    public class SingleTripPolicy : Policy
    {
        private readonly Age age;
        private readonly Sex gender;
        private readonly Destination destination;
        private readonly PeriodOfTravel duration;
        private readonly Tax tax;

        private const int BasePremium = 20;

        public SingleTripPolicy(Age age, Sex gender, Destination destination, PeriodOfTravel duration, Tax tax)
        {
            this.age = age;
            this.gender = gender;
            this.destination = destination;
            this.duration = duration;
            this.tax = tax;
        }

        public Premium CalculatePremium()
        {
            var premium = new Premium(BasePremium);
            premium.Apply(age);
            premium.Apply(gender);
            premium.Apply(destination);
            premium.Apply(duration);
            premium.Apply(tax);

            return premium;
        }
    }
}

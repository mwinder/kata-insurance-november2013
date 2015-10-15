namespace TravelInsurance
{
    public class AnnualPolicy : Policy
    {
        private readonly Age age;
        private readonly Sex gender;
        private readonly Destination destination;
        private readonly Tax tax;

        private const int BasePremium = 80;

        public AnnualPolicy(Age age, Sex gender, Destination destination, Tax tax)
        {
            this.age = age;
            this.gender = gender;
            this.destination = destination;
            this.tax = tax;
        }

        public Premium CalculatePremium()
        {
            var premium = new Premium(BasePremium);
            premium.Apply(age);
            premium.Apply(gender);
            premium.Apply(destination);
            premium.Apply(tax);

            return premium;
        }
    }
}

namespace TravelInsurance.Tests
{
    using Xunit;

    public class AcceptanceTests
    {
        [Fact]
        public void SingleTripAge20MaleUKFor10Days()
        {
            var policy = new SingleTripPolicy(new Age(20), new Sex("Male"), new Destination("UK"), new PeriodOfTravel(10), new Tax(0.05));

            var premium = policy.CalculatePremium();

            string result = new PremiumFormatter().Format(premium);

            Assert.Equal(
@"BasePremium (20.00): 20.00
Age (0.00): 20.00
Sex (4.00): 24.00
Destination (-9.60): 14.40
PeriodOfTravel (-1.44): 12.96
Tax (0.65): 13.61
Total Premium: 13.60", result);
        }

        [Fact]
        public void AnnualAge67FemaleWorldwide()
        {
            var policy = new AnnualPolicy(new Age(67), new Sex("Female"), new Destination("Worldwide"), new Tax(0.05));

            var premium = policy.CalculatePremium();

            string result = new PremiumFormatter().Format(premium);

            Assert.Equal(
@"BasePremium (80.00): 80.00
Age (80.00): 160.00
Sex (-16.00): 144.00
Destination (57.60): 201.60
Tax (10.08): 211.68
Total Premium: 211.68", result);
        }

        [Fact]
        public void DeclinedPolicy()
        {
            var policy = new SingleTripPolicy(new Age(76), new Sex("Male"), new Destination("Worldwide"), new PeriodOfTravel(21), new Tax(0.05));

            var premium = policy.CalculatePremium();

            string result = new PremiumFormatter().Format(premium);

            Assert.Equal(@"DECLINE: Age", result);
        }
    }
}

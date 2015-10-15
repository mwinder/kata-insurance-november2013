namespace TravelInsurance.Tests
{
    using System.Linq;
    using Xunit;

    public class PremiumTests
    {
        private readonly Premium premium;

        public PremiumTests()
        {
            premium = new Premium(100);
        }

        [Fact]
        public void CanApplyRating()
        {
            premium.Apply(new Age(17));

            Assert.Equal(120, premium.Amount, 2);
        }

        [Fact]
        public void CanApplyAllRatings()
        {
            premium.Apply(new Age(17));
            premium.Apply(new Sex("Male"));
            premium.Apply(new Destination("Worldwide"));
            premium.Apply(new PeriodOfTravel(15));

            Assert.Equal(241.92, premium.Amount, 2);
        }

        [Fact]
        public void CanApplyTax()
        {
            premium.Apply(new Tax(0.05));

            Assert.Equal(105, premium.Amount);
        }

        [Fact]
        public void AggregatesAppliedRatings()
        {
            premium.Apply(new Sex("Male"));

            Assert.Equal(2, premium.AppliedEvents.Count());
        }
    }
}
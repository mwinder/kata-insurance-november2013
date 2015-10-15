namespace TravelInsurance.Tests
{
    using System;
    using Xunit;

    public class PolicyTests
    {
        [Fact]
        public void CalculatesAnnualPolicy()
        {
            var policy = new AnnualPolicy(
                new Age(34), new Sex("Male"), new Destination("UK"), new Tax(0.05));

            var premium = policy.CalculatePremium();

            Assert.Equal(60.48, premium.Amount, 2);
        }

        [Fact]
        public void CalculatesSingleTripPolicy()
        {
            var policy = new SingleTripPolicy(
                new Age(46), new Sex("Female"), new Destination("Worldwide"), new PeriodOfTravel(10), new Tax(0.05));

            var premium = policy.CalculatePremium();

            Assert.Equal(28.58, premium.Amount, 2);
        }
    }
}
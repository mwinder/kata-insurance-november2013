namespace TravelInsurance.Tests
{
    using Xunit;

    public class RatingTests
    {
        [Fact]
        public void ForMale()
        {
            var subject = new Sex("Male");

            Assert.Equal(120, subject.ApplyTo(100));
        }

        [Fact]
        public void ForFemale()
        {
            var subject = new Sex("Female");

            Assert.Equal(90, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged18()
        {
            var subject = new Age(18);

            Assert.Equal(120, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged19()
        {
            var subject = new Age(19);

            Assert.Equal(100, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged46()
        {
            var subject = new Age(46);

            Assert.Equal(120, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged56()
        {
            var subject = new Age(56);

            Assert.Equal(180, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged70()
        {
            var subject = new Age(70);

            Assert.Equal(200, subject.ApplyTo(100));
        }

        [Fact]
        public void ForSomeoneAged71Decline()
        {
            var subject = new Age(71);

            Assert.Throws<DeclinedException>(() => subject.ApplyTo(100));
        }

        [Fact]
        public void ForUK()
        {
            var subject = new Destination("UK");

            Assert.Equal(60, subject.ApplyTo(100));
        }

        [Fact]
        public void ForEurope()
        {
            var subject = new Destination("Europe");

            Assert.Equal(100, subject.ApplyTo(100));
        }

        [Fact]
        public void ForWorldwide()
        {
            var subject = new Destination("Worldwide");

            Assert.Equal(140, subject.ApplyTo(100));
        }

        [Fact]
        public void For7Days()
        {
            var subject = new PeriodOfTravel(7);

            Assert.Equal(50, subject.ApplyTo(100));
        }

        [Fact]
        public void For14Days()
        {
            var subject = new PeriodOfTravel(14);

            Assert.Equal(90, subject.ApplyTo(100));
        }

        [Fact]
        public void For30Days()
        {
            var subject = new PeriodOfTravel(30);

            Assert.Equal(120, subject.ApplyTo(100));
        }

        [Fact]
        public void For31DaysDecline()
        {
            var subject = new PeriodOfTravel(31);

            Assert.Throws<DeclinedException>(delegate { subject.ApplyTo(100); });
        }
    }
}
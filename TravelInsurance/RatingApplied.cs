namespace TravelInsurance
{
    public class RatingApplied : Event
    {
        public readonly double AdjustedAmount;
        public readonly double Difference;
        public readonly string Rating;

        public RatingApplied(string rating, double adjustedAmount, double difference)
        {
            this.AdjustedAmount = adjustedAmount;
            this.Rating = rating;
            this.Difference = difference;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1:0.00}): {2:0.00}", Rating, Difference, AdjustedAmount);
        }
    }
}

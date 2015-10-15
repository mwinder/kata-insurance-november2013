namespace TravelInsurance
{
    public class Declined : Event
    {
        private readonly string Reason;

        public Declined(string reason)
        {
            Reason = reason;
        }

        public override string ToString()
        {
            return "DECLINE: " + Reason;
        }
    }
}

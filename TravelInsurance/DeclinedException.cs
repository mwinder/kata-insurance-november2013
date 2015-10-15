namespace TravelInsurance
{
    using System;

    public class DeclinedException : Exception
    {
        private readonly string reason;

        public DeclinedException(string reason)
        {
            this.reason = reason;
        }

        public string Reason
        {
            get { return this.reason; }
        }
    }
}

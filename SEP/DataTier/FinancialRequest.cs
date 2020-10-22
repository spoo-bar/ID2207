namespace DataTier
{
    public class FinancialRequest
    {
        public FinancialRequest(RequestingDepartment department, Event reuqestedEvent, double ammount, string reason)
        {
            this.Department = department;
            this.Event = reuqestedEvent;
            this.Ammount = ammount;
            this.Reason = reason;
        }

        public RequestingDepartment Department { get; }

        public Event Event { get; }

        public double Ammount { get; }

        public string Reason { get; }
    }
}

using System.ComponentModel;

namespace DataTier
{
    public class FinancialRequest
    {
        public FinancialRequest(RequestingDepartment department, Event reuqestedEvent, double ammount, string reason, User user)
        {
            this.Department = department;
            this.Event = reuqestedEvent;
            this.Ammount = ammount;
            this.Reason = reason;
            this.User = user;
        }

        public RequestingDepartment Department { get; }

        public Event Event { get; }

        public double Ammount { get; }

        public string Reason { get; }

        public User User { get; }

        [Browsable(false)]
        public bool Reviewed { get; set; }

        public bool Result { get; set; }
    }
}

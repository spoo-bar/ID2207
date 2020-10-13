using System;
using System.ComponentModel;

namespace DataTier
{
    public class EventRequest : IEvent
    {
        public EventRequest(string recordNr, Client client, string eventType, DateTime from, DateTime to, int attendees, double budget)
        {
            RecordNr = recordNr;
            Client = client;
            EventType = eventType;
            From = from;
            To = to;
            Attendees = attendees;
            Budget = budget;
            State = EventRequest.States.Created;
        }

        public string RecordNr { get; set; }
        [Browsable(false)]
        public Client Client { get; set; }
        public string EventType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Attendees { get; set; }
        public double Budget { get; set; }
        [Browsable(false)]
        public string FinancialFeedback { get; set; }
        [Browsable(false)]
        public States State { get; set; }

        public enum States
        {
            Created,
            ApprovedBySCSO,
            FinancialFeedbackAdded,
            Finalized
        }
    }
}

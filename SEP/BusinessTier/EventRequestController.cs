using DataTier;
using System;
using System.Collections.Generic;

namespace BusinessTier
{
    public class EventRequestController
    {
        private static List<EventRequest> eventRequests = Seed.EventRequests;

        public EventRequestController()
        {
        }

        public EventRequest Create(string recordNr, Client client, string eventType, DateTime from, DateTime to, decimal attendees, string budgetString)
        {
            try
            {
                if (from > to || client == null)
                    return null;

                double budget = double.Parse(budgetString);

                EventRequest eventRequest = new EventRequest(recordNr, client, eventType, from, to, Convert.ToInt32(attendees), budget);
                eventRequests.Add(eventRequest);
                return eventRequest;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void AddFeedback(string feedback, EventRequest eventRequest)
        {
            eventRequest.FinancialFeedback = feedback;
        }

        public List<EventRequest> EventRequests { get { return eventRequests; } }
    }
}

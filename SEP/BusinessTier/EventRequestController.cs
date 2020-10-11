using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class EventRequestController
    {
        private static List<EventRequest> eventRequests = new List<EventRequest>();
        private ClientController clientController;

        public EventRequestController()
        {
            clientController = new ClientController();
        }

        public bool Create(string recordNr, Client client, string eventType, DateTime from, DateTime to, decimal attendees, string budgetString)
        {
            try
            {
                if (from > to || client == null)
                    return false;

                double budget = double.Parse(budgetString);

                EventRequest eventRequest = new EventRequest(recordNr, client, eventType, from, to, Convert.ToInt32(attendees), budget);
                eventRequests.Add(eventRequest);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public EventRequest Find(string recordNr)
        {
            return eventRequests.Find(eventRequest => eventRequest.RecordNr.Equals(recordNr));
        }

        public List<EventRequest> EventRequests { get { return eventRequests; } }
    }
}

using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessTier
{
    public class EventRequestController
    {
        private static List<EventRequest> eventRequests = Seed.EventRequest;

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

        public bool ChangeState(EventRequest eventRequest, Role role, string feedback)
        {
            switch (role)
            {
                case Role.SeniorCustomerServiceOfficer:
                    eventRequest.State = EventRequest.States.ApprovedBySCSO;
                    return true;
                case Role.FinancialManager:
                    eventRequest.State = EventRequest.States.FinancialFeedbackAdded;
                    eventRequest.FinancialFeedback = feedback;
                    return true;
                case Role.AdministrationDepartmentManager:
                    eventRequest.State = EventRequest.States.Finalized;
                    new EventController().Create(eventRequest);
                    return true;
                default:
                    return false;
            }
        }

        public List<EventRequest> GetEventRequests(Role role)
        {
            switch (role)
            {
                case Role.SeniorCustomerServiceOfficer:
                    return eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.Created || eventRequest.State == EventRequest.States.Finalized).ToList();
                case Role.FinancialManager:
                    return eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.ApprovedBySCSO).ToList();
                case Role.AdministrationDepartmentManager:
                    return eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.FinancialFeedbackAdded).ToList();
                default:
                    return null;
            }
        }
    }
}

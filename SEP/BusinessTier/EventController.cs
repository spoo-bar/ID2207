using DataTier;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class EventController
    {
        public Event Create(EventRequest eventRequest)
        {
            var newEvent = new Event();
            newEvent.RecordNr = eventRequest.RecordNr;
            newEvent.Client = eventRequest.Client;
            newEvent.EventType = eventRequest.EventType;
            newEvent.Attendees = eventRequest.Attendees;
            newEvent.Budget = eventRequest.Budget;
            newEvent.From = eventRequest.From;
            newEvent.To = eventRequest.To;
            Seed.events.Add(newEvent);
            return newEvent;
        }

        public Event CreateTask(string recordNumber, EventTask task)
        {
            var ev = Seed.events.FirstOrDefault(events => events.RecordNr == recordNumber);
            if(ev != null)
            {
                ev.Tasks.Add(task);
                return ev;
            }
            else
            {
                throw new ApplicationException("Could not find task with that record number");
            }
        }

        public List<EventTask> GetTasks(User user)
        {
            List<EventTask> eventTasks = new List<EventTask>();
            foreach (Event evnt in Seed.events)
            {
                var userTasks = evnt.Tasks.Where(task => task.AssignedTo.Email.Equals(user.Email));
                eventTasks.AddRange(userTasks);
            }
            return eventTasks;
        }

        private List<Event> GetUserEvents(User user)
        {
            List<Event> userEvents = new List<Event>();
            foreach (Event evnt in Seed.events)
            {
                if(evnt.Tasks.Any(task => task.AssignedTo.Email.Equals(user.Email)))
                {
                    userEvents.Add(evnt);
                }
            }
            return userEvents;
        }

        public List<User> GetAvailableUsers(List<User> subordinates, DateTime from, DateTime to)
        {
            var users = new List<User>();
            foreach (User user in subordinates)
            {
                var events = GetUserEvents(user);
                if (events == null || events.Any(
                    ev => (ev.To < from || to < ev.From) &&
                    to > from))
                {
                    users.Add(user);
                }
            }
            return users;
        }

        public List<Event> GetEvents()
        {
            return Seed.events;
        }

    }
}

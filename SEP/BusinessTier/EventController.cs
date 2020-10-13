using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class EventController
    {
        private static List<Event> events = Seed.Events;

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
            events.Add(newEvent);
            return newEvent;
        }

        public Event CreateTask(string recordNumber, EventTask task)
        {
            var ev = events.FirstOrDefault(events => events.RecordNr == recordNumber);
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
            foreach (Event evnt in events)
            {
                var userTasks = evnt.Tasks.Where(task => task.AssignedTo.Email.Equals(user.Email));
                eventTasks.AddRange(userTasks);
            }
            return eventTasks;
        }

        public List<Event> GetEvents()
        {
            return events;
        }

    }
}

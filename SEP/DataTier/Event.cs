using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataTier
{
    public class Event : IEvent
    {
        public Event()
        {
            this.Tasks = new List<EventTask>();
        }

        public string RecordNr { get; set; }

        [Browsable(false)]
        public Client Client { get; set; }

        public string EventType { get; set; }

        public string Description { get; set; }

        public int Attendees { get; set; }

        public double Budget { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string Status { get; set; }

        public string Decorations { get; set; }

        public string FoodAndDrinks { get; set; }

        public string Filming { get; set; }

        public string Music { get; set; }

        public string Posters { get; set; }

        public string ComputerRelatedIssues { get; set; }

        public string OtherNeeds { get; set; }

        public List<EventTask> Tasks { get; set; }

        public override string ToString()
        {
            return RecordNr;
        }
    }
}

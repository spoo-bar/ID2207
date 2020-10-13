using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public interface IEvent
    {
        string RecordNr { get; set; }

        Client Client { get; set; }

        string EventType { get; set; }

        int Attendees { get; set; }

        double Budget { get; set; }

        DateTime From { get; set; }

        DateTime To { get; set; }
    }
}

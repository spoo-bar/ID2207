using System;
using System.Collections.Generic;

namespace DataTier
{
    public class EventTask
    {
        public string TaskID { get; set; }
        public string Description { get; set; }

        public User AssignedTo { get; set; }

        public List<TaskComment> TaskComments { get; set; }

        public EventTask()
        {
            this.TaskID = Guid.NewGuid().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataTier
{
    public class EventTask
    {
        [Browsable(false)]
        public string TaskID { get; }
        public string Description { get; set; }

        public User AssignedTo { get; set; }

        public List<TaskComment> TaskComments { get; set; }

        public EventTask()
        {
            this.TaskID = Guid.NewGuid().ToString();
        }
    }
}

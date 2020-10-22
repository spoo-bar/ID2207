using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataTier
{
    public class EventTask
    {
        public EventTask(string description, User user)
        {
            this.TaskID = Guid.NewGuid().ToString();
            Description = description;
            AssignedTo = user;
            TaskComments = new List<TaskComment>();
        }

        [Browsable(false)]
        public string TaskID { get; }

        public string Description { get; set; }

        public User AssignedTo { get; set; }

        public string Plan { get; set; }

        public List<TaskComment> TaskComments { get; set; }
    }
}

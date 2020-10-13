using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DataTier
{
    public class EventTask
    {
        private List<TaskComment> comments = new List<TaskComment>();

        [Browsable(false)]
        public string TaskID { get; }
        public string Description { get; set; }

        public User AssignedTo { get; set; }

        public string Plan { get; set; }

        public List<TaskComment> TaskComments { get => comments; set => comments = value; }

        public EventTask()
        {
            this.TaskID = Guid.NewGuid().ToString();
        }
    }
}

using System.ComponentModel;

namespace DataTier
{
    public class TaskComment
    {
        public string Comment { get; set; }

        [Browsable(false)]
        public User CommentBy { get; set; }
    }
}

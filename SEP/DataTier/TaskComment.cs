using System.ComponentModel;

namespace DataTier
{
    public class TaskComment
    {
        public TaskComment(string comment, User user)
        {
            Comment = comment;
            CommentBy = user;
        }

        public string Comment { get; set; }

        public User CommentBy { get; set; }
    }
}

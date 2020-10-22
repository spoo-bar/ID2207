using System.ComponentModel;

namespace DataTier
{
    public class TaskComment
    {
        //todo: not done yet
        public TaskComment(string comment, User user)
        {
            Comment = comment;
            CommentBy = user;
        }

        public string Comment { get; set; }

        [Browsable(false)]
        public User CommentBy { get; set; }
    }
}

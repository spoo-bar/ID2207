using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public IEnumerable<Permission> Permissions { get; set; }

    }

    public enum Permission
    {
        CreateEvent,
        EditEvent,
        ApproveEvent
    }
}

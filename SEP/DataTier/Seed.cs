using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class Seed
    {
        public static IEnumerable<User> Users
        {
            get
            {
                var sarahUser = new User()
                {
                    Email = "sarah@sep.se",
                    Password = "sarah_password",
                    Permissions = new List<Permission> { Permission.CreateEvent }
                };
                return new List<User>
                {
                    sarahUser
                };
            }
        }
    }
}

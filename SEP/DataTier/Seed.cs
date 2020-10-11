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
                var sarahUser = new User() // Customer Service
                {
                    Email = "sarah@sep.se",
                    Password = "password",
                    Permissions = new List<Permission> { Permission.CreateEvent }
                };
                var janetUser = new User() // Senior Customer Service Officer 
                {
                    Email = "janet@sep.se",
                    Password = "password",
                    Permissions = new List<Permission> { Permission.ApproveEvent }
                };
                var aliceUser = new User() // Financial Manager
                {
                    Email = "alice@sep.se",
                    Password = "password",
                    Permissions = new List<Permission> { Permission.EditEvent }
                };
                var mikeUser = new User() // Administration Department Manager
                {
                    Email = "mike@sep.se",
                    Password = "password",
                    Permissions = new List<Permission> { Permission.ApproveEvent}
                };
                return new List<User>
                {
                    sarahUser,
                    janetUser,
                    aliceUser,
                    mikeUser
                };
            }
        }
    }
}

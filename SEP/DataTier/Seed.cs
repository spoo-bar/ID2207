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
                    Role = Role.CustomerService
                };

                var janetUser = new User() // Senior Customer Service Officer 
                {
                    Email = "janet@sep.se",
                    Password = "password",
                    Role = Role.SeniorCustomerServiceOfficer
                };
                janetUser.AddSubordinate(sarahUser);

                var aliceUser = new User() // Financial Manager
                {
                    Email = "alice@sep.se",
                    Password = "password",
                    Role = Role.FinancialManager
                };

                var mikeUser = new User() // Administration Department Manager
                {
                    Email = "mike@sep.se",
                    Password = "password",
                    Role = Role.AdministrationDepartmentManager
                };
                mikeUser.AddSubordinate(janetUser);

                return new List<User>
                {
                    sarahUser,
                    janetUser,
                    aliceUser,
                    mikeUser
                };
            }
        }

        public static List<Client> Clients
        {
            get
            {
                var peter = new Client("Peter", "Pen", "238740291");
                var anna = new Client("Anna", "Bergman", "648878978");
                var jeff = new Client("Jeff", "Bezos", "4563444432");
                return new List<Client>
                {
                    peter,
                    anna,
                    jeff
                };
            }
        }

        public static List<EventRequest> EventRequest
        {
            get
            {
                EventRequest eventRequest = new EventRequest("123",
                                                Clients[0],
                                                "Party",
                                                DateTime.Now,
                                                DateTime.Now.AddDays(1),
                                                33,
                                                321);
                EventRequest approvedRequest = new EventRequest("52344",
                                                Clients[1],
                                                "Boat show",
                                                DateTime.Now.AddDays(30),
                                                DateTime.Now.AddDays(35),
                                                100,
                                                4500)
                { 
                    State = DataTier.EventRequest.States.ApprovedBySCSO 
                };
                EventRequest financialFeedbackAddedRequest = new EventRequest("72909",
                                                Clients[0],
                                                "Pain ball",
                                                DateTime.Now.AddDays(26),
                                                DateTime.Now.AddDays(26),
                                                5,
                                                50)
                {
                    State = DataTier.EventRequest.States.FinancialFeedbackAdded
                };
                EventRequest finalizedRequest = new EventRequest("43555",
                                                Clients[2],
                                                "Trip to moon",
                                                DateTime.Now.AddDays(45),
                                                DateTime.Now.AddDays(67),
                                                2,
                                                10000000)
                {
                    State = DataTier.EventRequest.States.Finalized
                };
                return new List<EventRequest>
                {
                    eventRequest,
                    approvedRequest,
                    financialFeedbackAddedRequest,
                    finalizedRequest
                };
            }
        }

    }
}

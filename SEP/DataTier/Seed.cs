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


                var tobiasUser = new User() // Photographer
                {
                    Email = "tobias@sep.se",
                    Password = "password",
                    Role = Role.Photographer
                };

                var juliaUser = new User() // Graphic Designer
                {
                    Email = "julia@sep.se",
                    Password = "password",
                    Role = Role.GraphicDesigner
                };

                var jackUser = new User() // Production Manager
                {
                    Email = "jack@sep.se",
                    Password = "password",
                    Role = Role.ProductionManager,
                };
                jackUser.AddSubordinate(tobiasUser);
                jackUser.AddSubordinate(juliaUser);

                var helenUser = new User() // Top Chef
                {
                    Email = "helen@sep.se",
                    Password = "password",
                    Role = Role.TopChef
                };

                var kateUser = new User() // Senior Waitress
                {
                    Email = "kate@sep.se",
                    Password = "password",
                    Role = Role.SeniorWaitress
                };

                var natalieUser = new User() // Services Department Manager
                {
                    Email = "natalie@sep.se",
                    Password = "password",
                    Role = Role.ServicesDepartmentManager,
                };
                helenUser.AddSubordinate(helenUser);
                helenUser.AddSubordinate(kateUser);

                return new List<User>
                {
                    sarahUser,
                    janetUser,
                    aliceUser,
                    mikeUser,
                    jackUser,
                    tobiasUser,
                    juliaUser,
                    helenUser,
                    kateUser,
                    natalieUser
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

        public static List<Event> Events
        {
            get
            {
                var newevent = new Event()
                {
                    RecordNr = "97438",
                    Client = Clients[0],
                    From = DateTime.Now.AddDays(25),
                    To = DateTime.Now.AddDays(35),
                    EventType = "Workshop",
                    Attendees = 200,
                    Budget = 500000,
                    Description = "Workshop about Software Engineering",
                    Decorations = "Special Lighting",
                    FoodAndDrinks = "Fika at 8:30am",
                    Filming = "Pictures of Audience",
                    Music = "Music played during breaks",
                    Posters = "One poster at the entrace",
                    ComputerRelatedIssues = "Wifi should be available",
                    OtherNeeds = ""
                };
                return new List<Event>() {
                    newevent
                };
            }
        }

    }
}

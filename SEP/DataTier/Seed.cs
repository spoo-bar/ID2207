using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTier
{
    public class Seed
    {
        public static IEnumerable<User> users = Users;
        private static IEnumerable<User> Users
        {
            get
            {
                // Customer Service
                var sarahUser = new User("sarah@sep.se","password",User.Roles.CustomerService);

                // Senior Customer Service Officer 
                var janetUser = new User("janet@sep.se", "password", User.Roles.SeniorCustomerServiceOfficer);
                janetUser.AddSubordinate(sarahUser);

                // Financial Manager
                var aliceUser = new User("alice@sep.se", "password", User.Roles.FinancialManager);

                // Administration Department Manager
                var mikeUser = new User("mike@sep.se", "password", User.Roles.AdministrationDepartmentManager);
                mikeUser.AddSubordinate(janetUser);
                mikeUser.AddSubordinate(janetUser);

                // Photographer
                var tobiasUser = new User("tobias@sep.se", "password", User.Roles.Photographer);

                // Graphic Designer
                var juliaUser = new User("julia@sep.se", "password", User.Roles.GraphicDesigner);

                // Production Manager
                var jackUser = new User("jack@sep.se", "password", User.Roles.ProductionManager);
                jackUser.AddSubordinate(tobiasUser);
                jackUser.AddSubordinate(juliaUser);

                // Top Chef
                var helenUser = new User("helen@sep.se", "password", User.Roles.TopChef);

                // Senior Waitress
                var kateUser = new User("kate@sep.se", "password", User.Roles.SeniorWaitress);

                // Services Department Manager
                var natalieUser = new User("natalie@sep.se", "password", User.Roles.ServicesDepartmentManager);
                helenUser.AddSubordinate(helenUser);
                helenUser.AddSubordinate(kateUser);

                // Senior HR Manager
                var simonUser = new User("simon@sep.se", "password", User.Roles.SeniorHRManager);
                mikeUser.AddSubordinate(simonUser);

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
                    natalieUser,
                    simonUser
                };
            }
        }

        public static List<Client> clients = Clients;
        private static List<Client> Clients
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

        public static List<EventRequest> eventRequests = EventRequests;
        private static List<EventRequest> EventRequests
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

        public static List<Event> events = Events;
        private static List<Event> Events
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

                var eventTask = new EventTask("test description", users.ToList()[5]);

                newevent.Tasks.Add(eventTask);
                return new List<Event>() {
                    newevent
                };
            }
        }

        public static List<RecruitmentRequest> recruitmentRequests = RecruitmentRequests;
        private static List<RecruitmentRequest> RecruitmentRequests
        {
            get
            {
                var recruitmentRequest = new RecruitmentRequest(Contractype.PartTime, 
                    RequestingDepartment.Production, 
                    3, 
                    "Graphic Designer", 
                    "");
                return new List<RecruitmentRequest>
                {
                    recruitmentRequest
                };
            }
        }

        public static List<FinancialRequest> financialRequests = FinancialRequests;
        private static List<FinancialRequest> FinancialRequests
        {
            get
            {
                var financialRequest = new FinancialRequest(
                    RequestingDepartment.Production,
                    Events[0],
                    123.4,
                    "Having Picasso painting is not cheap");
                return new List<FinancialRequest>
                {
                    financialRequest
                };
            }
        }
    }
}

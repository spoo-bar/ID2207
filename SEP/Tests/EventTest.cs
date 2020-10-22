using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class EventTest
    {
        readonly EventController eventController = new EventController();

        [TestMethod]
        public void CreateTest()
        {
            // Arrange
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);

            // Act
            var ev = eventController.Create(eventRequest);

            // Assert
            Assert.AreEqual(eventRequest.RecordNr, ev.RecordNr);
            Assert.AreEqual(eventRequest.Client.GetHashCode(), ev.Client.GetHashCode());
            Assert.AreEqual(eventRequest.EventType, ev.EventType);
            Assert.AreEqual(eventRequest.From, ev.From);
            Assert.AreEqual(eventRequest.To, ev.To);
            Assert.AreEqual(eventRequest.Attendees, ev.Attendees);
            Assert.AreEqual(eventRequest.Budget, ev.Budget);
        }

        [TestMethod]
        public void CreateTaskTest()
        {
            // Arrange
            string recordNumber = "123";
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var eventTask = new EventTask("test description",user);

            // Act
            var ev = eventController.CreateTask(recordNumber, eventTask);

            // Assert
            Assert.IsTrue(ev.Tasks.Count == 1);
            Assert.IsNotNull(ev.Tasks.First().TaskID);
            Assert.AreEqual(eventTask.Description, ev.Tasks.First().Description);
            Assert.AreEqual(eventTask.AssignedTo.Email, ev.Tasks.First().AssignedTo.Email);
        }

        [TestMethod]
        public void CreateTaskEventDoesNotExistTest()
        {
            // Arrange
            string recordNumber = "123";
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var eventTask = new EventTask("test description", user);

            // Act
            var exception = Assert.ThrowsException<ApplicationException>(() => eventController.CreateTask(recordNumber, eventTask));


            // Assert
            Assert.AreEqual("Could not find task with that record number", exception.Message);
        }

        [TestMethod]
        public void GetAllEvents()
        {
            // Arrange
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);

            // Act
            var events = eventController.GetEvents();

            // Assert
            Assert.IsTrue(events.Count > 0);
        }

        [TestMethod]
        public void GetUsersTasks()
        {
            // Arrange
            Seed.events = new List<Event>();
            string recordNumber = "123";
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var tasks = eventController.GetTasks(user);

            // Assert
            Assert.AreEqual(1, tasks.Count);
        }

        [TestMethod]
        public void GetUsersTasks_noTask()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            // Act
            var tasks = eventController.GetTasks(user);

            // Assert
            Assert.AreEqual(0, tasks.Count);
        }

        [TestMethod]
        public void GetAvailableUsers()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            string recordNumber = "123";
            int oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(6), DateTime.Now.AddDays(7)).Count;
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(5),
                                                33, 321);
            eventController.Create(eventRequest);

            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(6), DateTime.Now.AddDays(7));

            // Assert
            Assert.AreEqual(oldUserCount, users.Count);
        }

        [TestMethod]
        public void GetAvailableUsers_SameDates()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            string recordNumber = "123";
            int oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now, DateTime.Now.AddDays(5)).Count;
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(5),
                                                33, 321);
            eventController.Create(eventRequest);

            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now, DateTime.Now.AddDays(5));

            // Assert
            Assert.AreEqual(oldUserCount - 1, users.Count);
        }

        [TestMethod]
        public void GetAvailableUsers_BeginningOverlaps()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            string recordNumber = "123";
            int oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(3), DateTime.Now.AddDays(7)).Count;
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(5),
                                                33, 321);
            eventController.Create(eventRequest);

            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(3), DateTime.Now.AddDays(7));

            // Assert
            Assert.AreEqual(oldUserCount - 1, users.Count);
        }

        [TestMethod]
        public void GetAvailableUsers_EndOverlaps()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            string recordNumber = "123";
            int oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2)).Count;
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(5),
                                                33, 321);
            eventController.Create(eventRequest);

            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2));

            // Assert
            Assert.AreEqual(oldUserCount - 1, users.Count);
        }

        [TestMethod]
        public void GetAvailableUsers_InTheMiddle()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);

            string recordNumber = "123";
            int oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3)).Count;
            var eventRequest = new EventRequest(recordNumber, new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(5),
                                                33, 321);
            eventController.Create(eventRequest);

            var eventTask = new EventTask("test description", user);
            eventController.CreateTask(recordNumber, eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3));

            // Assert
            Assert.AreEqual(oldUserCount - 1, users.Count);
        }
    }
}

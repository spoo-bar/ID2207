using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class EventTest
    {
        EventController eventController = new EventController();

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
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            var eventTask = new EventTask("test description",new User("abcd@xy.z", "", User.Roles.Photographer));

            // Act
            var ev = eventController.CreateTask("123", eventTask);

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
            var eventTask = new EventTask("test description", new User("abcd@xy.z", "", User.Roles.Photographer));

            // Act
            var exception = Assert.ThrowsException<ApplicationException>(() => eventController.CreateTask("123", eventTask));


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
            var eventTask = new EventTask("test description", new User("abcd@xy.z", "", User.Roles.Photographer));

            // Act
            var events = eventController.GetEvents();

            // Assert
            Assert.IsTrue(events.Count >= 2);
        }

        [TestMethod]
        public void GetTasks()
        {
            // Arrange
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var oldTasksCount = eventController.GetTasks(user).Count;
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            var eventTask = new EventTask("test description", user);
            eventController.CreateTask("123", eventTask);

            // Act
            var tasks = eventController.GetTasks(user);

            // Assert
            Assert.AreEqual(oldTasksCount+1, tasks.Count);
        }

        [TestMethod]
        public void GetTasks_noTask()
        {
            // Arrange
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var oldTasksCount = eventController.GetTasks(user).Count;
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);

            // Act
            var tasks = eventController.GetTasks(user);

            // Assert
            Assert.AreEqual(oldTasksCount, tasks.Count);
        }

        [TestMethod]
        public void GetAvailableUsers()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now, DateTime.Now.AddDays(1)).Count;
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            var eventTask = new EventTask("test description", user);
            eventController.CreateTask("123", eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3));

            // Assert
            Assert.AreEqual(oldUserCount + 1, users.Count);
        }

        [TestMethod]
        public void GetAvailableUsers_overlap()
        {
            // Arrange
            Seed.events = new List<Event>();
            User user = new User("abcd@xy.z", "", User.Roles.Photographer);
            var oldUserCount = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now, DateTime.Now.AddDays(1)).Count;
            var eventRequest = new EventRequest("123", new Client("Peter", "Pen", "238740291"), "Party",
                                                DateTime.Now, DateTime.Now.AddDays(1),
                                                33, 321);
            eventController.Create(eventRequest);
            var eventTask = new EventTask("test description", user);
            eventController.CreateTask("123", eventTask);

            // Act
            var users = eventController.GetAvailableUsers(new List<User> { user }, DateTime.Now, DateTime.Now.AddDays(1));

            // Assert
            Assert.AreEqual(oldUserCount, users.Count);
        }
    }
}

using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class EventRequestTest
    {
        //todo: make tests better for CreateEventRequest
        [TestMethod]
        public void CreateEventRequest()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            bool result = eventRequestController.Create("123abc", new Client("","",""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsTrue(result);
            Assert.AreNotEqual(eventRequestController.EventRequests.Count, 0);
        }

        [TestMethod]
        public void CreateEventRequest_badBudget()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            bool result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "fdgdg");

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual(eventRequestController.EventRequests.Count, 0);
        }

        [TestMethod]
        public void CreateEventRequest_NoClient()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            bool result = eventRequestController.Create("123abc", null, "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual(eventRequestController.EventRequests.Count, 0);
        }

        [TestMethod]
        public void CreateEventRequest_FromBiggerThanTo()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            bool result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now.AddDays(1), DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual(eventRequestController.EventRequests.Count, 0);
        }

        [DataTestMethod]
        [DataRow("123abc", true)]
        [DataRow("wrongNr", false)]
        public void FindEventRequest(string recordNr, bool exists)
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();
            eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            EventRequest eventRequest = eventRequestController.Find(recordNr);

            //Assert
            Assert.AreEqual(eventRequest != null, exists);
        }
    }
}

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
            EventRequest result = eventRequestController.Create("123abc", new Client("","",""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, eventRequestController.EventRequests.Count);
        }

        [TestMethod]
        public void CreateEventRequest_badBudget()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            EventRequest result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "fdgdg");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(0, eventRequestController.EventRequests.Count);
        }

        [TestMethod]
        public void CreateEventRequest_NoClient()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            EventRequest result = eventRequestController.Create("123abc", null, "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(0, eventRequestController.EventRequests.Count);
        }

        [TestMethod]
        public void CreateEventRequest_FromBiggerThanTo()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();

            //Act
            EventRequest result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now.AddDays(1), DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(0, eventRequestController.EventRequests.Count);
        }

        [DataTestMethod]
        [DataRow("test")]
        public void AddFeedbackToEventRequest(string feedback)
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            eventRequestController.AddFeedback(feedback, eventRequest);

            //Assert
            Assert.AreEqual(feedback, eventRequest.FinancialFeedback);
        }

        [DataTestMethod]
        [DataRow(EventRequest.States.Created)]
        [DataRow(EventRequest.States.ApprovedBySCSO)]
        [DataRow(EventRequest.States.FinancialFeedbackAdded)]
        [DataRow(EventRequest.States.Finalized)]
        public void UpdateEventRequestStatus(EventRequest.States state)
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.EventRequests.Clear();
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            eventRequestController.ChangeState(eventRequest, state);

            //Assert
            Assert.AreEqual(state, eventRequest.State);
        }
    }
}

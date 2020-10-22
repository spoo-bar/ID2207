using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class EventRequestTest
    {
        //todo: make all test better
        [TestMethod]
        public void CreateEventRequest()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            int eventRequestCount = eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count;

            //Act
            EventRequest result = eventRequestController.Create("123abc", new Client("","",""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(eventRequestCount + 1, eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count);
        }

        [TestMethod]
        public void CreateEventRequest_badBudget()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            int eventRequestCount = eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count;

            //Act
            EventRequest result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "fdgdg");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(eventRequestCount, eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count);
        }

        [TestMethod]
        public void CreateEventRequest_NoClient()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            int eventRequestCount = eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count;

            //Act
            EventRequest result = eventRequestController.Create("123abc", null, "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(eventRequestCount, eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count);
        }

        [TestMethod]
        public void CreateEventRequest_FromBiggerThanTo()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            int eventRequestCount = eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count;

            //Act
            EventRequest result = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now.AddDays(1), DateTime.Now, 3, "23.4");

            //Assert
            Assert.IsNull(result);
            Assert.AreEqual(eventRequestCount, eventRequestController.GetEventRequests(User.Roles.SeniorCustomerServiceOfficer).Count);
        }

        [TestMethod]
        public void UpdateEventRequestStatus_CreateEvent()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();

            //Act
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Assert
            Assert.AreEqual(EventRequest.States.Created, eventRequest.State);
        }

        [TestMethod]
        public void UpdateEventRequestStatus_ApproveRequest()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            eventRequestController.ChangeState(eventRequest, User.Roles.SeniorCustomerServiceOfficer, "");

            //Assert
            Assert.AreEqual(EventRequest.States.ApprovedBySCSO, eventRequest.State);
        }

        [TestMethod]
        public void UpdateEventRequestStatus_EditEvent()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            eventRequestController.ChangeState(eventRequest, User.Roles.FinancialManager, "");

            //Assert
            Assert.AreEqual(EventRequest.States.FinancialFeedbackAdded, eventRequest.State);
        }

        [TestMethod]
        public void UpdateEventRequestStatus_ApproveEvent()
        {
            //Arrange
            EventRequestController eventRequestController = new EventRequestController();
            EventRequest eventRequest = eventRequestController.Create("123abc", new Client("", "", ""), "", DateTime.Now, DateTime.Now, 3, "23.4");

            //Act
            eventRequestController.ChangeState(eventRequest, User.Roles.AdministrationDepartmentManager, "");

            //Assert
            Assert.AreEqual(EventRequest.States.Finalized, eventRequest.State);
        }
    }
}

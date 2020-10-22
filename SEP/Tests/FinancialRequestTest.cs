using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class FinancialRequestTest
    {
        private readonly FinancialRequestController financialRequestController = new FinancialRequestController();

        [TestMethod]
        public void GetFinancialRequestsTest()
        {
            // Arrange

            // Act
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests();

            // Assert
            Assert.AreNotEqual(null, financialRequests);
        }

        [TestMethod]
        public void AddFinancialRequestTest()
        {
            // Arrange
            int oldCount = financialRequestController.GetFinancialRequests().Count;

            // Act
            financialRequestController.AddFinancialRequest(RequestingDepartment.Administration, new Event(), "122", "test");
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests();

            // Assert
            Assert.AreEqual(oldCount + 1, financialRequests.Count);
        }

        [TestMethod]
        public void SolveFinancialRequestTest()
        {
            // Arrange
            financialRequestController.AddFinancialRequest(RequestingDepartment.Administration, new Event(), "122", "test");
            int oldCount = financialRequestController.GetFinancialRequests().Count;

            // Act
            financialRequestController.SolveFinancialRequest(financialRequestController.GetFinancialRequests()[0]);
            List<FinancialRequest> financialRequests = financialRequestController.GetFinancialRequests();

            // Assert
            Assert.AreEqual(oldCount - 1, financialRequests.Count);
        }
    }
}

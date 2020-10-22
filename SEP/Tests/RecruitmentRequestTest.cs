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
    public class RecruitmentRequestTest
    {
        private RecruitmentRequestController recruitmentRequestController = new RecruitmentRequestController();

        [TestMethod]
        public void GetRecruitmentRequestTest()
        {
            // Arrange
            var expectedRecruitmentRequest = new RecruitmentRequest(Contractype.PartTime, RequestingDepartment.Production, 3, "Graphic Designer", "");

            // Act
            var recruitmentRequests = recruitmentRequestController.GetRecruitmentRequests();

            // Assert
            Assert.IsTrue(recruitmentRequests.Count >= 1);
            Assert.AreEqual(expectedRecruitmentRequest.Contractype, recruitmentRequests.First().Contractype);
            Assert.AreEqual(expectedRecruitmentRequest.RequestingDepartment, recruitmentRequests.First().RequestingDepartment);
            Assert.AreEqual(expectedRecruitmentRequest.YearsOfExperience, recruitmentRequests.First().YearsOfExperience);
            Assert.AreEqual(expectedRecruitmentRequest.JobTitle, recruitmentRequests.First().JobTitle);
            Assert.AreEqual(expectedRecruitmentRequest.JobDescription, recruitmentRequests.First().JobDescription);
        }

        [TestMethod]
        public void CreateRecreuitmentRequestTest()
        {
            // Arrange
            var contractType = Contractype.FullTime;
            var requestingDepartment = RequestingDepartment.Financial;
            var yearsOfExp = "10";
            var jobTitle = "Financial Manager";
            var jobDescrimination = "";

            // Act
            var requirementRequest = recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExp, jobTitle, jobDescrimination);

            // Assert
            Assert.IsNotNull(requirementRequest);
            Assert.AreEqual(contractType, requirementRequest.Contractype);
            Assert.AreEqual(requestingDepartment, requirementRequest.RequestingDepartment);
            Assert.AreEqual(yearsOfExp, requirementRequest.YearsOfExperience.ToString());
            Assert.AreEqual(jobTitle, requirementRequest.JobTitle);
            Assert.AreEqual(jobDescrimination, requirementRequest.JobDescription);
        }

        [TestMethod]
        public void CreateRecreuitmentRequest_EmptyYearsTest()
        {
            // Arrange
            var contractType = Contractype.FullTime;
            var requestingDepartment = RequestingDepartment.Financial;
            var yearsOfExp = "";
            var jobTitle = "Financial Manager";
            var jobDescrimination = "";

            // Act
            var exception = Assert.ThrowsException<ApplicationException>(() => recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExp, jobTitle, jobDescrimination));


            // Assert
            Assert.AreEqual("Years of experience for the job is not specified", exception.Message);
        }

        [TestMethod]
        public void CreateRecreuitmentRequest_EmptyJobTitleTest()
        {
            // Arrange
            var contractType = Contractype.FullTime;
            var requestingDepartment = RequestingDepartment.Financial;
            var yearsOfExp = "10 years";
            var jobTitle = "";
            var jobDescrimination = "";

            // Act
            var exception = Assert.ThrowsException<ApplicationException>(() => recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExp, jobTitle, jobDescrimination));


            // Assert
            Assert.AreEqual("Job Title is not specified", exception.Message);
        }
    }
}

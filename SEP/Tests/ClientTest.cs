using BusinessTier;
using DataTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void CreateClient()
        {
            //Arrange
            ClientController clientController = new ClientController();
            clientController.Clients.Clear();

            //Act
            clientController.Create("testName", "testSurname", "testPhone");

            //Assert
            Assert.AreNotEqual(clientController.Clients.Count, 0);
        }
    }
}

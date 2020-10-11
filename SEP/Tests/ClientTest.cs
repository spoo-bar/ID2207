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

        [DataTestMethod]
        [DataRow("testName", true)]
        [DataRow("wrongName", false)]
        public void FindClient(string name, bool exists)
        {
            //Arrange
            ClientController clientController = new ClientController();
            clientController.Clients.Clear();
            clientController.Create("testName", "testSurname", "testPhone");

            //Act
            Client client = clientController.Find(name);

            //Assert
            Assert.AreEqual(client != null, exists);
        }
    }
}

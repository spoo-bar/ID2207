using BusinessTier;
using BusinessTier.Exceptions;
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
    public class LoginTest
    {
        private LoginController LoginController = new LoginController();

        [TestMethod]
        public void IncorrectEmail()
        {
            // Arrange
            var email = "abcd";
            var password = "password";

            // Act && Assert
            var exception = Assert.ThrowsException<LoginException>(() => LoginController.Login(email, password));
            Assert.AreEqual("Could not find user with that email", exception.Message);

        }

        [TestMethod]
        public void CorrectEmail_IncorrectPassword()
        {
            // Arrange
            var email = "sarah@sep.se";
            var password = "wrongPassword";

            // Act && Assert
            var exception = Assert.ThrowsException<LoginException>(() => LoginController.Login(email, password));
            Assert.AreEqual("Incorrect password was entered", exception.Message);
        }

        [TestMethod]
        public void CorrectEmail_CorrectPassword()
        {
            // Arrange
            var email = "sarah@sep.se";
            var password = "password";
            var expectedUser = new User(email, password, User.Roles.Photographer);

            // Act
            var user = LoginController.Login(email, password);

            // Assert
            Assert.AreEqual(expectedUser.Email, user.Email);
            Assert.AreEqual(expectedUser.Password, user.Password);
        }
    }
}

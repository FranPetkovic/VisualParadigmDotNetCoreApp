using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class UporabnikControllerTests
    {
        [Fact]
        public void Index_ReturnsCorrectContentResult()
        {
            // Arrange
            var controller = new UporabnikController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("User: Janez Novak, Location: Ljubljana", contentResult.Content);
        }

        [Fact]
        public void Login_ReturnsSuccessMessage_WhenCredentialsAreValid()
        {
            // Arrange
            var controller = new UporabnikController();
            string username = "jnovak";
            string password = "password123";

            // Act
            var result = controller.Login(username, password);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal($"User {username} logged in successfully.", contentResult.Content);
        }

        [Fact]
        public void Login_ReturnsFailureMessage_WhenCredentialsAreInvalid()
        {
            // Arrange
            var controller = new UporabnikController();
            string username = "jnovak";
            string password = "wrongpassword";

            // Act
            var result = controller.Login(username, password);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Invalid username or password.", contentResult.Content);
        }
    }
}

using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class PickUpServisControllerTests
    {
        [Fact]
        public void Index_ReturnsCorrectContentResult()
        {
            // Arrange
            var controller = new PickUpServisController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Pickup Service: Location: Ljubljana, Time: 2024-12-05 10:00, Status: Scheduled", contentResult.Content);
        }

        [Fact]
        public void OrganizePickup_ReturnsSuccessMessage_WhenPickupIsOrganized()
        {
            // Arrange
            var controller = new PickUpServisController();

            // Act
            var result = controller.OrganizePickup();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Pickup organized at Maribor on 2024-12-05 10:00.", contentResult.Content);
        }

        [Fact]
        public void NotifyUser_ReturnsCorrectMessage_WhenUserIsNotified()
        {
            // Arrange
            var controller = new PickUpServisController();
            string userId = "123"; // Example user ID

            // Act
            var result = controller.NotifyUser(userId);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal($"User with ID: {userId} has been notified.", contentResult.Content);
        }
    }
}

using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class RecycleLokacijaControllerTests
    {

        [Fact]
        public void AddLocation_ReturnsSuccessMessage_WhenLocationIsAdded()
        {
            // Arrange
            var controller = new RecycleLokacijaController();
            string newLocation = "Maribor Recycling Center";

            // Act
            var result = controller.AddLocation(newLocation);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal($"Location {newLocation} added successfully.", contentResult.Content);
        }

    }
}

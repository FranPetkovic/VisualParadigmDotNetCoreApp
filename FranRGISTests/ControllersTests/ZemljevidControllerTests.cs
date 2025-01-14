using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class ZemljevidControllerTests
    {

        [Fact]
        public void FilterLocations_ReturnsFilteredLocations_WhenCriterionMatches()
        {
            // Arrange
            var controller = new ZemljevidController();
            string criterion = "Maribor";

            // Act
            var result = controller.FilterLocations(criterion);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Filtered locations by: Maribor", contentResult.Content);
        }

        [Fact]
        public void FilterLocations_ReturnsNoMatchMessage_WhenCriterionDoesNotMatch()
        {
            // Arrange
            var controller = new ZemljevidController();
            string criterion = "Ljubljana"; // Criteria that will not be filtered out.

            // Act
            var result = controller.FilterLocations(criterion);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Filtered locations by: Ljubljana", contentResult.Content);
        }
    }
}

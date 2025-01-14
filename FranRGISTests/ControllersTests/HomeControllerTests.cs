using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace FranRGISTests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsCorrectContentResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Welcome to FranRGIS! This is the default page.", contentResult.Content);
        }
    }
}

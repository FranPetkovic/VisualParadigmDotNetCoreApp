using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class OdkupElektronikeControllerTests
    {
        [Fact]
        public void Index_ReturnsCorrectContentResult()
        {
            // Arrange
            var controller = new OdkupElektronikeController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Device: Laptop, Condition: Rabljeno - Dobro, Price: 450", contentResult.Content);
        }
    }
}

using Xunit;
using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.Controllers
{
    public class OglasiControllerTests
    {
        [Fact]
        public void Index_ReturnsCorrectContentResult()
        {
            // Arrange
            var controller = new OglasiController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Ad: Prodaja Laptopa, Description: Rabljeni laptop u odličnom stanju., Price: 650, Images: laptop.jpg", contentResult.Content);
        }

        [Fact]
        public void Publish_ReturnsSuccessMessage_WhenAdIsPublished()
        {
            // Arrange
            var controller = new OglasiController();

            // Act
            var result = controller.Publish();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Ad 'Prodaja Laptopa' published successfully!", contentResult.Content);
        }

        [Fact]
        public void Review_ReturnsCorrectReviewMessage()
        {
            // Arrange
            var controller = new OglasiController();
            string adId = "1"; // This can be any string that matches your logic for "oglasId"

            // Act
            var result = controller.Review(adId);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Reviewing ad with ID: 1", contentResult.Content);
        }
    }
}

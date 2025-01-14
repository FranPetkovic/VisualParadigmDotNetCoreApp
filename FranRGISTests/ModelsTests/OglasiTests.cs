using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class OglasiTests
    {
        [Fact]
        public void ObjaviOglas_ReturnsTrue_WhenCalled()
        {
            // Arrange
            var ad = new Oglasi
            {
                Naziv = "Prodaja Laptopa"
            };

            // Act
            var result = ad.ObjaviOglas();

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void PreglejOglas_ReturnsCorrectReviewMessage()
        {
            // Arrange
            var ad = new Oglasi();
            string adId = "123"; // Example ad ID

            // Act
            var result = ad.PreglejOglas(adId);

            // Assert
            Assert.Equal("Reviewing ad with ID: 123", result); // Expected review message
        }

        [Fact]
        public void Oglasi_ShouldHaveProperties()
        {
            // Arrange
            var ad = new Oglasi
            {
                Naziv = "Prodaja Laptopa",
                Opis = "Laptop in great condition",
                Slike = "laptop.jpg",
                Cena = 650.0
            };

            // Act & Assert
            Assert.NotNull(ad.Naziv);
            Assert.NotNull(ad.Opis);
            Assert.NotNull(ad.Slike);
            Assert.NotNull(ad.Cena);
        }
    }
}

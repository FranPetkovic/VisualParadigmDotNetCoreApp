using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class RecycleLokacijaTests
    {
        [Fact]
        public void PrikazLokacije_ReturnsCorrectString()
        {
            // Arrange
            var location = new RecycleLokacija
            {
                Naslov = "Ljubljana Recycling Center",
                OdpiralniCas = "08:00 - 16:00"
            };

            // Act
            var result = location.PrikazLokacije();

            // Assert
            Assert.Equal("Location: Ljubljana Recycling Center, Open Hours: 08:00 - 16:00", result);
        }

        [Fact]
        public void DodajLokacijo_ReturnsTrue_WhenCalled()
        {
            // Arrange
            var location = new RecycleLokacija();

            // Act
            var result = location.DodajLokacijo("Maribor Recycling Center");

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void RecycleLokacija_ShouldHaveProperties()
        {
            // Arrange
            var location = new RecycleLokacija
            {
                Naslov = "Ljubljana Recycling Center",
                OdpiralniCas = "08:00 - 16:00"
            };

            // Act & Assert
            Assert.NotNull(location.Naslov);
            Assert.NotNull(location.OdpiralniCas);
        }
    }
}

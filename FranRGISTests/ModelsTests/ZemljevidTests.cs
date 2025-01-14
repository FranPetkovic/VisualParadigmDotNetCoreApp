using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class ZemljevidTests
    {
        [Fact]
        public void PrikaziZemljovid_ReturnsCorrectString()
        {
            // Arrange
            var map = new Zemljevid
            {
                Lokacije = "Ljubljana, Maribor, Celje",
                TrenutnaLokacija = "Ljubljana"
            };

            // Act
            var result = map.PrikaziZemljovid();

            // Assert
            Assert.Equal("Map showing: Ljubljana, Maribor, Celje. Current location: Ljubljana.", result);
        }

        [Fact]
        public void FiltrirajLokacije_ReturnsCorrectFilteredLocations()
        {
            // Arrange
            var map = new Zemljevid
            {
                Lokacije = "Ljubljana, Maribor, Celje"
            };
            string filterCriteria = "Maribor";

            // Act
            var result = map.FiltrirajLokacije(filterCriteria);

            // Assert
            Assert.Equal("Filtered locations by: Maribor", result);
        }
    }
}

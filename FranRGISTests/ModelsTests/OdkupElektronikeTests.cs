using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class OdkupElektronikeTests
    {
        [Fact]
        public void OceniVrednost_ReturnsCorrectValue()
        {
            // Arrange
            var device = new OdkupElektronike
            {
                Cena = 1000.0 // Example price
            };

            // Act
            var result = device.OceniVrednost();

            // Assert
            Assert.Equal(800.0, result); // 1000 * 0.8 = 800
        }

        [Fact]
        public void OddajZahtevo_ReturnsTrue()
        {
            // Arrange
            var device = new OdkupElektronike();

            // Act
            var result = device.OddajZahtevo("Test Request");

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void OdkupElektronike_ShouldHaveProperties()
        {
            // Arrange
            var device = new OdkupElektronike
            {
                VrstaNaprave = "Laptop",
                StanjeNaprave = "Good",
                Cena = 450.0
            };

            // Act & Assert
            Assert.NotNull(device.VrstaNaprave);
            Assert.NotNull(device.StanjeNaprave);
            Assert.NotNull(device.Cena);
        }
    }
}

using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class AdministratorTests
    {


        [Fact]
        public void PreglejZahtevo_ShouldThrowNotImplementedException()
        {
            // Arrange
            var administrator = new Administrator();

            // Act & Assert
            var exception = Assert.Throws<NotImplementedException>(() => administrator.PreglejZahtevo("Test Request"));
            Assert.Equal("Not implemented", exception.Message);
        }

        [Fact]
        public void PotrdiOglas_ShouldThrowNotImplementedException()
        {
            // Arrange
            var administrator = new Administrator();

            // Act & Assert
            var exception = Assert.Throws<NotImplementedException>(() => administrator.PotrdiOglas("Test Ad"));
            Assert.Equal("Not implemented", exception.Message);
        }

        [Fact]
        public void UrediLokacije_ShouldThrowNotImplementedException()
        {
            // Arrange
            var administrator = new Administrator();

            // Act & Assert
            var exception = Assert.Throws<NotImplementedException>(() => administrator.UrediLokacije("Test Location"));
            Assert.Equal("Not implemented", exception.Message);
        }

        [Fact]
        public void UrediUporabnik_ShouldThrowNotImplementedException()
        {
            // Arrange
            var administrator = new Administrator();

            // Act & Assert
            var exception = Assert.Throws<NotImplementedException>(() => administrator.UrediUporabnik(null));
            Assert.Equal("Not implemented", exception.Message);
        }
    }
}

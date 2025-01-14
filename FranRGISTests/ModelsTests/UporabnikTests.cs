using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class UporabnikTests
    {
        [Fact]
        public void PrijaviSe_ReturnsTrue_WhenCredentialsAreCorrect()
        {
            // Arrange
            var user = new Uporabnik
            {
                UporabniskoIme = "jnovak",
                Geslo = "password123"
            };

            // Act
            var result = user.PrijaviSe("jnovak", "password123");

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void PrijaviSe_ReturnsFalse_WhenCredentialsAreIncorrect()
        {
            // Arrange
            var user = new Uporabnik
            {
                UporabniskoIme = "jnovak",
                Geslo = "password123"
            };

            // Act
            var result = user.PrijaviSe("jnovak", "wrongpassword");

            // Assert
            Assert.False(result); // Expecting the method to return false
        }

    }
}

using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class RegistracijaTests
    {
        [Fact]
        public void IzvediRegistraciju_ReturnsTrue_WhenCalled()
        {
            // Arrange
            var registration = new Registracija
            {
                UporabniskoIme = "jnovak",
                Ime = "Janez",
                Priimek = "Novak",
                Email = "jnovak@example.com",
                Geslo = "securepassword"
            };

            // Act
            var result = registration.IzvediRegistraciju();

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void Registracija_ShouldHaveProperties()
        {
            // Arrange
            var registration = new Registracija
            {
                UporabniskoIme = "jnovak",
                Ime = "Janez",
                Priimek = "Novak",
                Email = "jnovak@example.com",
                Geslo = "securepassword"
            };

            // Act & Assert
            Assert.NotNull(registration.UporabniskoIme);
            Assert.NotNull(registration.Ime);
            Assert.NotNull(registration.Priimek);
            Assert.NotNull(registration.Email);
            Assert.NotNull(registration.Geslo);
        }
    }
}

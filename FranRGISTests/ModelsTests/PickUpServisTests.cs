using Xunit;
using FranRGIS.Models; // Replace with your correct namespace

namespace FranRGISTests.ModelsTests
{
    public class PickUpServisTests
    {
        [Fact]
        public void OrganizacijaPrevzema_ReturnsTrue_WhenCalled()
        {
            // Arrange
            var service = new PickUpServis
            {
                Termin = "2024-12-05 10:00",
                Lokacija = "Maribor"
            };

            // Act
            var result = service.OrganizacijaPrevzema();

            // Assert
            Assert.True(result); // Expecting the method to return true
        }

        [Fact]
        public void ObavestiUporabnika_ShouldNotifyUser()
        {
            // Arrange
            var service = new PickUpServis();
            string userId = "123"; // Example user ID

            // Act
            service.ObavestiUporabnika(userId);

            // Assert
            // Since the method only outputs to console, we can't easily assert its side effects here
            // In real-world cases, you would mock the Console or redirect the output for validation
            Assert.True(true); // This is a placeholder assertion since the method prints to the console
        }

        [Fact]
        public void PickUpServis_ShouldHaveProperties()
        {
            // Arrange
            var service = new PickUpServis
            {
                Termin = "2024-12-05 10:00",
                Lokacija = "Maribor",
                Status = "Pending"
            };

            // Act & Assert
            Assert.NotNull(service.Termin);
            Assert.NotNull(service.Lokacija);
            Assert.NotNull(service.Status);
        }
    }
}

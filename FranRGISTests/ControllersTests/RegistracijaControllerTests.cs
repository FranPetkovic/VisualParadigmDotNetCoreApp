//using Xunit;
//using Microsoft.AspNetCore.Mvc;
//using EvidencaWebApp.Controllers;

//namespace FranRGISTests.Controllers
//{
//    public class RegistracijaControllerTests
//    {
//        [Fact]
//        public void Index_ReturnsCorrectContentResult()
//        {
//            // Arrange
//            var controller = new RegistracijaController();

//            // Act
//            var result = controller.Index();

//            // Assert
//            var contentResult = Assert.IsType<ContentResult>(result);
//            Assert.Equal("Registration Details: Username: jnovak, Name: Janez Novak, Email: jnovak@example.com", contentResult.Content);
//        }

//        [Fact]
//        public void ExecuteRegistration_ReturnsSuccessMessage_WhenRegistrationIsSuccessful()
//        {
//            // Arrange
//            var controller = new RegistracijaController();

//            // Act
//            var result = controller.ExecuteRegistration();

//            // Assert
//            var contentResult = Assert.IsType<ContentResult>(result);
//            Assert.Equal("User jnovak registered successfully.", contentResult.Content);
//        }

//        //[Fact]
//        //public void ExecuteRegistration_ReturnsFailureMessage_WhenRegistrationFails()
//        //{
//        //    // Arrange
//        //    var controller = new RegistracijaController();
//        //    var registration = new Registracija
//        //    {
//        //        UporabniskoIme = "", // Invalid username to simulate failure
//        //        Ime = "Janez",
//        //        Priimek = "Novak",
//        //        Email = "jnovak@example.com",
//        //        Geslo = "securepassword"
//        //    };

//        //    // Act
//        //    var result = controller.ExecuteRegistration();

//        //    // Assert
//        //    var contentResult = Assert.IsType<ContentResult>(result);
//        //    Assert.Equal("Registration failed.", contentResult.Content);
//        //}
//    }
//}

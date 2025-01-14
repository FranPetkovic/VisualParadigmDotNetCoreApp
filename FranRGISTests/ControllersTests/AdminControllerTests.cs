using Microsoft.AspNetCore.Mvc;
using EvidencaWebApp.Controllers;

namespace FranRGISTests.ControllersTests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Index_Returns_ContentResult()
        {
            var controller = new AdminController();

            var result = controller.Index();

            Assert.IsType<ContentResult>(result);
        }
    }
}

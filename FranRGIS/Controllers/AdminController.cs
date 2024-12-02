using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models; // Replace with the correct namespace of your project

namespace EvidencaWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // Create a test Administrator object
            Administrator admin = new Administrator
            {
                Id = 1,
                Ime = "Janez",
                Priimek = "Novak",
                Email = "janez.novak@example.com"
            };

            return Content($"Admin: {admin.Ime} {admin.Priimek}, Email: {admin.Email}");
        }

    }
}

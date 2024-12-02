using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Index()
        {
            Registracija registration = new Registracija
            {
                UporabniskoIme = "jnovak",
                Ime = "Janez",
                Priimek = "Novak",
                Email = "jnovak@example.com",
                Geslo = "securepassword"
            };

            return Content($"Registration Details: Username: {registration.UporabniskoIme}, Name: {registration.Ime} {registration.Priimek}, Email: {registration.Email}");
        }

        public IActionResult ExecuteRegistration()
        {
            Registracija registration = new Registracija
            {
                UporabniskoIme = "jnovak",
                Ime = "Janez",
                Priimek = "Novak",
                Email = "jnovak@example.com",
                Geslo = "securepassword"
            };

            if (registration.IzvediRegistraciju())
            {
                return Content($"User {registration.UporabniskoIme} registered successfully.");
            }
            else
            {
                return Content("Registration failed.");
            }
        }
    }
}

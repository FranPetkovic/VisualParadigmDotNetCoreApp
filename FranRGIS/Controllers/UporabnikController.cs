using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class UporabnikController : Controller
    {
        public IActionResult Index()
        {
            Uporabnik user = new Uporabnik
            {
                Id = 1,
                UporabniskoIme = "jnovak",
                Ime = "Janez",
                Priimek = "Novak",
                Email = "jnovak@example.com",
                Geslo = "password123",
                Lokacija = "Ljubljana"
            };

            return Content($"User: {user.Ime} {user.Priimek}, Location: {user.Lokacija}");
        }

        public IActionResult Login(string uporabniskoIme, string geslo)
        {
            Uporabnik user = new Uporabnik
            {
                Id = 1,
                UporabniskoIme = "jnovak",
                Geslo = "password123"
            };

            if (user.PrijaviSe(uporabniskoIme, geslo))
            {
                return Content($"User {user.UporabniskoIme} logged in successfully.");
            }
            else
            {
                return Content("Invalid username or password.");
            }
        }
    }
}

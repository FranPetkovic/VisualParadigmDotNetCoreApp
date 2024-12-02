using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class RecycleLokacijaController : Controller
    {
        public IActionResult Index()
        {
            RecycleLokacija location = new RecycleLokacija
            {
                Id = 1,
                Naslov = "Ljubljana Recycling Center",
                OdpiralniCas = "08:00 - 16:00"
            };

            return Content(location.PrikazLokacije());
        }

        public IActionResult AddLocation(string lokacija)
        {
            RecycleLokacija location = new RecycleLokacija();
            if (location.DodajLokacijo(lokacija))
            {
                return Content($"Location {lokacija} added successfully.");
            }
            else
            {
                return Content("Failed to add location.");
            }
        }
    }
}

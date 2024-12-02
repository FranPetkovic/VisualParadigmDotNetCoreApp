using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class PickUpServisController : Controller
    {
        public IActionResult Index()
        {
            PickUpServis service = new PickUpServis
            {
                Termin = "2024-12-05 10:00",
                Lokacija = "Ljubljana",
                Status = "Scheduled"
            };

            return Content($"Pickup Service: Location: {service.Lokacija}, Time: {service.Termin}, Status: {service.Status}");
        }

        public IActionResult OrganizePickup()
        {
            PickUpServis service = new PickUpServis
            {
                Termin = "2024-12-05 10:00",
                Lokacija = "Maribor",
                Status = "Pending"
            };

            if (service.OrganizacijaPrevzema())
            {
                return Content($"Pickup organized at {service.Lokacija} on {service.Termin}.");
            }
            else
            {
                return Content("Failed to organize pickup.");
            }
        }

        public IActionResult NotifyUser(string uporabnikId)
        {
            PickUpServis service = new PickUpServis();
            service.ObavestiUporabnika(uporabnikId);

            return Content($"User with ID: {uporabnikId} has been notified.");
        }
    }
}

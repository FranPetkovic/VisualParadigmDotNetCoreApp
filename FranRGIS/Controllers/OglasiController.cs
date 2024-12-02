using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class OglasiController : Controller
    {
        public IActionResult Index()
        {
            Oglasi ad = new Oglasi
            {
                Id = 1,
                Naziv = "Prodaja Laptopa",
                Opis = "Rabljeni laptop u odličnom stanju.",
                Slike = "laptop.jpg",
                Cena = 650.0
            };

            return Content($"Ad: {ad.Naziv}, Description: {ad.Opis}, Price: {ad.Cena}, Images: {ad.Slike}");
        }

        public IActionResult Publish()
        {
            Oglasi ad = new Oglasi
            {
                Id = 1,
                Naziv = "Prodaja Laptopa"
            };

            if (ad.ObjaviOglas())
            {
                return Content($"Ad '{ad.Naziv}' published successfully!");
            }
            else
            {
                return Content("Failed to publish the ad.");
            }
        }

        public IActionResult Review(string oglasId)
        {
            Oglasi ad = new Oglasi();
            string review = ad.PreglejOglas(oglasId);

            return Content(review);
        }
    }
}

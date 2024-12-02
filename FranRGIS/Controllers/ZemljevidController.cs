using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models;

namespace EvidencaWebApp.Controllers
{
    public class ZemljevidController : Controller
    {
        public IActionResult Index()
        {
            Zemljevid map = new Zemljevid
            {
                Lokacije = "Ljubljana, Maribor, Celje",
                TrenutnaLokacija = "Ljubljana"
            };

            return Content(map.PrikaziZemljovid());
        }

        public IActionResult FilterLocations(string kriterij)
        {
            Zemljevid map = new Zemljevid
            {
                Lokacije = "Ljubljana, Maribor, Celje"
            };

            string result = map.FiltrirajLokacije(kriterij);
            return Content(result);
        }
    }
}

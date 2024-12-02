using Microsoft.AspNetCore.Mvc;
using FranRGIS.Models; // Replace with the correct namespace of your project

namespace EvidencaWebApp.Controllers
{
    public class OdkupElektronikeController : Controller
    {
        public IActionResult Index()
        {
            // Create a test OdkupElektronike object
            OdkupElektronike device = new OdkupElektronike
            {
                VrstaNaprave = "Laptop",
                StanjeNaprave = "Rabljeno - Dobro",
                Cena = 450.0
            };

            return Content($"Device: {device.VrstaNaprave}, Condition: {device.StanjeNaprave}, Price: {device.Cena}");
        }
    }
}

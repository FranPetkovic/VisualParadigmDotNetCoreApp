using System;

namespace FranRGIS.Models
{
    public class OdkupElektronike
    {
        public string VrstaNaprave { get; set; } 
        public string StanjeNaprave { get; set; } 
        public double Cena { get; set; } 

        public double OceniVrednost()
        {
            return Cena * 0.8;
        }

        public bool OddajZahtevo(string zahteva)
        {
            Console.WriteLine($"Request submitted: {zahteva}");
            return true;
        }

        public Oglasi[] Oglasis { get; set; }
    }
}

using System;

namespace FranRGIS.Models
{
    public class Zemljevid
    {
        public string Lokacije { get; set; }
        public string TrenutnaLokacija { get; set; }

        public string PrikaziZemljovid()
        {
            return $"Map showing: {Lokacije}. Current location: {TrenutnaLokacija}.";
        }

        public string FiltrirajLokacije(string kriterij)
        {
            return $"Filtered locations by: {kriterij}";
        }
    }
}

using System;

namespace FranRGIS.Models
{
    public class Oglasi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slike { get; set; }
        public double Cena { get; set; }

        public bool ObjaviOglas()
        {
            Console.WriteLine($"Ad {Naziv} has been published!");
            return true;
        }

        public string PreglejOglas(string oglasId)
        {
            return $"Reviewing ad with ID: {oglasId}";
        }
    }
}

using System;

namespace FranRGIS.Models
{
    public class RecycleLokacija
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string OdpiralniCas { get; set; }

        public string PrikazLokacije()
        {
            return $"Location: {Naslov}, Open Hours: {OdpiralniCas}";
        }

        public bool DodajLokacijo(string lokacija)
        {
            Console.WriteLine($"Location {lokacija} added successfully.");
            return true;
        }

        public Zemljevid[] Zemljevids { get; set; }
    }
}

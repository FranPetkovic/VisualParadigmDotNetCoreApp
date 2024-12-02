using System;

namespace FranRGIS.Models
{
    public class PickUpServis
    {
        public string Termin { get; set; }
        public string Lokacija { get; set; }
        public string Status { get; set; }

        public bool OrganizacijaPrevzema()
        {
            Console.WriteLine($"Organizing pickup at {Lokacija} on {Termin}.");
            return true;
        }

        public void ObavestiUporabnika(string uporabnikId)
        {
            Console.WriteLine($"Notifying user with ID: {uporabnikId}");
        }

        public Uporabnik[] Uporabniks { get; set; }
    }
}

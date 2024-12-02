using System;

namespace FranRGIS.Models
{
    public class Registracija
    {
        public string UporabniskoIme { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Email { get; set; }
        public string Geslo { get; set; }

        public bool IzvediRegistraciju()
        {
            Console.WriteLine($"User {UporabniskoIme} registered successfully.");
            return true;
        }

        public Uporabnik Uporabnik { get; set; }
    }
}

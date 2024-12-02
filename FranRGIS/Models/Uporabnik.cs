using System;

namespace FranRGIS.Models
{
    public class Uporabnik
    {
        public int Id { get; set; }
        public string UporabniskoIme { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Email { get; set; }
        public string Geslo { get; set; }
        public string Lokacija { get; set; }

        public bool PrijaviSe(string uporabniskoIme, string geslo)
        {
            return UporabniskoIme == uporabniskoIme && Geslo == geslo;
        }
    }
}

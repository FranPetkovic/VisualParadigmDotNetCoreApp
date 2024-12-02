using System;

namespace FranRGIS.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Email { get; set; }

        public bool PreglejZahtevo(string zahteva)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public bool PotrdiOglas(string oglasId)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public void UrediLokacije(string lokacija)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public void UrediUporabnik(object uporabnik)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private RecycleLokacija[] recycleLokacijas;
        private OdkupElektronike odkupElektronike;

        private PickUpServis[] pickUpServiss;
    }
}

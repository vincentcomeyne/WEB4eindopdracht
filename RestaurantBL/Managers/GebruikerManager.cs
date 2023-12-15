using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantBL.Managers
{
    public class GebruikerManager : IGebruikerManager
    {
        private readonly List<Gebruiker> _gebruikers; // nog aan te passen ivm database

        public GebruikerManager()
        {
            _gebruikers = new List<Gebruiker>();
        }

        public Gebruiker RegistreerGebruiker(Gebruiker gebruiker)
        {
            // Voeg logica toe om te controleren of de gebruiker al bestaat
            _gebruikers.Add(gebruiker); 
            return gebruiker;
        }

        public Gebruiker UpdateGebruiker(Gebruiker gebruiker)
        {
            var bestaandeGebruiker = _gebruikers.FirstOrDefault(g => g.Klantnummer == gebruiker.Klantnummer);
            if (bestaandeGebruiker != null)
            {
                // Update de gegevens van de gebruiker
            }
            return bestaandeGebruiker;
        }

        public void UitschrijvenGebruiker(int klantnummer)
        {
            var gebruiker = _gebruikers.FirstOrDefault(g => g.Klantnummer == klantnummer);
            if (gebruiker != null)
            {
                _gebruikers.Remove(gebruiker);
            }
        }
    }
}

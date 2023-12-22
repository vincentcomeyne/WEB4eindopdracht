using RestaurantBL.Models;

namespace RestaurantBL.Interfaces
{
    public interface IGebruikerManager
    {
        Gebruiker RegistreerGebruiker(Gebruiker gebruiker);
        Gebruiker UpdateGebruiker(Gebruiker gebruiker);
        void UitschrijvenGebruiker(int klantnummer);
    }
}
//voornamelijk gewerkt in database 22/12
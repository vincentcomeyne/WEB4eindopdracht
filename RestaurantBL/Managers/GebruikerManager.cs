using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using RestaurantDL;
using System.Linq;

public class GebruikerManager : IGebruikerManager
{
    private readonly RestaurantContext _context;

    public GebruikerManager(RestaurantContext context)
    {
        _context = context;
    }

    public Gebruiker RegistreerGebruiker(Gebruiker gebruiker)
    {
        _context.Gebruikers.Add(gebruiker);
        _context.SaveChanges();
        return gebruiker;
    }

    public Gebruiker UpdateGebruiker(Gebruiker gebruiker)
    {
        var bestaandeGebruiker = _context.Gebruikers.Find(gebruiker.Klantnummer);
        if (bestaandeGebruiker != null)
        {
            // Update logica nog impl...
            _context.SaveChanges();
        }
        return bestaandeGebruiker;
    }

    public void UitschrijvenGebruiker(int klantnummer)
    {
        var gebruiker = _context.Gebruikers.Find(klantnummer);
        if (gebruiker != null)
        {
            _context.Gebruikers.Remove(gebruiker);
            _context.SaveChanges();
        }
    }
}

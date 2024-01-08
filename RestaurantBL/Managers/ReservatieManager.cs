using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using RestaurantDL;
using System.Linq;

public class ReservatieManager : IReservatieManager
{
    private readonly RestaurantContext _context;

    public ReservatieManager(RestaurantContext context)
    {
        _context = context;
    }

    public Reservatie MaakReservatie(Reservatie reservatie)
    {
        _context.Reservaties.Add(reservatie);
        _context.SaveChanges();
        return reservatie;
    }

    public Reservatie UpdateReservatie(Reservatie reservatie)
    {
        var bestaandeReservatie = _context.Reservaties.Find(reservatie.Reservatienummer);
        if (bestaandeReservatie != null)
        {
            // Update logica nog impl...
            _context.SaveChanges();
        }
        return bestaandeReservatie;
    }

    public void AnnuleerReservatie(int reservatienummer)
    {
        var reservatie = _context.Reservaties.Find(reservatienummer);
        if (reservatie != null)
        {
            _context.Reservaties.Remove(reservatie);
            _context.SaveChanges();
        }
    }
}

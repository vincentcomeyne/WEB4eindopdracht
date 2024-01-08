using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using RestaurantDL;
using System.Linq;

public class RestaurantManager : IRestaurantManager
{
    private readonly RestaurantContext _context;

    public RestaurantManager(RestaurantContext context)
    {
        _context = context;
    }

    public Restaurant VoegRestaurantToe(Restaurant restaurant)
    {
        _context.Restaurants.Add(restaurant);
        _context.SaveChanges();
        return restaurant;
    }

    public Restaurant UpdateRestaurant(Restaurant restaurant)
    {
        var bestaandRestaurant = _context.Restaurants.Find(restaurant.Naam);
        if (bestaandRestaurant != null)
        {
            // Update logica nog impl...
            _context.SaveChanges();
        }
        return bestaandRestaurant;
    }

    public void VerwijderRestaurant(string naam)
    {
        var restaurant = _context.Restaurants.FirstOrDefault(r => r.Naam == naam);
        if (restaurant != null)
        {
            _context.Restaurants.Remove(restaurant);
            _context.SaveChanges();
        }
    }
}

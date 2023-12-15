using RestaurantBL.Models;

namespace RestaurantBL.Interfaces
{
    public interface IRestaurantManager
    {
        Restaurant VoegRestaurantToe(Restaurant restaurant);
        Restaurant UpdateRestaurant(Restaurant restaurant);
        void VerwijderRestaurant(string naam);
    }
}

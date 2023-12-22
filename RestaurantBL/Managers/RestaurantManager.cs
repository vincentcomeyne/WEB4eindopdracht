using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantBL.Managers
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly List<Restaurant> _restaurants; // Nog aan te passen ivm database

        public RestaurantManager()
        {
            _restaurants = new List<Restaurant>();
        }

        public Restaurant VoegRestaurantToe(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
            return restaurant;
        }
        //voornamelijk gewerkt in database 22/12

        public Restaurant UpdateRestaurant(Restaurant restaurant)
        {
            var bestaandRestaurant = _restaurants.FirstOrDefault(r => r.Naam == restaurant.Naam);
            if (bestaandRestaurant != null)
            {
                // Update restaurant details
            }
            return bestaandRestaurant;
        }

        public void VerwijderRestaurant(string naam)
        {
            var restaurant = _restaurants.FirstOrDefault(r => r.Naam == naam);
            if (restaurant != null)
            {
                _restaurants.Remove(restaurant);
            }
        }
    }
}

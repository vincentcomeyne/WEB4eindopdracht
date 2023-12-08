using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL.Models
{
    public class Reservatie
    {
        [Range(1, int.MaxValue, ErrorMessage = "Reservatienummer moet groter zijn dan 0")]
        public int Reservatienummer { get; set; }
        public Gebruiker Gebruiker { get; set; } 
        public Restaurant Restaurantinfo { get; set; } 
        public int Aantal { get; set; }
        public DateTime Datum { get; set; }
        public int Tafelnummer { get; set; }
        public TimeSpan Uur { get; set; }
    }
}

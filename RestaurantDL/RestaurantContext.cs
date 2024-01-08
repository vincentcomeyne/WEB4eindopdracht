using Microsoft.EntityFrameworkCore;
using RestaurantBL.Models;
using System.Collections.Generic;

namespace RestaurantDL
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservatie> Reservaties { get; set; }
        public DbSet<Locatie> Locaties { get; set; }
    }
}

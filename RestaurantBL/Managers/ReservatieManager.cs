using RestaurantBL.Interfaces;
using RestaurantBL.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantBL.Managers
{
    public class ReservatieManager : IReservatieManager
    {
        private readonly List<Reservatie> _reservaties; // Nog aan te passen ivm database

        public ReservatieManager()
        {
            _reservaties = new List<Reservatie>();
        }

        public Reservatie MaakReservatie(Reservatie reservatie)
        {
            _reservaties.Add(reservatie); 
            return reservatie;
        }

        public Reservatie UpdateReservatie(Reservatie reservatie)
        {
            var bestaandeReservatie = _reservaties.FirstOrDefault(r => r.Reservatienummer == reservatie.Reservatienummer);
            if (bestaandeReservatie != null)
            {
                // Update de reservatie details
            }
            return bestaandeReservatie;
        }

        public void AnnuleerReservatie(int reservatienummer)
        {
            var reservatie = _reservaties.FirstOrDefault(r => r.Reservatienummer == reservatienummer);
            if (reservatie != null)
            {
                _reservaties.Remove(reservatie);
            }
        }
    }
}

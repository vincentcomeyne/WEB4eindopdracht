using RestaurantBL.Models;

namespace RestaurantBL.Interfaces
{
    public interface IReservatieManager
    {
        Reservatie MaakReservatie(Reservatie reservatie);
        Reservatie UpdateReservatie(Reservatie reservatie);
        void AnnuleerReservatie(int reservatienummer);
    }
}

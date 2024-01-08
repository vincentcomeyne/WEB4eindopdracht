using Microsoft.AspNetCore.Mvc;
using RestaurantBL.Interfaces;
using RestaurantBL.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GebruikerController : ControllerBase
    {
        private readonly IGebruikerManager _gebruikerManager;

        public GebruikerController(IGebruikerManager gebruikerManager)
        {
            _gebruikerManager = gebruikerManager;
        }

        // Actiemethoden...
    }
}

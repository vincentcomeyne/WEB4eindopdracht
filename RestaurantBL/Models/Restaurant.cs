using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL.Models
{
    public class Restaurant
    {
        [Required(ErrorMessage = "Naam van het restaurant is vereist")]
        public string Naam { get; set; }

        public Locatie Locatie { get; set; }

        [Required(ErrorMessage = "Keuken is vereist")]
        public string Keuken { get; set; }

        public string Contact { get; set; }
    }

}

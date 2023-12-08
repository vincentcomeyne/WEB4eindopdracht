using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL.Models
{
    public class Locatie
    {
        public int LocatieId { get; set; }

        [Required(ErrorMessage = "Postcode is vereist")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postcode moet uit 4 cijfers bestaan")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Gemeentenaam is vereist")]
        public string Gemeentenaam { get; set; }

        public string Straatnaam { get; set; }

        public string Huisnummer { get; set; }
    }
}

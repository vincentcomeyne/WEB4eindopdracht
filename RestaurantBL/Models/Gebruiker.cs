using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL.Models
{
    public class Gebruiker
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Klantnummer moet groter zijn dan 0")]
        public int Klantnummer { get; set; }

        [Required(ErrorMessage = "Naam is vereist")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Email is vereist")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is vereist")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Telefoonnummer moet alleen cijfers bevatten")]
        public string Telefoonnummer { get; set; }

        public Locatie Locatie { get; set; }
    }
}

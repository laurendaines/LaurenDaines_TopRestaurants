using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_TopRestaurants.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "You must enter a Rank")]
        public int Rank { get; set; }
        [Required(ErrorMessage = "You must enter a Name")]
        public string Name { get; set; }
        public string? FavDish { get; set; } = "It's all tasty!";
        [Required(ErrorMessage = "You must enter an Address")]
        public string Address { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid Phone Number")]
        public string? PhoneNumber { get; set; }
        public string? Link { get; set; } = "Coming soon.";
    }
}

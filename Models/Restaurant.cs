using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_TopRestaurants.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            Rank = rank;
        }

        public int Rank { get; set; }
        public string Name { get; set; }
        public string? FavDish { get; set; }
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Link { get; set; }

        

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Bombay House",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNumber = "(801) 373-6677",
                Link = "https://bombayhouse.com/menu/",
                FavDish = "Chicken Makhani (medium), Garlic Naan, and a Mango Lassi",
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Maria Bonita",
                Address = "3815 167 W 800 N, Orem, UT 84057",
                PhoneNumber = "(801) 426-9328",
                Link = "https://mariabonitagrill.com/",
                FavDish = "Chicken Enchildas de Poblano, Chips Salsa and Guacamole, and a Diet Coke",
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "MidiCi",
                Address = "541 E University Pkwy B, Orem, UT 84097",
                PhoneNumber = "(385) 352-3752",
                Link = "https://mymidici.com/",
                FavDish = "New York Margarita with lots of parmesean, red pepper flakes, and chile oil",
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "La Costa ",
                Address = "852 E State St #9718, American Fork, UT 84003",
                PhoneNumber = "(801) 492-0042",
                Link = "lacostaaf.com",
                FavDish = "Carne Asada Plate, Chips Salsa and Refried Bean dip, and a Diet Coke",
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Tsunami",
                Address = "1616 W Traverse Pkwy, Lehi, UT 84043",
                PhoneNumber = "(801) 770-0088",
                Link = "tsunamiutah.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}

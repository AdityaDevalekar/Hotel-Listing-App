using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Listing_App.Data
{
    public class hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(country))]
        public int CountryId { get; set; }
        public country country { get; set; }
        
    }
}

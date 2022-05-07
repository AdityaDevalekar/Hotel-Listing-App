using Hotel_Listing_App.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Listing_App.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength:50,MinimumLength = 4,ErrorMessage ="Hotel Name is too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:250, MinimumLength = 15,ErrorMessage = "Address is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
        
    }
    public class HotelDTO :CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO country { get;set; }


    }
}

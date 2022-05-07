using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Listing_App.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
        
    public class CreateCountryDTO
    {

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Country's Short Name is Too Long")]
        public string ShortName { get; set; }
    }
}

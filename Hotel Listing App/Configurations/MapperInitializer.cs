using AutoMapper;
using Hotel_Listing_App.Data;
using Hotel_Listing_App.Models;

namespace Hotel_Listing_App.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap< country,CountryDTO >().ReverseMap();
            CreateMap< country,CreateCountryDTO >().ReverseMap();
            CreateMap< hotel,HotelDTO >().ReverseMap();
            CreateMap< hotel,CreateHotelDTO >().ReverseMap();
        }
    }
}

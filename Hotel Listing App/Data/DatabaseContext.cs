using Microsoft.EntityFrameworkCore;

namespace Hotel_Listing_App.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<country> Countries { get; set; }

        public DbSet<hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<country>().HasData(
                new country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "Ind"
                },
                new country
                {
                    Id = 2,
                    Name = "Sri Lanka",
                    ShortName = "SL"

                },
                new country
                {
                    Id = 3,
                    Name = "South Africa",
                    ShortName = "SA"

                }
                );
            builder.Entity<hotel>().HasData(
                new hotel
                {
                    Id = 1,
                    Name = "Taj Hotel",
                    Address = "Mumbai",
                    Rating = 5,
                    CountryId = 1,
                },
                new hotel
                {
                    Id = 2,
                    Name = "Oberoi Hotel",
                    Address = "Pune",
                    Rating = 5,
                    CountryId = 1,
                },
                new hotel
                {
                    Id = 3,
                    Name = "Ola Hotel",
                    Address = "Columbo",
                    Rating = 4.2,
                    CountryId = 2,
                },
                new hotel
                {
                    Id = 4,
                    Name = "Windester Hotel",
                    Address = "Cape Town",
                    Rating = 4.9,
                    CountryId = 3,
                }
                );

        }
        
    }
}

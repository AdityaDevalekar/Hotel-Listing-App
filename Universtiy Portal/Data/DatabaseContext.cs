using Microsoft.EntityFrameworkCore;

namespace Universtiy_Portal.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options) :base (options)
        {

        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<College>().HasData(
                new College
                {
                    Id = 1,
                    Name = "College of Free Education",

                },
                new College
                {
                    Id = 2,
                    Name = "College of Freedom",

                }
                );
            builder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Avinash",
                    UserName = "Avi@111",
                    Password = "2233AAA",
                    Address = "Karvenagar",
                    CollegeId = 1,
                },
                new Student
                {
                    Id = 2,
                    Name = "Swarup",
                    UserName = "swa@111",
                    Password = "2233AAA",
                    Address = "Karvenagar",
                    CollegeId = 2,
                },
                new Student
                {
                    Id = 3,
                    Name = "motya",
                    UserName = "mot@111",
                    Password = "2233AAA",
                    Address = "Karvenagar",
                    CollegeId = 1,
                }
                );
        }
    }
}

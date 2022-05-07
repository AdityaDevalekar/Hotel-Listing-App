﻿// <auto-generated />
using Hotel_Listing_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Listing_App.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220507054857_Refresh_data")]
    partial class Refresh_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel_Listing_App.Data.country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India",
                            ShortName = "Ind"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sri Lanka",
                            ShortName = "SL"
                        },
                        new
                        {
                            Id = 3,
                            Name = "South Africa",
                            ShortName = "SA"
                        });
                });

            modelBuilder.Entity("Hotel_Listing_App.Data.hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Mumbai",
                            CountryId = 1,
                            Name = "Taj Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Pune",
                            CountryId = 1,
                            Name = "Oberoi Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Columbo",
                            CountryId = 2,
                            Name = "Ola Hotel",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 4,
                            Address = "Cape Town",
                            CountryId = 3,
                            Name = "Windester Hotel",
                            Rating = 4.9000000000000004
                        });
                });

            modelBuilder.Entity("Hotel_Listing_App.Data.hotel", b =>
                {
                    b.HasOne("Hotel_Listing_App.Data.country", "country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });
#pragma warning restore 612, 618
        }
    }
}
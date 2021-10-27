﻿using HotelAPI.Data.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());


            //builder.Entity<Country>().HasData(
            //    new Country
            //    {
            //        Id = 1,
            //        Name = "Jamaica",
            //        ShortName = "JM"
            //    },
            //    new Country
            //    {
            //        Id = 2,
            //        Name = "Bahamas",
            //        ShortName = "BS"
            //    },
            //    new Country
            //    {
            //        Id = 3,
            //        Name = "Cayman island",
            //        ShortName = "CI"
            //    }
            //    );

            //builder.Entity<Hotel>().HasData(
            //    new Hotel { 
            //        Id = 1,
            //        Name = "Sandals Resort and Spa",
            //        Address = "Negril",
            //        CountryId =1,
            //        Rating=4.5
            //    },
            //     new Hotel
            //     {
            //         Id = 2,
            //         Name = "Conform Suites",
            //         Address = "George Town",
            //         CountryId = 3,
            //         Rating = 4.3
            //     },
            //      new Hotel
            //      {
            //          Id = 3,
            //          Name = "Grand Palldium",
            //          Address = "Nasua",
            //          CountryId = 2,
            //          Rating = 4
            //      }
            //    );
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}

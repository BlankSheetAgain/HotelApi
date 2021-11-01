using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Context
{
    public class HotelContext:DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Category> Categories;
        public DbSet<Room> Rooms;
        public DbSet<Checkin> Checkins;
        public DbSet<Guest> Guests;
        public DbSet<CategoryPrice> CategoryPrices;
    }
}

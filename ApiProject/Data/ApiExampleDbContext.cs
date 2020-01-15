using ApiProject.Models;
using HotelManagemant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Data
{
    public class ApiExampleDbContext:DbContext
    {
            public ApiExampleDbContext(DbContextOptions<ApiExampleDbContext> options)
           : base(options)
            {

            }
        public DbSet<User> user { get; set; }
        public DbSet<RegisterQuantityType> QunatityType { get; set; }
        public DbSet<StockIng> stockIngs { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<MenuCategory> Menu { get; set; }
        public DbSet<MenuContinent> Continent { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<MenuRegistration> MenuReg { get; set; }
        public DbSet<customers> Customers { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Facilities> facilities { get; set; }
        public DbSet<Billing> billing { get; set; }
        public DbSet<RegisterFood> RegisterFoods { get; set; }
        public DbSet<FoodCategory> foodCategories { get; set; }
        public DbSet<DrinkRegister> drinkRegisters { get; set; }
        public DbSet<DrinkCategory> drinkCategories { get; set; }
        public DbSet<TableRegister> tableRegisters { get; set; }
        public DbSet<Bookingtable> Bookingtables { get; set; }
        public DbSet<BillingInfo> BillingInfos { get; set; }
        public DbSet<BillingItem> billingItems { get; set; }
        public DbSet<RoomImage> RoomImage { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<CustomerRegister> RegisteredCostumers { get; set; }
        public DbSet<RegisterIngridiants> ingridiants { get; set; }
        public DbSet<IngrediantsAndFood> IngrediantsAndFoods { get; set; }
        public DbSet<Demo> Demo { get; set; }
        public DbSet<RegisterVendor> Vendor { get; set; }
        public DbSet<IngridiantsName> IngridiantsNames { get; set; }
        public DbSet<DailyStock> dailyStocks { get; set; }



    }
}

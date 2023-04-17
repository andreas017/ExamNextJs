using GripFoodBackEnd.Entities;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNextJsBackend.Entities
{
    public class ApplicationDbContext : DbContext, IDataProtectionKeyContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var user1 = new User
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Yanto",
                Email = "yanto@mail.com",
                Password = "yannto11",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var user2 = new User
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Annie",
                Email = "annie@mail.com",
                Password = "annie11",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var restaurant1 = new Restaurant
            {
                Id = "SukaPadang",
                Name = "Suka Padang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var restaurant2 = new Restaurant
            {
                Id = "LebahBahagia",
                Name = "Lebah Bahagia",
                CreatedAt = DateTimeOffset.UtcNow,

            };

            var food1 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Rendang",
                Price = 15000,
                RestaurantId = "SukaPadang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var food2 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Ayam Gulai",
                Price = 13000,
                RestaurantId = "SukaPadang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var food3 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Nasi Putih",
                Price = 5000,
                RestaurantId = "SukaPadang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var food4 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Ayam Goreng",
                Price = 15000,
                RestaurantId = "LebahBahagia",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var food5 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Spagetti",
                Price = 18000,
                RestaurantId = "LebahBahagia",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var drink1 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Aqua",
                Price = 3000,
                RestaurantId = "SukaPadang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var drink2 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Es Teh Manis",
                Price = 7000,
                RestaurantId = "SukaPadang",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var drink3 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Coca-Cola",
                Price = 12000,
                RestaurantId = "LebahBahagia",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            var drink4 = new FoodItem
            {
                Id = Ulid.NewUlid().ToString(),
                Name = "Sprite",
                Price = 12000,
                RestaurantId = "LebahBahagia",
                CreatedAt = DateTimeOffset.UtcNow,
            };

            modelBuilder.Entity<User>().HasData(user1, user2);
            modelBuilder.Entity<Restaurant>().HasData(restaurant1, restaurant2);

            modelBuilder.Entity<FoodItem>().HasData(food1, food2, food3, drink1, drink2, food4, food5, drink3, drink4);

            modelBuilder.Entity<FoodItem>()
                .HasOne(fi => fi.Restaurant)
                .WithMany(r => r.FoodItems)
                .HasForeignKey(fi => fi.RestaurantId);
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartDetail> CartDetails => Set<CartDetail>();

        public DbSet<DataProtectionKey> DataProtectionKeys => Set<DataProtectionKey>();
    }
}

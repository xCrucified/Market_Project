using data_access.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Data
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1, Name = "Ticket", Category = "Travel", Description = "Not exist", InStock = true, Discount = 10, Price = 650, ImageUrl = "" },
                new Product() { Id = 2, Name = "Smartphone", Category = "Electronics", Description = "High-performance device", InStock = true, Discount = 5, Price = 899, ImageUrl = "" },
                new Product() { Id = 3, Name = "Running Shoes", Category = "Sports", Description = "Comfortable and durable", InStock = true, Discount = 15, Price = 79, ImageUrl = "" },
                new Product() { Id = 4, Name = "Laptop", Category = "Electronics", Description = "Powerful and lightweight", InStock = true, Discount = 12, Price = 1299, ImageUrl = "" },
                new Product() { Id = 5, Name = "Cookware Set", Category = "Home and Kitchen", Description = "Non-stick and easy to clean", InStock = true, Discount = 8, Price = 149, ImageUrl = "" },
                new Product() { Id = 6, Name = "Camera", Category = "Electronics", Description = "High-resolution images", InStock = true, Discount = 20, Price = 599, ImageUrl = "" },
                new Product() { Id = 7, Name = "Fitness Tracker", Category = "Sports", Description = "Tracks your activity and health", InStock = true, Discount = 10, Price = 49, ImageUrl = "" },
                new Product() { Id = 8, Name = "Headphones", Category = "Electronics", Description = "Noise-canceling and comfortable", InStock = true, Discount = 15, Price = 129, ImageUrl = "" },
                new Product() { Id = 9, Name = "Backpack", Category = "Fashion", Description = "Stylish and spacious", InStock = true, Discount = 8, Price = 39, ImageUrl = "" },
                new Product() { Id = 10, Name = "Gaming Console", Category = "Electronics", Description = "Immersive gaming experience", InStock = true, Discount = 10, Price = 299, ImageUrl = "" },
                new Product() { Id = 11, Name = "Coffee Maker", Category = "Home and Kitchen", Description = "Brews delicious coffee", InStock = true, Discount = 10, Price = 79, ImageUrl = "" },
                new Product() { Id = 12, Name = "Outdoor Tent", Category = "Camping", Description = "Weather-resistant and easy to set up", InStock = true, Discount = 15, Price = 199, ImageUrl = "" }
            });
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Password = "password123", UserName = "john_doe", Registration = DateTime.Parse("2000-01-01"), Balance = 1000.50m },
                new User() { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Password = "securepass", UserName = "jane_smith", Registration = DateTime.Parse("2000-02-15"), Balance = 750.25m },
                new User() { Id = 3, Name = "Michael Johnson", Email = "michael.johnson@example.com", Password = "pass123", UserName = "michael_j", Registration = DateTime.Parse("2000-03-22"), Balance = 1200.75m },
                new User() { Id = 4, Name = "Emily Brown", Email = "emily.brown@example.com", Password = "strongpass", UserName = "emily_b", Registration = DateTime.Parse("2000-04-10"), Balance = 850.30m },
            });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}

        public DbSet<Product> Products { get; set; }
    }
}

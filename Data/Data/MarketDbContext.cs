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

            modelBuilder.Entity<Product>().HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasDefaultValue(9); // "Other"

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Other" }
            });

            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1, Name = "Ticket", CategoryId = 1, Description = "Not exist", InStock = true, Discount = 10, Price = 650, ImageUrl = "https://th.bing.com/th/id/OIP.f41ft8r1DGylDfCVbQXJTQAAAA?rs=1&pid=ImgDetMain" },
                new Product() { Id = 2, Name = "Smartphone", CategoryId = 2, Description = "High-performance device", InStock = true, Discount = 5, Price = 899, ImageUrl = "https://th.bing.com/th/id/OIP.6OI-0NfjMZtcYKH8VulQjgHaFe?rs=1&pid=ImgDetMain" },
                new Product() { Id = 3, Name = "Running Shoes", CategoryId = 3, Description = "Comfortable and durable", InStock = true, Price = 79, ImageUrl = "https://th.bing.com/th/id/OIP.mgap1fs9rd1GOuf4S4KQTwHaEE?rs=1&pid=ImgDetMain" },
            });
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Password = "password123", UserName = "john_doe", Registration = DateTime.Parse("2000-01-01"), Balance = 1000.50m },
                new User() { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Password = "securepass", UserName = "jane_smith", Registration = DateTime.Parse("2000-02-15"), Balance = 750.25m },
                new User() { Id = 3, Name = "Michael Johnson", Email = "michael.johnson@example.com", Password = "pass123", UserName = "michael_j", Registration = DateTime.Parse("2000-03-22"), Balance = 1200.75m },
                new User() { Id = 4, Name = "Emily Brown", Email = "emily.brown@example.com", Password = "strongpass", UserName = "emily_b", Registration = DateTime.Parse("2000-04-10"), Balance = 850.30m },
            });
            modelBuilder.Entity<Attributes>().HasData(new[]
            {
                new Attributes() { Id = 1, isNew = true, Model = "Audi", wasUsed = false},
                new Attributes() { Id = 2},
                new Attributes() { Id = 3, isNew = false, Model = "Jordan", wasUsed = true},
            });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
    }
}

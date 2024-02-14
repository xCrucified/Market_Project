using data_access.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace data_access.Data
{
    public class MarketDbContext : IdentityDbContext
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
            modelBuilder.Entity<Attributes>().HasData(new[]
            {
                new Attributes() { Id = 1, isNew = true, Model = "Audi", wasUsed = false},
                new Attributes() { Id = 2},
                new Attributes() { Id = 3, isNew = false, Model = "Jordan", wasUsed = true},
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
    }
}

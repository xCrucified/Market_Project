using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Travel", "Not exist", 10, "", true, "Ticket", 650m },
                    { 2, "Electronics", "High-performance device", 5, "", true, "Smartphone", 899m },
                    { 3, "Sports", "Comfortable and durable", 15, "", true, "Running Shoes", 79m },
                    { 4, "Electronics", "Powerful and lightweight", 12, "", true, "Laptop", 1299m },
                    { 5, "Home and Kitchen", "Non-stick and easy to clean", 8, "", true, "Cookware Set", 149m },
                    { 6, "Electronics", "High-resolution images", 20, "", true, "Camera", 599m },
                    { 7, "Sports", "Tracks your activity and health", 10, "", true, "Fitness Tracker", 49m },
                    { 8, "Electronics", "Noise-canceling and comfortable", 15, "", true, "Headphones", 129m },
                    { 9, "Fashion", "Stylish and spacious", 8, "", true, "Backpack", 39m },
                    { 10, "Electronics", "Immersive gaming experience", 10, "", true, "Gaming Console", 299m },
                    { 11, "Home and Kitchen", "Brews delicious coffee", 10, "", true, "Coffee Maker", 79m },
                    { 12, "Camping", "Weather-resistant and easy to set up", 15, "", true, "Outdoor Tent", 199m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Balance", "Email", "Name", "Password", "Registration", "UserName" },
                values: new object[,]
                {
                    { 1, 1000.50m, "john.doe@example.com", "John Doe", "password123", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john_doe" },
                    { 2, 750.25m, "jane.smith@example.com", "Jane Smith", "securepass", new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane_smith" },
                    { 3, 1200.75m, "michael.johnson@example.com", "Michael Johnson", "pass123", new DateTime(2000, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael_j" },
                    { 4, 850.30m, "emily.brown@example.com", "Emily Brown", "strongpass", new DateTime(2000, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily_b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

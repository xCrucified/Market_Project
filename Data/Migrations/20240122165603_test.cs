using Microsoft.EntityFrameworkCore.Migrations;
using data_access;
#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://th.bing.com/th/id/OIP.f41ft8r1DGylDfCVbQXJTQAAAA?rs=1&pid=ImgDetMain");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://th.bing.com/th/id/OIP.6OI-0NfjMZtcYKH8VulQjgHaFe?rs=1&pid=ImgDetMain");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://th.bing.com/th/id/OIP.mgap1fs9rd1GOuf4S4KQTwHaEE?rs=1&pid=ImgDetMain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[,]
                {
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
        }
    }
}

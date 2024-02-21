using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_access.Data.Entities;
namespace BusinessLogic.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
    }
}

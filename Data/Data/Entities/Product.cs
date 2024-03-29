﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace data_access.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime postDate { get; set; }
        public Country? Countries { get; set; }
        public Category?Categories { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
    }
}

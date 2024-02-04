using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using data_access.Data;
using data_access.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.InteropServices.Marshalling;

namespace BusinessLogic.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IMapper mapper;
        private readonly MarketDbContext context;

        public ProductsService(IMapper mapper, MarketDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public async void Create(ProductDto product)
        {
            await context.Products.AddAsync(mapper.Map<Product>(product));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return; 

            context.Remove(product);
            context.SaveChanges();
        }
        public void Edit(ProductDto product)
        {
            context.Products.Update(mapper.Map<Product>(product));
            context.SaveChanges();
        }
        public ProductDto? Get(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return null;

            context.Entry(item).Reference(x => x.Categories).Load();

            var dto = mapper.Map<ProductDto>(item);

            return dto;
        }
        public IEnumerable<ProductDto> GetAll()
        {
            return mapper.Map<List<ProductDto>>(context.Products.Include(x => x.Categories).ToList());
        }
        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(context.Categories.ToList());
        }
        public IEnumerable<ProductDto> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<ProductDto>>(context.Products
                .Include(x => x.Categories)
                .Where(x => ids.Contains(x.Id))
                .ToList());
        }
    }
}

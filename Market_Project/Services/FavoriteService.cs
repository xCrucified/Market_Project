using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Market_Project.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json;

namespace Market_Project.Services
{
    public class FavoriteService : IFavoriteService
    {
        const string key = "cart_items_key";
        private readonly IProductsService productsService;
        private readonly HttpContext httpContext;

        public FavoriteService(IProductsService productsService, IHttpContextAccessor contextAccessor)
        {
            this.productsService = productsService;
            httpContext = contextAccessor.HttpContext ?? throw new Exception();
        }

        private List<int> GetFavoriteItems()
        {
            return httpContext.Session.Get<List<int>>(key) ?? new();
        }
        private void SaveFavoriteItems(List<int> items)
        {
            httpContext.Session.Set(key, items);
        }

        public void Add(int id)
        {
            var ids = GetFavoriteItems();
            ids.Add(id);

            SaveFavoriteItems(ids);
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var ids = GetFavoriteItems();
            return productsService.Get(ids);
        }

        public void Remove(int id)
        {
            var ids = GetFavoriteItems();
            ids.Remove(id);

            SaveFavoriteItems(ids);
        }

        public int GetCount()
        {
            return GetFavoriteItems().Count;
        }

        public bool IsExists(int id)
        {
            return GetFavoriteItems().Contains(id);
        }

        public IEnumerable<int> GetProductIds()
        {
            return GetFavoriteItems();
        }
    }
}

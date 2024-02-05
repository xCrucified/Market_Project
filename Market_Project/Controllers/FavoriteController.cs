using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Market_Project.Helpers;
using System.Text.Json;

namespace Market_Project.Controllers
{
    public class FavoriteController : Controller
    {
        const string key = "cart_items_key";
        private readonly IProductsService productsService;

        public FavoriteController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>(key) ?? new();
            return View(productsService.Get(ids));
        }
        public IActionResult Add(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>(key) ?? new();
            ids.Add(id);

            HttpContext.Session.SetString(key, JsonSerializer.Serialize(ids));

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Remove(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>(key).Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

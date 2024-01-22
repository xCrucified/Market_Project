using data_access.Data;
using data_access.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Market_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketDbContext context;

        public ProductController(MarketDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();

            return View(products);
        }

        public IActionResult Create(Product model)
        {
            if (!ModelState.IsValid) return View();

            context.Products.Add(model);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            return View(product);
        }
    }
}

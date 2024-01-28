using data_access.Data;
using data_access.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Market_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketDbContext context;
        private void LoadCategories()
        {
            ViewBag.Categories = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));
        }
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
            LoadCategories();
            if (!ModelState.IsValid) return View();

            context.Products.Add(model);
            context.SaveChanges();
            ViewBag.Categories = new SelectList(context.Categories, "Name", "Id");

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            context.Entry(product)
                .Reference(x => x.Categories)
                .Load();

            if (product == null) return NotFound();

            return View(product);
        }
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            LoadCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            context.Products.Update(model);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return NotFound();

            context.Remove(product);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

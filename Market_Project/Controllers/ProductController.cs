using AutoMapper;
using BusinessLogic.DTOs;
using data_access.Data;
using data_access.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Market_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketDbContext context;
        private readonly IMapper mapper;
        private void LoadCategories()
        {
            var categories = mapper.Map<List<CategoryDto>>(context.Categories.ToList());
            ViewBag.Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name));
        }
        public ProductController(MarketDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var products = mapper.Map<List<ProductDto>>(context.Products.Include(x => x.Categories).ToList());

            return View(products);
        }

        public IActionResult Create(ProductDto model)
        {
            LoadCategories();
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            context.Products.Add(mapper.Map<Product>(model));
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            context.Entry(product).Reference(x => x.Categories).Load();

            var dto = mapper.Map<ProductDto>(product);

            return View(dto);
        }
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            LoadCategories();
            return View(mapper.Map<ProductDto>(product));
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            context.Products.Update(mapper.Map<Product>(model));
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

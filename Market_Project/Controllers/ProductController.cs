using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using data_access.Data;
using data_access.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Market_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketDbContext context;
        private readonly IMapper mapper;
        private readonly IProductsService productsService;
        private void LoadCategories()
        {
            var categories = mapper.Map<List<CategoryDto>>(context.Categories.ToList());
            ViewBag.Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name));
        }
        public ProductController(MarketDbContext context, IMapper mapper, IProductsService productsService)
        {
            this.context = context;
            this.mapper = mapper;
            this.productsService = productsService;
        }
        public IActionResult Index()
        {
            return View(productsService.GetAll());
        }

        public IActionResult Create(ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            productsService.Create(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var product = productsService.Get(id);
            if (product == null) return NotFound();

            return View(product);
        }
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null) return NotFound();

            LoadCategories();
            return View(mapper.Map<ProductDto>(product));
        }

        [HttpPost]
        public IActionResult Edit(ProductDto model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View();
            }

            productsService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            productsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

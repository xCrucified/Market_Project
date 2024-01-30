using AutoMapper;
using BusinessLogic.DTOs;
using data_access.Data;
using Market_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;


namespace Market_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly MarketDbContext context;
        private readonly IMapper mapper;
        public HomeController(MarketDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var products = mapper.Map < List < ProductDto >> (context.Products.Include(x => x.Categories).ToList());
            return View(products);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

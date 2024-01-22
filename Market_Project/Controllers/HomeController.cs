using data_access.Data;
using Market_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Market_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly MarketDbContext context;
        public HomeController(MarketDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

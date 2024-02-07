using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Market_Project.Helpers;
using System.Text.Json;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Market_Project.Controllers
{
    public class FavoriteController : Controller
    {
        //Add scaffolded items "Login, register, Logout";!!!!!
        private readonly IFavoriteService favoriteService;

        public FavoriteController(IFavoriteService cartService)
        {
            this.favoriteService = cartService;
        }

        public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(favoriteService.GetProducts());
        }

        public IActionResult Add(int id, string returnUrl)
        {
            favoriteService.Add(id);
            return Redirect(returnUrl);
        }

        public IActionResult Remove(int id, string returnUrl)
        {
            favoriteService.Remove(id);
            return Redirect(returnUrl);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes3.Models;

namespace UrlsAndRoutes3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Result", new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });
        }
    }
}

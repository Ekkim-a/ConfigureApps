using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes3.Models;

namespace UrlsAndRoutes3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("Result", new Result
            {
                Controller = nameof(AdminController),
                Action = nameof(Index)
            });
        }
    }
}

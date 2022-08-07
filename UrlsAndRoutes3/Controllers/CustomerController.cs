using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes3.Models;

namespace UrlsAndRoutes3.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("Result", new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });
        }

        public IActionResult List() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List)
            });
    }
}

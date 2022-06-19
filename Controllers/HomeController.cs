using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ConfigureApps.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>
            View(new Dictionary<string, string>
            {
                ["Message"] = "This is Index action"
            });
    }
}

using System.Collections.Generic;
using ConfigureApps.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ConfigureApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService upt) => uptime = upt;
        
        public ViewResult Index() =>
            View(new Dictionary<string, string>
            {
                ["Message"] = "This is Index action",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
    }
}

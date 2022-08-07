using System.Collections.Generic;
using System.Security.Cryptography;

namespace UrlsAndRoutes3.Models
{
    public class Result
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public IDictionary<string, object>  Data { get; } = 
            new Dictionary<string, object>();
    }
}

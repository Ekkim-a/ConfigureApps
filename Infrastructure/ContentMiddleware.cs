﻿using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConfigureApps.Infrastructure
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;

        public ContentMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response
                    .WriteAsync("This is from the content middleware", Encoding.UTF8);
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}

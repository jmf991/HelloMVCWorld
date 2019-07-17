using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString());
                return Content("Welcome, new visitor!");
            }
            else
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]);
                return Content("Welcome back, user! You first visited us on: " + firstRequest.ToString());
            }
        }
    }
}
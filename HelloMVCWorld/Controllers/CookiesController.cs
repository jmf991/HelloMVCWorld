using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HelloMVCWorld.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
            //if your page is accessed by www.mywebsite.com, the cookie will by default, only be accessible from www.mywebsite.com and NOT mywebsite.com.
            //so is good idea to set the Domain property to the base-domain of your website, prefixed with a dot
            //cookieOptions.Domain = ".mywebsite.com";
            //Path of the cookie will be set to "/" (will be valid for all pages)
            //if you need a cookie that's valid only for a specific page or folder
            //cookieOptions.Path = "/users/";
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
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
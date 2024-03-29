﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVCWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);  
        }
        public IActionResult QueryTest()
        {
            string name = "John Doe";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];

            return Content("Name from query string: " + name);
        }

        [HttpGet]
        public IActionResult FormsTest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormsTestPost()
        {
            return Content("Hello, " + HttpContext.Request.Form["UserName"] + ". You are " + HttpContext.Request.Form["UserAge"] + " years old!");
        }
    }
}

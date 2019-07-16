using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Models.Product _product = new Models.Product()
            {
                Name = "Product 1",
                Price = 6
            };
            return View(_product);
        }

        public IActionResult List()
        {
            return Content("Product list");
        }

        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
    }
}
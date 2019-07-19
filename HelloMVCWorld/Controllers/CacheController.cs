using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class CacheController : Controller
    {
        //browser requesting the page will be given permission to cache the response of the request for 2 minutes (120 seconds)
        [ResponseCache(Duration = 120)]
        public IActionResult Index()
        {
            return Content("Cache set");
        }
    }
}
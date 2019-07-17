using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public IActionResult CustomValidation()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult CustomValidation(Models.WebUser webUser)
        public IActionResult CustomValidation(Models.WebUserValidatable webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                return View(webUser);
        }
    }
}
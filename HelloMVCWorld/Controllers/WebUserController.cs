using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 

namespace HelloMVCWorld.Controllers
{
    public class WebUserController : Controller
    {
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new Models.WebUser() { FirstName = "John", LastName = "Doe" });
        }

        [HttpPost]
        public IActionResult SimpleBinding(Models.WebUser webUser)
        {
            //TODO: Update in DB here...
            return Content($"User {webUser.FirstName} {webUser.LastName} updated!");
        }
        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(Models.WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                return View(webUser);
        }
        [HttpGet]
        public IActionResult CustomValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomValidation(Models.WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                return View(webUser);
        }
    }
}
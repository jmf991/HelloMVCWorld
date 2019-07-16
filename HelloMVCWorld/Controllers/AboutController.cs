using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            List<string> _casesStudies = new List<string>();
            _casesStudies.Add("Case Studiy 1");
            Models.About _about = new Models.About()
            {
                Intro = "This is the intro for the about page",
                CaseStudies = _casesStudies
            };
            return View(_about);
        }
    }
}
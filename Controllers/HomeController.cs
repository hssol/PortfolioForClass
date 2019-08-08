using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio1.Models;

namespace Portfolio1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Home()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////END OF ROUTE
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////END OF ROUTE
        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////END OF ROUTE
        [HttpGet]
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////END OF ROUTE
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

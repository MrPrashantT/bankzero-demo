using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAM_Exercise.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace TAM_Exercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }

        [Authorize(Roles = "Account Owner")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Balances(){
            return View();
        }

        [Authorize(Roles = "Account Owner")]
        public IActionResult Payments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
            // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

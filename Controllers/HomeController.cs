using System;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

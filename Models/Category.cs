﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Models
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

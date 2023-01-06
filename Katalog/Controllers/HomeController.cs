﻿using Katalog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Urun()
        {
            return View();
        }
        
    }
}
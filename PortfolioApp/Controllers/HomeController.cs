﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PortfolioApp.Models;
using PortfolioApp.Services;

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioContext db;

        // Initialize context when controller is created.
        public HomeController(PortfolioContext db)
        {
            this.db = db;
           // Seeder seeder = new Seeder(db);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

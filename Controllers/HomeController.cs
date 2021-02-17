﻿using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // set up repository variable
        private BookStoreRepository _repository;

        public HomeController(ILogger<HomeController> logger, BookStoreRepository repository)
        {
            _logger = logger;
            // set our repository interface as the variable to pass to the view
            _repository = repository;
        }

        public IActionResult Index()
        {
            // call view and pass it the IQueryable
            return View(_repository.Books);
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

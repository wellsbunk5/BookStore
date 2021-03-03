using BookStore.Models;
using BookStore.Models.ViewModels;
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
        // set up number of books we want listed on each page
        public int numItemsOnPage = 5;

        public HomeController(ILogger<HomeController> logger, BookStoreRepository repository)
        {
            _logger = logger;
            // set our repository interface as the variable to pass to the view
            _repository = repository;
        }

        public IActionResult Index(string category, int page = 1)
        {
            // call view and pass it the BookListViewModel which contains both the repository of Books and the Page Info
            return View(new BookListViewModel
            {
                // Set the Books = to _repository and make sure it only grabs the right ones for each page
                Books = _repository.Books
                .Where(p => category == null || p.Category == category )
                .OrderBy(p => p.BookId)
                .Skip((page -1) * numItemsOnPage)
                .Take(numItemsOnPage),
                Pageinfo = new PageInfo
                {
                    // Grab info for the Paging info
                    CurrentPage = page,
                    ItemsPerPage = numItemsOnPage,
                    TotalNumItems = _repository.Books.Count()
                },
                CurrentCategory = category
            });
                
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

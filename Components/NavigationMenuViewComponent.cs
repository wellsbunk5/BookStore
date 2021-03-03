using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    // This is a View Component object that creates the navigation menu for me
    public class NavigationMenuViewComponent : ViewComponent
    {
        private BookStoreRepository repository;
        public NavigationMenuViewComponent(BookStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            // set the selected category == to whatever the category they want is
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class PageInfo
    {
        // This is a class to keep track of the info needed to dynamically build pagination
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        // calculate the amount of pages that will be needed
        public int TotalPages => (int)Math.Ceiling((decimal)TotalNumItems / ItemsPerPage);
    }
}

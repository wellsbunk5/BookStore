using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class BookListViewModel
    {
        // This class is what we will pass to the html page. Instead of passing just one class we created this to pass multiple 
        // classes in this one class

        public IEnumerable<Book> Books { get; set; }
        public PageInfo Pageinfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    // Another weird file that i copied in the videos but still confused on how it works
    public class EFBookStore : BookStoreRepository
    {
        private BookStoreDBContext _context;

        public EFBookStore (BookStoreDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}

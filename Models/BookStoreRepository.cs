using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    // Also not 100% sure about what this really does
    public interface BookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}

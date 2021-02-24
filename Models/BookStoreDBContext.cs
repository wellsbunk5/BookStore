using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    // Not much is in here but this is kinda just taking a snapshot of the database to use
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            // set up the context variable
            BookStoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDBContext>();

            // if there is a knew migration then run it
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // if there is no data in the database then put this in
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95m,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "K.",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58m,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54m,
                        Pages = 832

                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254 ",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61m,
                        Pages = 864

                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492 ",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33m,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281 ",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95m,
                        Pages = 288

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691 ",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99m,
                        Pages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023  ",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66m,
                        Pages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984  ",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16m,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-1591847984  ",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 29.16m,
                        Pages = 642
                    },
                    new Book
                    {
                        Title = "Where's Waldo",
                        AuthorFirst = "Martin",
                        AuthorMiddle = "",
                        AuthorLast = "Handford",
                        Publisher = "Little Brown & Co",
                        ISBN = "978-1591840003  ",
                        Classification = "Fiction",
                        Category = "Children's Literature",
                        Price = 100.16m,
                        Pages = 19
                    },
                    new Book
                    {
                        Title = "There and Back Again",
                        AuthorFirst = "J.R.R",
                        AuthorMiddle = "",
                        AuthorLast = "Tolkien",
                        Publisher = "George Allen & Unwin",
                        ISBN = "978-1591840001  ",
                        Classification = "Fiction",
                        Category = "High Fantasy",
                        Price = 29.16m,
                        Pages = 310
                    },
                    new Book
                    {
                        Title = "The Book of Mormon",
                        AuthorFirst = "Mormon",
                        AuthorMiddle = "",
                        AuthorLast = "unknown",
                        Publisher = "LDS Books",
                        ISBN = "978-1591840002  ",
                        Classification = "Non-Fiction",
                        Category = "Scripture",
                        Price = 5.00m,
                        Pages = 238
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

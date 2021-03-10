﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This is the basic outline for a cart. But then we will use this and build on it with a session cart

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() =>
            Lines.Sum(b => (b.Book.Price * b.Quantity));

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}

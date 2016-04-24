using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_21Library
{
    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            this.Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.Books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            if (!this.Books.Contains(book))
            {
                throw new ArgumentException("Book doesn't exist.");
            }

            this.Books.Remove(book);
        }

    }
}

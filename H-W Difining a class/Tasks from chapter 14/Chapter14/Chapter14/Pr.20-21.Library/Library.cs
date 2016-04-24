using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._20_21.Library
{
    class Library
    {
        private string name;
        private List<Book> books;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public Library(string name)
        {
            this.name = name;
            this.books = new List<Book>();
        }

        public string AddBook(Book book)
        {
            books.Add(book);
            return "Book added.";
        }

        public string SearchAuthor(string author)
        {
            StringBuilder listWithSearchedBooks = new StringBuilder();
            bool isFoundBook = false;
            foreach (Book book in books)
            {
                if (book.Author.Equals(author))
                {
                    listWithSearchedBooks.Append(book.ToString());
                    isFoundBook = true;
                }
            }
            if (isFoundBook)
            {
                return listWithSearchedBooks.ToString();
            }
            else
            {
                return "Not found book of this author.";
            }
        }

        public string SearchTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title))
                {
                    return book.ToString();
                }
            }
            return "Not found.";
        }

        public string DeleteBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                return "Book deleted.";
            }
            else
            {
                return "Book not found.";
            }
        }

        public string DeleteAllBooks(string author)
        {
            int numberOfBooksBeforeDel = books.Count;
            books.RemoveAll(x => x.Author == author);
            int numberOfBooksAfterDel = books.Count;
            int deletedBooks = numberOfBooksBeforeDel - numberOfBooksAfterDel;
            return deletedBooks.ToString() + " Book deleted.";
        }
    }
}

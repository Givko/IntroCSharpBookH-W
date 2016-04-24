using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_21Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string YearOfPublishing { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string publisher, string ISBN)
            : this(title, author, publisher, ISBN, null)
        {

        }
        public Book(string title, string author, string publisher, string ISBN, string yearOfPublishing)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ISBN = ISBN;
            this.YearOfPublishing = yearOfPublishing;
        }

        public override string ToString()
        {
            StringBuilder bookInfo = new StringBuilder(string.Format("Title: {0}{1}Author: {2}{1}Publisher: {3}{1}ISBN: {4}{1}",
                this.Title, Environment.NewLine, this.Author, this.Publisher, this.ISBN));

            if (!String.IsNullOrEmpty(this.YearOfPublishing))
            {
                bookInfo.Append(string.Format("Year of publishing: {0}{1}", this.YearOfPublishing, Environment.NewLine));
            }

            return bookInfo.ToString();
        }
    }
}

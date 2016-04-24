
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._20_21.Library
{
    class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int yearOfPublishing;
        private string ISBN;

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public string Publisher
        {
            get { return publisher; }
        }

        public int YearOfPublishing
        {
            get { return yearOfPublishing; }
        }

        public string ISBNNumber
        {
            get { return ISBN; }
        }

        public Book(string title, string author, string publisher, int yearOfPublishing, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublishing = yearOfPublishing;
            this.ISBN = ISBN;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Title: " + title);
            sb.Append(System.Environment.NewLine);
            sb.Append("Author: " + author);
            sb.Append(System.Environment.NewLine);
            sb.Append("Publisher: " + publisher);
            sb.Append(System.Environment.NewLine);
            sb.Append("Year of publishing: " + yearOfPublishing);
            sb.Append(System.Environment.NewLine);
            sb.AppendLine("ISBN: " + ISBN);
            return sb.ToString();
        }
    }
}

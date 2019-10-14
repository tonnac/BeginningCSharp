using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_Override
{
    class Book
    {
        decimal isbn13;
        string title;
        string contents;

        public Book(decimal isbn13, string title, string contents)
        {
            this.isbn13 = isbn13;
            this.title = title;
            this.contents = contents;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            Book book = obj as Book;

            if(book == null)
            {
                return false;
            }

            return this.isbn13 == book.isbn13;
        }

        public override int GetHashCode()
        {
            return this.isbn13.GetHashCode();
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

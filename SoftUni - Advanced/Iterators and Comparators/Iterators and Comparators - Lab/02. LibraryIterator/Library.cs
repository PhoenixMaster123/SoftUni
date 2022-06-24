using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library: IEnumerable<Book>
    {
        private readonly List<Book> books;

        //public Library(params Book [] books)
        //{
        //    this.books = new List<Book>(books);
        //}
        public Library(params Book [] _books)
        {
            books = new List<Book>(_books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books) ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;

            private int currentIndex = -1;

            public LibraryIterator(IEnumerable<Book> _books)
            {
                Reset();
                books = new List<Book>(_books);
            }
            public bool MoveNext() => ++currentIndex < books.Count;

            public void Reset()
            {
                currentIndex = -1;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose() { }
        }
    }
}

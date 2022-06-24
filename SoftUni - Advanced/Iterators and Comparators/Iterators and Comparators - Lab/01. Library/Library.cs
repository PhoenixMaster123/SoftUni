using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorsAndComparators;

namespace IteratorsAndComparators
{
    public class Library: IEnumerable< Book>
    {
        public Library(params Book [] books)
        {
            Books = books.ToList();
        }

        public List< Book > Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator: IEnumerator<Book>
        {
            public bool MoveNext()
            {
                return ++index<Books .Count ;
            }

            public void Reset()
            {
                index = -1;
            }

            private int index= -1;

            public LibraryIterator(List< Book>books)
            {
                Books = books;
            }
            
            public List< Book> Books { get; set; }

            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose() {}
        }
    }
}

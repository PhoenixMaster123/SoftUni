package _02_Library;

import java.util.Iterator;

public class Library implements Iterable<Book> {
    private Book[] books;

    public Library(Book... books) {
        this.books = books;
    }
    // Variant 1:
    public Iterator<Book> iterator() {
        return new Iterator<Book>() {
            private int index = 0;
            @Override
            public boolean hasNext() {
                return index < books.length;
            }

            @Override
            public Book next() {
                return books[index++];
            }
        };
        // Variant 2:
        // return new BookIterator();
    }
    // Variant 2:
    private class BookIterator implements Iterator<Book> {

        private int index = 0;
        @Override
        public boolean hasNext() {
            return index < books.length;
        }

        @Override
        public Book next() {
           Book book = books[index];
           index++;
           return book;
        }
    }
}

package Demo_Iterator;

import java.util.Iterator;
import java.util.List;

// NOTE: Iterable & Iterator are always together
// Iterable ⇒ we can from now on iterate this class
// Iterator ⇒ how to iterate this class

// book implements Iterable from String == I can iterate my class
// implements Iterable<type>
public class Book implements Iterable<String>{ // Iterable → give opportunity our class to can iterate (обходим)
    private List<String> pages; // I will iterate this List<String> pages

    public Book(String... pages) {
        this.pages = List.of(pages);
    }

    // How to iterate this pages?

    // Iterator = the way that the elements will iterate in this class
    // Iterator<type data that will be iterating>

    // Variant 1: We create one more class
    public Iterator<String> iterator() {
        return new PageIterator();
    }
    // Inside class that describe how the pages will be iterating in our book class
    // What can do this Iterator<type>?
    // 1. Need to know if it has the next element
    // 2. Need to return the next element
    private class PageIterator implements Iterator<String> {

        private int index = 0;
        public boolean hasNext() {
            return index < pages.size();
        }
        public String next() {
            String page = pages.get(index);
            index++;
            return page;
        }
    }
    // Variant 2: We create one more class
    /*public Iterator<String> iterator() {
        return new Iterator<String>() { // anonym class
            @Override
            public boolean hasNext() {
                return false;
            }

            @Override
            public String next() {
                return null;
            }
        };
    }
     */
}

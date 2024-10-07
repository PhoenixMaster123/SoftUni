package _04_BookComparator;

import java.util.Comparator;

public class BookComparator implements Comparator<Book> { // like that, we don't change the class
    @Override
    public int compare(Book book1, Book book2) {

        // 1. compare book by title
        int result = book1.getTitle().compareTo(book2.getTitle());

        // if they are equal
        if(result == 0) {
            // 2. compare by year
            result = Integer.compare(book1.getYear(), book2.getYear());
        }

        return result;
    }
}

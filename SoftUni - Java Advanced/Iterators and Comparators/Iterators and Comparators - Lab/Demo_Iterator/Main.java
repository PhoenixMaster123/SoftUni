package Demo_Iterator;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        // interface → give behavior of given class

        List<Integer> numbers = new ArrayList<>();
        for (Integer number : numbers) {
            System.out.println(number);
        }

        Book book = new Book("page1", "page2", "page3");

        // 1. Give me iterator in our class
        // 2. Ask the iterator if we have next element
        // 3. If it has the next element, give me the next element
        for (String page : book) {
            System.out.println();
        }
    }
}

package Demo_Comparator;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        Cat cat1 = new Cat("Maca", 4, 5.0);
        Cat cat2 = new Cat("Mica", 6, 3.0);
        Cat cat3 = new Cat("Ivan", 2, 2.0);

        List<Cat> catList = new ArrayList<>();

        Collections.sort(catList); // .reversed();

        TreeSet<Cat> treeSet = new TreeSet<>();

    }
}

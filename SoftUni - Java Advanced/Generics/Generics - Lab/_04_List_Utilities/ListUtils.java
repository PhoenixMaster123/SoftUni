package _04_List_Utilities;

import java.util.Collections;
import java.util.List;

public class ListUtils {

    // I want a list of elements that needs to be comparable with his own type!!!
    public static<E extends Comparable<E>> E getMin(List<E> list) {
        if(list.isEmpty()) {
            throw new IllegalArgumentException("The list is empty");
        }
        // <T extends Object → needs to be an object
        // &
        // Comparable<T> → needs to can be comparable(сравним) need to compare with his type | example: (String with String)
        return Collections.min(list);
    }
    public static<E extends Comparable<E>> E getMax(List<E> list) {
        if(list.isEmpty()) {
            throw new IllegalArgumentException("The list is empty");
        }
        return Collections.max(list);
    }
}

package exercise._08_Custom_List_Sorter;


import java.util.Collections;
import java.util.List;

public class Sorter {
    public static <T extends Comparable<T>> void sort(CustomList<T> customList) {
        Collections.sort((List<T>) customList);
    }
}

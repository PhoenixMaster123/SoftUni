package exercise._07_Custom_List_2;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class CustomList<T extends Comparable<T>> {
    List<T> customList;

    public CustomList() {
        this.customList = new ArrayList<>();
    }
    public void add (T element) {
        customList.add(element);
    }
    public T remove(int index) {
        return customList.remove(index);
    }
    public boolean contains(T element) {
        return customList.contains(element);
    }
    public void swap(int index1, int index2) {
        T firstElement = customList.get(index1);
        T secondElement = customList.get(index2);

        customList.set(index2, firstElement);
        customList.set(index1, secondElement);
    }
    public int countGreaterThan(T element) {
        int counter = 0;
        for (T ele : customList) {
            if(ele.compareTo(element) >= 1) {
                counter++;
            }
        }
        return counter;
    }
    public T getMax() {
        return Collections.max(customList);
    }
    public T getMin() {
        return Collections.min(customList);
    }
    public void print() {
        customList.forEach(System.out::println);
    }
}

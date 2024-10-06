package exercise._07_Custom_List;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;

public class CustomList<T extends Comparable<T>> implements Iterable<T> {
    List<T> data;
    public CustomList() {

        this.data = new ArrayList<>();
    }
    public void add(T element) {
        this.data.add(element);
    }
    public T remove(int index) {
        checkIndex(index);
        return this.data.remove(index);
    }

    private void checkIndex(int index) {
        if(index < 0 || index >= this.data.size()) {
            throw new IndexOutOfBoundsException("Index out of bounds");
        }
    }

    public boolean contains(T element) {
        return this.data.contains(element);
    }
    public void swap(int index1, int index2) {
        checkIndex(index1);
        checkIndex(index2);
        Collections.swap(this.data, index1, index2);
    }
    public int countGreaterThat(T element){
        int count = 0;

        for (T e : data) {
            int res = e.compareTo(element);
            if(res > 0) {
                count++;
            }
        }
        return count;
    }
    public T getMax() {
        checkEmpty();
        return Collections.max(this.data);
    }
    public int size() {
        return this.data.size();
    }
    public T get(int index) {
        return this.data.get(index);
    }
    public T getMin() {
        checkEmpty();

        return Collections.min(this.data);
    }

    private void checkEmpty() {
        if(this.data.isEmpty()) {
            throw new IllegalStateException("List is empty");
        }
    }

    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() { // anonym class

            private int index = 0;

            @Override
            public boolean hasNext() {
                return this.index < data.size();
            }

            @Override
            public T next() {
                return data.get(index++);
            }
        };
    }
}

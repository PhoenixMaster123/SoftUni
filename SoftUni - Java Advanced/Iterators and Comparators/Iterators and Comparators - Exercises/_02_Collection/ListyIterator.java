package _02_Collection;
import java.util.Iterator;
import java.util.List;

public class ListyIterator<T> implements Iterable<T> {
    private List<T> listElements;
    private int currentIndex;

    public ListyIterator(T...elements) {
        this.listElements = List.of(elements);
        this.currentIndex = 0;
    }
    public boolean move() {
        if(hasNext()) {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public boolean hasNext() {
        return this.currentIndex < this.listElements.size() - 1;
    }
    public void print() {
        if(listElements.isEmpty()) {
            throw new IllegalStateException("Invalid Operation!");
        }
        else {
            System.out.println(this.listElements.get(this.currentIndex));
        }
    }

    @Override
    public Iterator<T> iterator() {
        return new ListIterator();
    }
    private class ListIterator implements Iterator<T> {

        private int index = 0;
        @Override
        public boolean hasNext() {
            return index < listElements.size();
        }

        @Override
        public T next() {
            return listElements.get(index++);
        }
    }
}

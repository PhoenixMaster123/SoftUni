package _04_Froggy;

import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.ArrayList;

class Lake implements Iterable<Integer> {
    private List<Integer> numbers;

    public Lake(Integer[] numbers) {
        this.numbers = new ArrayList<>();
        this.numbers.addAll(Arrays.asList(numbers));
    }

    public List<Integer> getList() {
        return numbers;
    }

    @Override
    public Iterator<Integer> iterator() {
        return new Frog();
    }

    private class Frog implements Iterator<Integer> {
        private List<Integer> jumps;
        private int index = 0;

        public Frog() {
            this.jumps = new ArrayList<>();
            // Collect even-indexed elements first
            for (int i = 0; i < numbers.size(); i += 2) {
                jumps.add(numbers.get(i));
            }
            // Collect odd-indexed elements next
            for (int i = 1; i < numbers.size(); i += 2) {
                jumps.add(numbers.get(i));
            }
        }

        @Override
        public boolean hasNext() {
            return index < jumps.size();
        }

        @Override
        public Integer next() {
            return jumps.get(index++);
        }
    }
}

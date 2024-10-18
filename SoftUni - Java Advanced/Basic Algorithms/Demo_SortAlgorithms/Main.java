package Demo_SortAlgorithms;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        // Buble Sort:

        // Take one sequence of elements and sort them. Takes pairs and check them, which
        // element is bigger (right), smaller (left) → after the first iteration, we receive
        // the biggest element. Bubble sort: length of a sequence = number of iterations.
        // Complexity -> O (n^2) | Memory -> O(1) | It's like Comparator

        int[] numbers = new int[] {1, 3, 4, 2, 5, 6};

        // CODE:

        for (int i = 0; i < numbers.length; i++) { // We start from the first element
            for (int j = i + 1; j < numbers.length - 1; j++) { // We start from the second element
                if(numbers[i] > numbers[j]) { // if(first > second) -> swap
                    int tempNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tempNum;
                }
            }
        }
        System.out.println(Arrays.toString(numbers));

        // Selection Sort:
        // → make every time full iteration of all elements and check which element is the smallest
        // Complexity -> O(n^2)


        // BOGO SORT: -> inefficient
        // Shuffle the sequence of elements until you receive the correct one

        // CODE:

        List<Integer> elements = Arrays.asList(2, 5, 6, 7, 8, 2, 3, 1); // unsorted list

        List<Integer> sortedElements = Arrays.asList(2, 5, 6, 7, 8, 2, 3, 1); // sorted list
        Collections.sort(sortedElements); // we sort the elements

        int counter = 0; // check how many iterations are necessary
        while (true) {
            Collections.shuffle(elements); // every time shuffle until find the right combination
            counter++;
            if(Arrays.equals(elements.toArray(), sortedElements.toArray())) { // check if the arrays are equal
                System.out.println("After " + counter + " iterations, the list is sorted!");
                return;
            }
        }


    }
}

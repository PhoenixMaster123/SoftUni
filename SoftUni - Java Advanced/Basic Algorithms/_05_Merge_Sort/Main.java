package _05_Merge_Sort;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        // ASC ORDER:
        int[] sorted = mergeSort(nums);

        for (int num : sorted) {
            System.out.print(num + " ");
        }
    }

    private static int[] mergeSort(int[] array) {
        // We check if we have reached the bottom of the recursion:
        if(array.length == 1) {
            return array;
        }
        // We take the middle element:
        int halfIndex = array.length / 2;

        // We take the length of the first and second half of the array:
        int firstArrayLength = halfIndex;
        int secondArrayLength =  array.length - halfIndex;

        // Create new arrays with the new length:
        int[] firstPartition = new int[firstArrayLength];
        int[] secondPartition = new int[secondArrayLength];

        // Fill the arrays with values:
        for (int i = 0; i < firstArrayLength; i++) {
            firstPartition[i] = array[i];
        }
        for (int i = firstArrayLength; i < firstArrayLength + secondArrayLength; i++) {
            secondPartition[i - firstArrayLength] = array[i];
        }
        // We do the same thing until we reach an array of one element
        firstPartition = mergeSort(firstPartition);
        secondPartition = mergeSort(secondPartition);

        // Backtrack:

        // mainIndex ⇒ the index of our original array:
        int mainIndex = 0;

        // Indexes of our two other arrays:
        int firstPartitionIndex = 0;
        int secondPartitionIndex = 0;

        // The loop go through both arrays and will finish only when one of two indexes reaches its array length:
        while (firstPartitionIndex < firstArrayLength && secondPartitionIndex < secondArrayLength) {

            // We compare the first element from the first array with the element from the second array:

            // If the element from the first array is lower, it will be put on the current position in the main array:
            if(firstPartition[firstPartitionIndex] < secondPartition[secondPartitionIndex]) {
                array[mainIndex] = firstPartition[firstPartitionIndex];

                mainIndex++;
                firstPartitionIndex++;
            }
            // If NOT, the second array with this element, will be put on the current position in the main array:
            else {
                array[mainIndex] = secondPartition[secondPartitionIndex];

                mainIndex++;
                secondPartitionIndex++;
            }
        }
        // We check the both arrays: one of them is traversed totally, but the other not.
        // We only add the remaining elements of the array that are not traversed fully.
        while (firstPartitionIndex < firstArrayLength) {
            array[mainIndex] = firstPartition[firstPartitionIndex];

            mainIndex++;
            firstPartitionIndex++;
        }

        while (secondPartitionIndex < secondArrayLength) {
            array[mainIndex] = secondPartition[secondPartitionIndex];

            mainIndex++;
            secondPartitionIndex++;
        }

        return array;
    }
}

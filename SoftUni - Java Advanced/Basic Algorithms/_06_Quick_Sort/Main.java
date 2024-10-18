package _06_Quick_Sort;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        /*
        We pick the first element from the unsorted partition and move it in such a way that all smaller elements are on its left and all greater to its right.
        With the pivot moving to its correct place, we now have two unsorted partitions – one to the left of it and one to the right.
        Call the procedure recursively for each partition
        The bottom of the recursion is when a partition has a size of 1, which is by definition sorted
         */

       quickSort(nums);

        for (int num : nums) {
            System.out.print(num + " ");
        }
    }

    private static void quickSort(int[] arr) {
        sort(arr, 0, arr.length - 1);
    }

    // arr[] → Array to be sorted
    // low → Starting index
    // high → Ending index
    private static void sort(int[] arr, int low, int high) {
        if(low < high) {
            // Find pivot element
            int partitionIndex = partition(arr, low, high);

            // Sort the left and right partitions recursively
            sort(arr, low, partitionIndex - 1);
            sort(arr, partitionIndex + 1, high);
        }
    }
    /*
      This method takes last elements as pivot, places the pivot elements at its correct position
      in a sorted array, and places all smaller than pivot to the left side and all greater to the right side
    */
    private static int partition(int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = (low - 1); // index of the smaller element

        for (int j = low; j < high; j++) {

            // if the current element is smaller than or equal to pivot
            if(arr[j] <= pivot) {
                i++;
                // Swap elements:
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Swap arr[i + 1], and arr[high] (pivot)
        int temp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp;

        return i + 1;
    }
}

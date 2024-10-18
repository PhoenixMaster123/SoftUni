package Demo_SearchAlgorithms;

public class Main {
    public static void main(String[] args) {

        // Linear search: → check every one of the elements in the sequence.
        // Complexity -> O(n)

        // CODE:
        int[] data = new int[] {1, 5, 6, 2, 3, 7};
        System.out.println(linearSearch(data, 2));

        // Binary search: → only works if the sequence is sorted!!!
        // From the beginning I have the first and the last index (element)
        // Finds the middle element → at each step, compare the input with the middle element.
        // If it is bigger or smaller than this element, or it is exactly the middle one.
        // If it is not the middle element, the algorithm takes the element besides him.
        // That means if it is bigger (right) if it is smaller (left).
        // The algorithm repeats its action to the left or right sub-structure, until find the correct element.
        // Complexity -> O(log(n))

        // CODE:
        int[] arrayData = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        System.out.println(binarySearch(arrayData, 7, 0,arrayData.length - 1));

    }
    public static int binarySearch(int[] arrayData, int key, int start, int end) {
        while (start <= end) {
            int mid = (start + end) / 2; // split the array

            if (arrayData[mid] < key) { // element < key
                start = mid + 1;
            } else if (arrayData[mid] > key) { // element > key
                end = mid - 1;
            } else {
                return mid; // if it's exactly the middle element
            }
        }
        return -1;
    }
    public static int linearSearch(int[] listData, int value) {
        int index = 0;

        while (index < listData.length) {
            if (listData[index] == value) {
                return index;  // Return the index if the value is found
            }
            index++;
        }
        return -1;
    }
}

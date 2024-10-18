package _07_Binary_Search;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int element = Integer.parseInt(scanner.nextLine());

        int index = binarySearch(nums, element, 0, nums.length - 1);
        System.out.println(index);

    }

    private static int binarySearch(int[] data, int key, int start, int end) {

        while (start <= end) {

            int mid = (start + end) / 2;

            if(data[mid] < key) {
                start =  mid + 1;
            } else if(data[mid] > key) {
                end = mid - 1;
            } else {
                return mid;
            }
        }
        return -1;
    }
}

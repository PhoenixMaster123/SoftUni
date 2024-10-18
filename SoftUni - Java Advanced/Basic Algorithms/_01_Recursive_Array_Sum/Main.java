package _01_Recursive_Array_Sum;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        //System.out.println(sum(numbers, 0, 0));
        System.out.println(sum(numbers, 0));
    }

    private static int sum(int[] numbers, int index) {

        int result = numbers[index];

        if(index == numbers.length - 1) {
            return result;
        }
        return result + sum(numbers, index + 1);
    }

    /*private static int sum(int[] numbers, int counter, int result) {
        if(counter == numbers.length) {
            return result;
        }
        return sum(numbers, counter + 1, result + numbers[counter]);
    }
     */
}
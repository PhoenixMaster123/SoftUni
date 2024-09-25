package lab._02_Sum_Numbers;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.function.Function;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(", "))
                .map(Integer::parseInt).toList();


        // Variant 1:
        /*long count = numbers.stream().count(); <=> numbers.size();
        long sum = numbers.stream().mapToInt(Integer::intValue).sum();
        System.out.println("Count = " + count);
        System.out.println("Sum = " + sum);
         */

        // Variant 2:
        /*Function<List<Integer>, Integer> funcSum = count ->
        {
            int sum = 0;
            for (Integer num : numbers)
            {
                sum += num;
            }
            return sum;
        };
        System.out.println("Count = " + numbers.stream().count()); <=> numbers.size();
        System.out.println("Sum = " + funcSum.apply(numbers));
         */


    }
}

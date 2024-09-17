package lab._09_Largest_3_Numbers;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.concurrent.atomic.AtomicInteger;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        // Variant 1:
        List<Integer> numbers1 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .sorted(Comparator.reverseOrder())
                        .limit(3).toList();

       numbers1.forEach(n -> System.out.print(n + " "));

       System.out.println();

       // Variant 2:
        AtomicInteger counter = new AtomicInteger(0);
        int limit = 3; // Set the limit to 3

        List<Integer> numbers2 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .sorted((n1, n2) -> n2.compareTo(n1)) // Sort in descending order
                .filter(n -> counter.getAndIncrement() < limit). // Use the counter to limit
                toList();

        numbers2.forEach(n -> System.out.print(n + " "));


    }
}

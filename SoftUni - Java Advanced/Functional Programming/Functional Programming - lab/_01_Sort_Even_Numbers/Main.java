package lab._01_Sort_Even_Numbers;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // If we make it toList is immutable but
        // if we do it collect(Collectors.toList()) is mutable
       // List<Integer> numbers = Arrays.stream(scanner.nextLine().split(", "))
       //         .map(Integer::parseInt).filter(num -> num % 2 == 0).toList();

        // Variant 1:
        /*List<Integer> numbers = Arrays.stream(scanner.nextLine().split(", "))
                 .map(Integer::parseInt)
                .filter(num -> num % 2 == 0)
                .collect(Collectors.toList());

        String x = numbers.toString().replaceAll("\\[", "").replaceAll("]", "");
        System.out.println(x);
        Collections.sort(numbers);
        System.out.println(x);
         */

        // Variant 2:
        /*List<Integer> numbers = Arrays.stream(scanner.nextLine().split(", "))
                 .map(Integer::parseInt).collect(Collectors.toList());
        numbers.removeIf(num -> num % 2 != 0);
        String x = numbers.toString().replaceAll("\\[", "").replaceAll("]", "");
        System.out.println(x);
        numbers.sort(Integer::compareTo);
        x = numbers.toString().replaceAll("\\[", "").replaceAll("]", "");;
        System.out.println(x);
         */

        // Variant 3:
       /* List<Integer> numbers2 = Arrays.stream(scanner.nextLine().split(", "))
                .map(Integer::parseInt).toList();
        List<Integer> list = numbers2.stream().filter(n -> n % 2 == 0).toList();
        System.out.println(list.stream().map(String::valueOf).collect(Collectors.joining(", ")));
        System.out.println(list.stream().sorted().map(String::valueOf).collect(Collectors.joining(", ")));
        */



    }
}
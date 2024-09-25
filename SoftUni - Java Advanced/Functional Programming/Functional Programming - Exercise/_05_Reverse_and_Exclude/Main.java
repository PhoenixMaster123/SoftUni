package exercise._05_Reverse_and_Exclude;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.function.Consumer;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" ")).map(Integer::parseInt).collect(Collectors.toList());
        int divisibleElement = Integer.parseInt(scanner.nextLine());

        Collections.reverse(numbers);

        // Variant 1:
        Predicate<Integer> isNotDivisible = div -> div % divisibleElement != 0;
        Consumer<Integer> printNumbers = num -> System.out.print(num + " ");

        numbers.stream().filter(isNotDivisible).forEach(printNumbers);

        // Variant 2:

        //Predicate<Integer> isDivisible = div -> div % divisibleElement == 0;
        //numbers.stream().filter(isDivisible.negate()).forEach(printNumbers);
    }
}

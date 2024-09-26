package lab._06_Find_Evens_or_Odds;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Predicate;
import java.util.stream.IntStream;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int[] bounds = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        String condition = scanner.nextLine();

        // Variant 1:

        if(condition.equals("even"))
        {
            // Variant 1:
            //printNumbers(bounds, number -> number % 2 == 0);

            // Variant 2:
            IntStream.range(bounds[0], bounds[1] + 1)
                    .filter(number -> number % 2 == 0)
                    .forEach(num -> System.out.print(num + " "));
        }
        else
        {
            printNumbers(bounds, number -> number % 2 != 0);
        }


        // Variant 2:
        /*for (int num = range[0]; num <= range[1]; num++)
        {
            if (isEvenOrOdd(condition).test(num)) {
                System.out.print(num + " ");
            }
        }
         */
    }

    private static void printNumbers(int[] bounds, Predicate<Integer> condition)
    {
        for (int number = bounds[0]; number <= bounds[1]; number++) {
            if(condition.test(number))
            {
                System.out.print(number + " ");
            }
        }
        System.out.println();
    }
    // Variant 2:
  /*  public static Predicate<Integer> isEvenOrOdd(String evenOrOdd)
    {
        return number ->
                switch (evenOrOdd) {
                    case "even" -> number % 2 == 0;
                    case "odd" -> number % 2 != 0;
                    default -> false;
                };
    }
   */

}

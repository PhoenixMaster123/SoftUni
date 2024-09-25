package exercise._08_Custom_Comparator;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {


        Scanner scanner = new Scanner(System.in);

        // comparator -> function accept 2 Parameters and return int (0 1 -1)
        // 0 -> first == second
        // 1 -> first > second
        // 2 -> first < second

        // sorted(0) -> not swap the elements
        // sorted(1) -> swap the elements
        // sorted(-1) -> not swap the elements


        Comparator<Integer> customComparator = (first, second) ->
        {
            // first even, second odd -> don't swap
            // first odd, second even -> swap
            // sort ascending order

            if(first % 2 == 0 && second % 2 != 0)
            {
                return -1;
            }
            else if(first % 2 != 0 && second % 2 == 0)
            {
                return 1;
            }
            else
            {
                return first.compareTo(second);
            }
        };
        Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .sorted(customComparator)
                .forEach(num -> System.out.print(num + " "));


    }
}

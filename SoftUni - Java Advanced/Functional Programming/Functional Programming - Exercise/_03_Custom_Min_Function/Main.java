package exercise._03_Custom_Min_Function;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;
import java.util.function.Function;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        Integer[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        Function<Integer[], Integer> minFunction = arr -> // in a function we can write int[] (Object) -> reason
        {
            int min = Integer.MAX_VALUE;

            for (Integer num : arr)
            {
                if(min > num)
                {
                    min = num;
                }
            }
            return min;
        };
        System.out.println(minFunction.apply(numbers));
    }
}

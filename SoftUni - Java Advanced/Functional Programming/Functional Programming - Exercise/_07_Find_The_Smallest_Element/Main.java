package exercise._07_Find_The_Smallest_Element;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Function;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" ")).map(Integer::parseInt).toList();

        Function<List<Integer>, Integer> minFunction = listNumbers ->
        {
            int min = Integer.MAX_VALUE;
            int index = 0;

            for (int i = 0; i < listNumbers.size(); i++)
            {
                if(min >= listNumbers.get(i))
                {
                    min = listNumbers.get(i);
                    index = i;
                }
            }

            return index;
        };
        System.out.println(minFunction.apply(numbers));
    }
}

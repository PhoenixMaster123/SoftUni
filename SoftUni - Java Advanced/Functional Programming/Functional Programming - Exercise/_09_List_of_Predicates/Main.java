package exercise._09_List_of_Predicates;

import java.util.Arrays;
import java.util.Scanner;
import java.util.function.Predicate;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int range = Integer.parseInt(scanner.nextLine());
        int[] divisibleElements = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        Predicate<Integer> isDivisible = num ->
        {
            boolean div = false;
            for (int i = 0; i < divisibleElements.length; i++)
            {
                if(num % divisibleElements[i] == 0)
                {
                    div = true;
                }
                else
                {
                    return false;
                }
            }
            return div;
        };

        for (int i = 1; i <= range; i++)
        {
            if(isDivisible.test(i))
            {
                System.out.print(i + " ");
            }
        }

    }
}

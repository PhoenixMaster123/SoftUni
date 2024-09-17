package exercise._02_Sets_of_Elements;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] inputLength = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        Set<Integer> firstSet = new LinkedHashSet<>();
        Set<Integer> secondSet = new LinkedHashSet<>();

        int n = inputLength[0];
        int m = inputLength[1];



        for (int i = 0; i < n; i++)
        {
            firstSet.add(Integer.parseInt(scanner.nextLine()));
        }
        for (int i = 0; i < m; i++)
        {
                secondSet.add(Integer.parseInt(scanner.nextLine()));
        }
        // return the elements that contains the second set
        firstSet.retainAll(secondSet);
        firstSet.forEach(num -> System.out.print(num + " "));
    }
}

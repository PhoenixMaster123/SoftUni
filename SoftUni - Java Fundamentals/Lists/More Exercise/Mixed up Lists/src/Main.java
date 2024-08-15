import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers1 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).toList();
        List<Integer> numbers2 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).toList();

        List<Integer> copy1 = new ArrayList<>(numbers1);
        List<Integer> copy2 = new ArrayList<>(numbers2);
        int size = 0;
        int border1;
        int border2;
        if (copy1.size() > copy2.size())
        {
            size = copy1.size();
            border1 = copy1.getLast();
            border2 = copy1.get(copy1.size() - 2);
        }
        else
        {
            size = copy2.size();
            border1 = copy2.getFirst();
            border2 = copy2.get(1);
        }
        int lowerBound = Math.min(border1, border2);
        int upperBound = Math.max(border1, border2);

        List<Integer> mixedList  = new ArrayList<>();
        for (int i = 0; i < size - 2; i++)
        {
            mixedList .add(copy1.get(i));
            mixedList .add(copy2.get(copy2.size() - 1 - i));
        }
       // Collections.sort(mixedList);
        ////////////////////////// Variant 1 -> Stream API /////////////////////////
        /*String output = result.stream()
                .filter(num -> num > lowerBound && num < upperBound)
                .sorted()
                .map(String::valueOf) // Convert integers to strings
                .collect(Collectors.joining(" ")); // Join with a space as delimiter

        System.out.println(output.trim());
         */
        ////////////////////////// Variant 2 -> Stream API /////////////////////////
        /*for (Integer num : mixedList)
        {
            if (num > lowerBound && num < upperBound)
            {
                System.out.print(num + " ");

            }
        }
         */

        for (Integer num2 : mixedList.stream().filter(num -> num > lowerBound && num < upperBound).sorted().toList())
        {
            System.out.print(num2 + " ");
        }

    }
}
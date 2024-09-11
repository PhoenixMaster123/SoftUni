package Stack.Basic_Stack_Operations;

import java.util.*;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int[] commands = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")) // return 0 0 ...
                .mapToInt(Integer::parseInt).toArray(); // return IntStream (I can use sum, max, min and etc.)
        //Integer[] numbers2 = Arrays.stream(scanner.nextLine().split(" ")) // Stream<Integer>
        //        .map(Integer::parseInt).toArray(Integer[]::new); // return null null ...

        Deque<Integer> stack = new ArrayDeque<>();
        Arrays.stream(numbers).forEach(stack::push);


        for (int i = 0; i < commands[1]; i++)
        {
            stack.pop();
        }
        if (stack.isEmpty())
        {
            System.out.print(0);
        }
        else if(stack.contains(commands[2]))
        {
            System.out.print(true);
        }
        else
        {
            /*Optional<Integer> minElement = stack.stream().min(Comparator.naturalOrder());
            minElement.ifPresent(System.out::println);
             */
            System.out.print(Collections.min(stack));
        }
    }
}

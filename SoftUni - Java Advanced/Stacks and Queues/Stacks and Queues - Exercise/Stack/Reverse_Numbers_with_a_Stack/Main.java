package Stack.Reverse_Numbers_with_a_Stack;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        /*List<Integer> numbers = Arrays.stream(scanner.nextLine()
                .split(" ")).map(Integer::parseInt).toList(); */

        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        ArrayDeque<Integer> stack = new ArrayDeque<>();

        ///////////////////////////////////// Variant with Stack /////////////////

        //For-Each Loop to add the elements:
       /* for (int number : numbers) {
            stack.push(number); // We use push to make it like Stack
        }
        */
        // Better
        Arrays.stream(numbers).forEach(stack::push);

        // While Loop:
        while (!stack.isEmpty()) // I can use every possible loop to iterate
        {
            System.out.print(stack.pop() + " ");
        }

        ///////////////////////////////////// Variant with Queue /////////////////

        // For-Each Loop to add the elements:
        /* for (int number : numbers) {
            stack.offer(number); // We use offer to make it like Queue
        }
         */

        ///////////////////////////// Variant 1 with Queue //////////////////////

        // Using Queue:
      /* while (!stack.isEmpty()) {
            System.out.print(stack.pollLast() + " ");
        }
       */

        ///////////////////////////// Variant 2 with Queue //////////////////////

        // Note: do not use for reversing

        //Deque<Integer> d = stack.reversed(); //-> I can reverse the Queue

         /* while (!d.isEmpty()) {
            System.out.print(d.poll() + " ");
        }
       */
    }
}

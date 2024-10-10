package exam_26_October_2019.Dating_App;

import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Deque;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] males = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] females = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Deque<Integer> stack = new ArrayDeque<>(); // males
        Deque<Integer> queue = new ArrayDeque<>(); // females

        Arrays.stream(males).forEach(stack::push);
        Arrays.stream(females).forEach(queue::offer);

        int matchCounter = 0;
        while (!stack.isEmpty() && !queue.isEmpty()) {

            // Check if is zero or negative:
            cleanUp(stack, true);
            cleanUp(queue, false);


            if (stack.isEmpty() || queue.isEmpty()) break;

            if(specialCase(stack, true)) {
                continue;
            }
            if(specialCase(queue, false)) {
               continue;
            }

            if(stack.peek() == queue.peek()) {
                stack.pop();
                queue.poll();
                matchCounter++;
            }
            else {
                queue.poll();
                Integer currentMale = stack.pop();
                stack.push(currentMale - 2);
            }
        }
        System.out.printf("Matches: %d\n", matchCounter);

        System.out.print("Males left: ");
        String malesResult = stack.isEmpty() ? "none" : getElements(stack);
        System.out.print(malesResult + "\n");

        System.out.print("Females left: ");
        String femalesResult = queue.isEmpty() ? "none" : getElements(queue);
        System.out.print(femalesResult);
    }

    private static String getElements(Deque<Integer> deque) {
        return deque.stream()
                .map(String::valueOf)
                .collect(Collectors.joining(", "));
    }
    private static void cleanUp(Deque<Integer> deque, boolean isStack) {
        if(isStack) {
            while (!deque.isEmpty() && deque.peek() <= 0) {
                deque.pop();
            }
        }
        else {
            while (!deque.isEmpty() && deque.peek() <= 0) {
                deque.poll();
            }
        }
    }
    public static boolean specialCase(Deque<Integer> deque, boolean isStack) {
        if(isStack) {
            if(deque.peek() % 25 == 0) {
                deque.pop();
                if(!deque.isEmpty()) {
                    deque.pop();
                }
                return true;
            }
        }
        else {
            if(deque.peek() % 25 == 0) {
                deque.poll();
                if(!deque.isEmpty()) {
                    deque.poll();
                }
                return true;
            }
        }
        return false;
    }

}

package Stack.Recursive_Fibonacci_Stack;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        Deque<Long> stack = new ArrayDeque<>();

        // First we need to add the start point 0 & 1

        stack.push(0L);
        stack.push(1L);

        if(n < 2)
        {
            System.out.println(1);
            return;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                // We take both numbers from the stack
                long num1 = stack.pop(); // n - 1
                long num2 = stack.pop(); // n - 2

                // We find the sum of this numbers


                stack.push(num1); // we need to push the previous number in the stack (num1)
                stack.push(num1 + num2); // we need to push the sum in the stack (num2)
            }
        }
        System.out.print(stack.peek());
    }
    /*
    With Recursion, we start from up to down and then again from down to up -> performance slow
    With Stack we can start direct from down and to go up
     */
}

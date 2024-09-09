package Stack.Simple_Calculator;

import java.util.ArrayDeque;
import java.util.Collections;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String[] str = scanner.nextLine().split(" ");

        ArrayDeque<String> stack = new ArrayDeque<>();

        Collections.addAll(stack, str); // add all elements and reverse the order
        while (stack.size() > 1)
        {
            int num1 = Integer.parseInt(stack.pop());
            String operator = stack.pop();
            int num2 = Integer.parseInt(stack.pop());

            int sum = 0;
            if(operator.equals("+"))
            {
                sum = num1 + num2;
            }
            else
            {
                sum = num1 - num2;
            }
            stack.push(String.valueOf(sum));
        }
        System.out.println(stack.peek());
    }
}

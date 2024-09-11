package Stack.Simple_Text_Editor;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int operations = Integer.parseInt(scanner.nextLine());

        Deque<String> stack = new ArrayDeque<>();
        stack.push("");

        for (int i = 0; i < operations; i++)
        {
            String[] tokens = scanner.nextLine().split(" ");
            int command = Integer.parseInt(tokens[0]);

            if(command == 1)
            {
                stack.push(stack.peek() + tokens[1]);
            }
            else if(command == 2)
            {
               stack.push(stack.peek().substring(0, stack.peek().length() - Integer.parseInt(tokens[1])));
            }
            else if(command == 3)
            {
               System.out.println(stack.peek().charAt(Integer.parseInt(tokens[1]) - 1));
            }
            else
            {
                if (!stack.isEmpty()) {
                    stack.pop();
                    }
            }
        }
    }
}

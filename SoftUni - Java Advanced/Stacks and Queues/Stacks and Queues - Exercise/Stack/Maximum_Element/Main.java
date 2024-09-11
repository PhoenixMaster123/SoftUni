package Stack.Maximum_Element;

import java.util.*;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int commands = Integer.parseInt(scanner.nextLine());

        Deque<Integer> stack = new ArrayDeque<>();
        for (int i = 0; i < commands; i++)
        {
            int[] tokens = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();


            switch (tokens[0])
            {
                case 1 -> stack.push(tokens[1]);
                case 2 -> stack.pop();
                case 3 -> System.out.println(Collections.max(stack));
            }

        }
    }
}

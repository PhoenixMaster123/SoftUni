package Stack.Browser_History;

import java.util.ArrayDeque;
import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        String link = scanner.nextLine();

        // ArrayDeque has more functions than Stack (it's the same but better)
        ArrayDeque<String> stack = new ArrayDeque<>();

        while (!link.equals("Home"))
        {
            if(link.equals("back"))
            {
                if(stack.size() > 1)
                {
                    stack.pop();
                    System.out.println(stack.peek());
                }
                else
                {
                    System.out.println("no previous URLs");
                }

            }
            else
            {
                stack.push(link);
                System.out.println(link);
            }

            link = scanner.nextLine();
        }
    }
}

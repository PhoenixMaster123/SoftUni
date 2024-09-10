package Queue.Hot_Potato;

import java.util.ArrayDeque;
import java.util.Collections;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String[] players = scanner.nextLine().split(" ");
        int counter = Integer.parseInt(scanner.nextLine());

        ArrayDeque<String> queue = new ArrayDeque<>();

        Collections.addAll(queue, players);
        int rotate = 0;
        while (queue.size() > 1)
        {
            String current = queue.poll();
            rotate++;
            if(rotate % counter == 0)
            {
                System.out.println("Removed " + current);
            }
            else
            {
                queue.offer(current);
            }
        }
        System.out.println("Last is " + queue.peek());
    }
}

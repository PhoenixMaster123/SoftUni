package Queue.Printer_Queue;

import java.util.ArrayDeque;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        // ArrayDeque -> more functions than (Queue)
        ArrayDeque<String> queue = new ArrayDeque<>(); // we can also add capacity

        String str = scanner.nextLine();

        while (!str.equals("print"))
        {
            if(str.equals("cancel"))
            {
                if(queue.isEmpty())
                {
                    System.out.println("Printer is on standby");
                }
                else
                {
                    System.out.println("Canceled " + queue.poll());
                }
            }
            else
            {
                queue.offer(str);
            }
            str = scanner.nextLine();
        }
        for (String fileName : queue)
        {
            System.out.println(fileName);
        }
    }
}

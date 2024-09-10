package Queue.Browser_History_Upgrade;

import java.util.ArrayDeque;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        String link = scanner.nextLine();

        ArrayDeque<String> history = new ArrayDeque<>();
        ArrayDeque<String> forwardPages = new ArrayDeque<>();
        
        while (!link.equals("Home"))
        {
            if(link.equals("back"))
            {
                if(history.size() > 1)
                {
                    forwardPages.push(history.pop());
                    System.out.println(history.peek());
                }
                else
                {
                    System.out.println("no previous URLs");
                }
            }
            else if(link.equals("forward"))
            {
                if(!forwardPages.isEmpty())
                {
                    String current = forwardPages.pop();
                    System.out.println(current);
                    history.push(current);
                }
                else
                {
                    System.out.println("no next URLs");
                }
            }
            else
            {
                history.push(link);
                forwardPages.clear();
                System.out.println(link);
            }

            link = scanner.nextLine();
        }
    }
}

package Queue.Basic_Queue_Operations;

import java.util.*;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int[] commands = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                        .mapToInt(Integer::parseInt).toArray();

        Deque<Integer> queue = new ArrayDeque<>();
        Arrays.stream(numbers).forEach(queue::offer);


                for (int i = 0; i < commands[1]; i++)
                {
                    queue.poll();
                }
                if (queue.isEmpty())
                {
                    System.out.print(0);
                }
                else if(queue.contains(commands[2]))
                {
                    System.out.print(true);
                }
                else
                {
                    System.out.print(Collections.min(queue));
                }
            }
        }
package Queue.Math_Potato;

import java.util.Collections;
import java.util.PriorityQueue;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String[] players = scanner.nextLine().split(" ");
        int n = Integer.parseInt(scanner.nextLine());

        PriorityQueue<String> queue = new PriorityQueue<>();

        Collections.addAll(queue, players);

        int cycle = 1;

        while (queue.size() > 1) {

            /////////////////////////////////// Variant 1 ///////////////////////////////

            // 1. We took the first player from the Queue
            String player = queue.poll();
            // 2. We increase cycle + 1
            cycle++;
            if (isPrime(cycle)) {
                System.out.println("Prime " + player);
                queue.offer(player);
            } else {
                System.out.println("Removed " + player);
            }
            /////////////////////////////////// Variant 2 ///////////////////////////////
           /* for (int i = 1; i < n; i++) {
                queue.offer(queue.poll());
            }
            if (isPrime(cycle)) {
                System.out.println("Prime " + queue.peek());
            } else {
                System.out.println("Removed " + queue.poll());
            }
            cycle++;
            */
        }

        System.out.println("Last is " + queue.poll());
    }

    private static boolean isPrime(int cycle) {
        
        /////////////////////////////////// Variant 1 ///////////////////////////////

         if (number == 1) {
            return false;
        }

        boolean isPrime = true;

        for (int divisor = 2; divisor <= number - 1; divisor++) {
            if (number % divisor == 0) {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
}
    /////////////////////////////////// Variant 2 ///////////////////////////////

       /* if (cycle <= 1) {
            return false;
        } else if (cycle == 2) {
            return true;
        } else if (cycle % 2 == 0) {
            return false;
        }
        for (int i = 3; i <= Math.sqrt(cycle); i += 2) {
            if (cycle % i == 0)
                return false;
        }
        return true;
    }
    */

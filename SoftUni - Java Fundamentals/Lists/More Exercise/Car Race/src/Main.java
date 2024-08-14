import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        /////////////////////////////////// Variant 1 /////////////////////////////
       Scanner scanner = new Scanner(System.in);

       List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .toList();
        double time1 = 0;
        double time2 = 0;

        for (int i = 0; i < numbers.size() / 2; i++) {

            if (numbers.get(i) == 0) {
                time1 *= 0.8;
            }
            time1 += numbers.get(i);
        }
        for (int i = numbers.size() - 1; i > numbers.size() / 2; i--) {

            if (numbers.get(i) == 0) {
                time2 *= 0.8;
            }
            time2 += numbers.get(i);
        }

        if(time1 < time2)
        {
            System.out.printf("The winner is left with total time: %.1f", time1);
        }
        else
        {
            System.out.printf("The winner is right with total time: %.1f", time2);
        }
    }
    /////////////////////////////////// Variant 2 /////////////////////////////

           /* Scanner scanner = new Scanner(System.in);

            List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                    .map(Integer::parseInt)
                    .toList();

            double time1 = 0;
            double time2 = 0;
            int size = numbers.size();

            for (int i = 0; i < size / 2; i++) {
                int left = numbers.get(i);
                int right = numbers.get(size - 1 - i);

                if (left == 0) {
                    time1 *= 0.8;
                }
                time1 += left;

                if (right == 0) {
                    time2 *= 0.8;
                }
                time2 += right;
            }

            if (time1 < time2) {
                System.out.printf("The winner is left with total time: %.1f", time1);
            } else {
                System.out.printf("The winner is right with total time: %.1f", time2);
            }
        }
    }
    */
}
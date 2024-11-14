package _03_Enter_Numbers;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = new ArrayList<>();

        int lastNumber = 1;
        while (numbers.size() != 10) {

            try {
                int currentNumber = Integer.parseInt(scanner.nextLine());
                if (readNumber(currentNumber, lastNumber, 100)) {
                    lastNumber = currentNumber;
                    numbers.add(currentNumber);

                }
            }catch (NumberFormatException e) {
                System.out.println("Invalid Number!");
            }
        }
        String s = numbers.stream().map(String::valueOf).collect(Collectors.joining(", "));
        System.out.println(s);

    }

    private static boolean readNumber(int currentNumber, int start, int end) {
            if (currentNumber > start && currentNumber < end) {
                return true;
            } else {
                System.out.printf("Your number is not in range %d - %d!\n".formatted(start,end));
                return false;
            }
    }
}

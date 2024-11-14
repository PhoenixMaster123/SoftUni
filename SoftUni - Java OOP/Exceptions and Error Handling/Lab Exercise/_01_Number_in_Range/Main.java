package _01_Number_in_Range;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        int end = scanner.nextInt();
        scanner.nextLine();

        System.out.printf("Range: [%d...%d]\n", start, end);

        while (true) {
            String input = scanner.nextLine();
            try {
                int number = Integer.parseInt(input);
                if(number >= start && number <= end) {
                    System.out.printf("Valid number: %d\n", number);
                    break;
                } else {
                    System.out.printf("Invalid number: %d\n", number);
                }
            } catch (NumberFormatException ex) {
                System.out.printf("Invalid number: %s\n", input);
            }
        }
    }
}

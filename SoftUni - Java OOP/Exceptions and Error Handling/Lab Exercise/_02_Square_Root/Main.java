package _02_Square_Root;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        try {
            int num = Integer.parseInt(input);
            if (num < 0) {
                System.out.println("Invalid");
            } else {
                System.out.printf("%.2f\n", Math.sqrt(num));
            }
        } catch (NumberFormatException ex) {
            System.out.println("Invalid");
        } finally {
            System.out.println("Goodbye");
        }
    }
}

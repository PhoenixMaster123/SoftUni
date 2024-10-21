package _01_Rhombus_of_Stars;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        createRhombus(n);
    }

    private static void createRhombus(int n) {
       if(n == 1) {
           System.out.println("*");
           return;
       }

        for (int i = 1; i <= n; i++) {
            printStarsRowOfStars(n, i);
        }
        for (int i = n - 1; i >= 1; i--) {
            printStarsRowOfStars(n, i);
        }
    }
    private static void printStarsRowOfStars(int n, int i) {


        for (int j = 0; j <= n - i; j++) {
            System.out.print(" ");
        }

        for (int row = 1; row <= i; row++) {
            System.out.print("* ");
        }
        System.out.println();
    }
}
package exercise._02_Generic_Box_of_Integer;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            Box<Integer> boxIntegers = new Box<>(Integer.parseInt(scanner.nextLine()));
            System.out.println(boxIntegers);
        }
    }
}

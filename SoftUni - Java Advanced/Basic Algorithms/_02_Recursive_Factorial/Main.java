package _02_Recursive_Factorial;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        System.out.println(fact(n));
        //System.out.println(calcFact(n));
    }

    private static long calcFact(int n) {

        if(n == 1 || n == 0) {
            return 1;
        }

        long result = n * calcFact(n - 1);

        return result;
    }

    private static long fact(int n) {
        if(n == 1 || n == 0) {
            return n;
        }
        return n * fact(n - 1);
    }
}

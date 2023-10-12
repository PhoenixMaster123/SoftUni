// import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int num = Integer.parseInt(sc.nextLine());
        

        for (int i = 0; i <= num; i++) {
            printTriangle(1, i);
        }
        for (int i = num - 1; i >= 1 ; i--) {
            printTriangle(1, i);

        }
    }

    private static void printTriangle(int start, int end) {

        for (int i = start; i <= end; i++) {

            System.out.print(i + " ");

        }
        System.out.println();
    }
}
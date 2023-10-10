import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = Integer.parseInt(sc.nextLine());

        Roboter(num);
    }

    public static void Roboter(int num) {
        if(num == 0)
        {
            System.out.printf("The number %d is zero.", num);
            return;
        }
        if(num % 2 == 0)
        {
          System.out.printf("The number %d is positive.", num);;
        }
        else
        {
            System.out.printf("The number %d is negative.", num);
        }
    }
}
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int intendedHeight = Integer.parseInt(sc.nextLine());

        int unsuccesCounter = 0;
        int jumpsCounter = 0;
        int startJumpHeiht = intendedHeight - 30;

        while (startJumpHeiht <= intendedHeight) {
            int jumpHeight = Integer.parseInt(sc.nextLine());
            jumpsCounter++;

            if (jumpHeight > startJumpHeiht) {
                if (startJumpHeiht >= intendedHeight)
                {
                    System.out.printf("Tihomir succeeded, he jumped over %dcm after %d jumps.", startJumpHeiht, jumpsCounter); //1
                    return;
                }
                startJumpHeiht += 5;
                unsuccesCounter = 0;
            } else {
                unsuccesCounter++;
                if (unsuccesCounter == 3) {
                    System.out.printf("Tihomir failed at %dcm after %d jumps.", startJumpHeiht, jumpsCounter); //1
                    return;
                }

            }
        }
    }

}
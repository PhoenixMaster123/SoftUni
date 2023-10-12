import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String command = sc.nextLine();
        int x = Integer.parseInt(sc.nextLine());
        int y = Integer.parseInt(sc.nextLine());
        System.out.println(Method(command, x, y));
    }

    private static int Method(String command, int x, int y) {

        int result = 0;
        if (command.equals("add")) {
            result = x + y;
        } else if (command.equals("multiply")) {
            result = x * y;
        } else if (command.equals("subtract")) {
            result = x - y;
        } else {
            result = x / y;
        }
        return result;
    }
}
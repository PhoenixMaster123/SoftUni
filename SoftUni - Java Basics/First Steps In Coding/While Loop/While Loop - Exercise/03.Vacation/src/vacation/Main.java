import java.util.Scanner;

public class Vacation {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        double moneyForVacation = Double.parseDouble(sc.nextLine());
        double ownMoney = Double.parseDouble(sc.nextLine());
        int days = 0;
        int spend = 0;

        while (spend != 5) {
            String command = sc.nextLine();
            double money = Double.parseDouble(sc.nextLine());
            days++;

            if (command.equals("save")) {
                ownMoney += money;
                spend = 0;
            } else if (command.equals("spend")) {
                spend++;
                if (money > ownMoney) {
                    ownMoney = 0;
                } else {
                    ownMoney -= money;
                }
            }

            if (ownMoney >= moneyForVacation) {
                System.out.printf("You saved the money for %d days.", days);
                break;
            }
        }

        if (spend == 5) {
            System.out.println("You can't save the money.");
            System.out.println(days);
        }
    }
}

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String command = "";
        int totalStudent = 0;
        int totalStandard = 0;
        int totalKid = 0;
        int totalTicket = 0;

        while (!command.equals("Finish")) {
            command = scanner.nextLine();
            int student = 0;
            int standard = 0;
            int kid = 0;

            if (command.equals("Finish")) {
                break;
            }

            int freePosition = Integer.parseInt(scanner.nextLine());

            for (int i = 0; i < freePosition; i++) {
                String currentPosition = scanner.nextLine();

                if (currentPosition.equals("student")) {
                    student++;
                } else if (currentPosition.equals("standard")) {
                    standard++;
                } else if (currentPosition.equals("kid")) {
                    kid++;
                } else if (currentPosition.equals("End")) {
                    break;
                }
            }

            totalStudent += student;
            totalStandard += standard;
            totalKid += kid;

            System.out.printf("%s - %.2f%% full.\n", command, ((student + standard + kid) / (double)freePosition) * 100);
        }

        totalTicket = totalStudent + totalStandard + totalKid;
        System.out.printf("Total tickets: %d\n", totalTicket);
        System.out.printf("%.2f%% student tickets.\n", ((double) totalStudent / totalTicket) * 100);
        System.out.printf("%.2f%% standard tickets.\n", ((double) totalStandard / totalTicket) * 100);
        System.out.printf("%.2f%% kids tickets.\n", ((double) totalKid / totalTicket) * 100);
    }
}

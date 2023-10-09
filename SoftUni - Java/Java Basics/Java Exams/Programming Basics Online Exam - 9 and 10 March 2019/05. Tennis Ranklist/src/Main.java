import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int tournaments = Integer.parseInt(sc.nextLine());
        int startPoints = Integer.parseInt(sc.nextLine());
        int points = 0;
        double wins = 0;
        for (int i = 0; i < tournaments; i++) {

            String place = sc.nextLine();

            if(place.equals("SF"))
            {
                startPoints += 720;
                points += 720;
            } else if (place.equals("F")) {
                startPoints += 1200;
                points += 1200;
            }
            else
            {
                startPoints += 2000;
                points += 2000;
                wins++;
            }
        }
        System.out.printf("Final points: %d\n", startPoints);
        System.out.printf("Average points: %.0f\n", Math.ceil(points / tournaments));
        System.out.printf("%.2f%%", ((wins / tournaments) * 100));
    }
}
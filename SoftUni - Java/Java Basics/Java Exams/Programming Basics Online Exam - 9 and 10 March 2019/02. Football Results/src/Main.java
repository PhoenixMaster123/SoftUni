import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        //////////////////// Short Version //////////////////////////
        Scanner sc = new Scanner(System.in);

        int wins = 0;
        int losses = 0;
        int draws = 0;

        for (int i = 0; i < 3; i++) {
            String result = sc.nextLine();
            int goalsHome = Integer.parseInt(result.split(":")[0]);
            int goalsAway = Integer.parseInt(result.split(":")[1]);

            if (goalsHome > goalsAway) {
                wins++;
            } else if (goalsHome < goalsAway) {
                losses++;
            } else {
                draws++;
            }
        }

        System.out.printf("Team won %d games.\n", wins);
        System.out.printf("Team lost %d games.\n", losses);
        System.out.printf("Drawn games: %d\n", draws);
        //////////////////// Long Version //////////////////////////
       /* Scanner sc = new Scanner(System.in);

        String firstGame = sc.nextLine();
        String secondGame = sc.nextLine();
        String thirdGame = sc.nextLine();

        int countWins = 0;
        int countLoses = 0;
        int countDraws = 0;
        
        char[] arrGame1 = firstGame.toCharArray();
        char[] arrGame2 = secondGame.toCharArray();
        char[] arrGame3 = thirdGame.toCharArray();

        for (int i = 0; i < arrGame1.length; i++) {

            int goals = Character.getNumericValue(arrGame1[0]);
            int goals2 = Character.getNumericValue(arrGame1[2]);

            if(goals > goals2)
            {
                countWins++;
            }
            else if(goals < goals2)
            {
                countLoses++;
            }
            else
            {
                countDraws++;
            }
            break;
        }
        for (int i = 0; i < arrGame2.length; i++) {

            int goals = Character.getNumericValue(arrGame2[0]);
            int goals2 = Character.getNumericValue(arrGame2[2]);

            if(goals > goals2)
            {
                countWins++;
            }
            else if(goals < goals2)
            {
                countLoses++;
            }
            else
            {
                countDraws++;
            }
            break;
        }
        for (int i = 0; i < arrGame3.length; i++) {

            int goals = Character.getNumericValue(arrGame3[0]);
            int goals2 = Character.getNumericValue(arrGame3[2]);

            if(goals > goals2)
            {
                countWins++;
            }
            else if(goals < goals2)
            {
                countLoses++;
            }
            else
            {
                countDraws++;
            }
            break;
        }

        System.out.printf("Team won %d games.\n", countWins);
        System.out.printf("Team lost %d games.\n", countLoses);
        System.out.printf("Drawn games: %d\n", countDraws);


        */

    }
}
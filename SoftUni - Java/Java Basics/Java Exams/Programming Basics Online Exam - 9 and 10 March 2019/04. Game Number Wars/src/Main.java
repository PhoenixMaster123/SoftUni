import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String name1 = sc.nextLine();
        String name2 = sc.nextLine();

        int pointsName1 = 0;
        int pointsName2 = 0;

        boolean finish = false;
        String command = sc.nextLine();

        while(!command.equals("End of game"))
        {
            int card1 = Integer.parseInt(command);
            int card2 = Integer.parseInt(sc.nextLine());

            if (card1 > card2) {
                pointsName1 += card1 - card2;
            } else if (card1 < card2) {
                pointsName2 += card2 - card1;
            } else {
                finish = true;
                System.out.println("Number wars!");
                int card3 = Integer.parseInt(sc.nextLine());
                int card4 = Integer.parseInt(sc.nextLine());

                if (card3 > card4) {
                    System.out.printf("%s is winner with %d points", name1, pointsName1);
                    break;
                } else {
                    System.out.printf("%s is winner with %d points", name2, pointsName2);
                    break;
                }

            }
            command = sc.nextLine();
        }
            if(finish == false)
            {
                    System.out.printf("%s has %d points\n", name1, pointsName1);
                    System.out.printf("%s has %d points", name2, pointsName2);
            }
    }
}
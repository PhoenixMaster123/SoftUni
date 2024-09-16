package lab._03_Voina_Number_game;

import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Set<Integer> player1Set = new LinkedHashSet<>();
        Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).forEach(player1Set::add);

        Set<Integer> player2Set = new LinkedHashSet<>();
        Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).forEach(player2Set::add);


        int rounds = 50;
        while (rounds > 0 && !player1Set.isEmpty() && !player2Set.isEmpty())
        {
            // Because we don't have get method, that's why we use iterator and is like arrow -> element1, element2
            int firstPlayerCard = player1Set.iterator().next();
            player1Set.remove(firstPlayerCard);

            int secondPlayerCard = player2Set.iterator().next();
            player2Set.remove(secondPlayerCard);

            if(firstPlayerCard > secondPlayerCard) {

                player1Set.add(firstPlayerCard);
                player1Set.add(secondPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
                player2Set.add(firstPlayerCard);
                player2Set.add(secondPlayerCard);
            }
            rounds--;
        }

       // int sumPlayer1Set = player1Set.stream().mapToInt(Integer::intValue).sum();
       // int sumPlayer2Set = player2Set.stream().mapToInt(Integer::intValue).sum();

        if(player1Set.size() > player2Set.size())
        {
            System.out.println("First player win!");
        }
        else if(player1Set.size() < player2Set.size())
        {
            System.out.println("Second player win!");
        }
        else
        {
            System.out.println("Draw!");
        }

    }
}

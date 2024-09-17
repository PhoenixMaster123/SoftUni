package exercise._07_Hands_Of_Cards;

import java.util.*;
import java.util.stream.Collectors;
public class Main {
    final static int C = 1;
    final static int D = 2;
    final static int H = 3;
    final static int S = 4;

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Map<String, Set<String>> points = new LinkedHashMap<>();
        String input = scanner.nextLine();

        while (!input.equals("JOKER")) {
            String[] tokens = input.split(": ");

            String name = tokens[0];
            String deck = tokens[1];
            List<String> cards = Arrays.stream(deck.split(", ")).map(String::valueOf).toList();

            // Variant 1:
           /* Set<String> set = points.getOrDefault(name, new HashSet<>());

            // Add all cards from the deck to the set
             set.addAll(cards);

            // Update the player's card set in the map
            points.put(name, set);

            */
            // Variant 2:
            if (!points.containsKey(name)) {
                // If the player doesn't exist, create a new set
                points.put(name, new HashSet<>());
            }

            // Add cards to the existing set
            points.get(name).addAll(cards);

            input = scanner.nextLine();
        }


        for (Map.Entry<String, Set<String>> entry : points.entrySet()) {
            System.out.println(entry.getKey() + ": " + calculatePoints(entry.getValue()));
        }
    }

    private static int calculatePoints(Set<String> value) {
        int sumPoints = 0;

        for (String currentCard : value) {
            String cardValue = currentCard.substring(0, currentCard.length() - 1);
            char suit = currentCard.charAt(currentCard.length() - 1);

            int number = switch (cardValue) {
                case "J" -> 11;
                case "Q" -> 12;
                case "K" -> 13;
                case "A" -> 14;
                default -> Integer.parseInt(cardValue); // for cards 2-10
            };
            // Handling face cards and Ace

            // Calculate the points based on the suit
            switch (suit) {
                case 'S':
                    sumPoints += number * S;
                    break;
                case 'H':
                    sumPoints += number * H;
                    break;
                case 'D':
                    sumPoints += number * D;
                    break;
                case 'C':
                    sumPoints += number * C;
                    break;
            }
        }
        return sumPoints;
    }
}

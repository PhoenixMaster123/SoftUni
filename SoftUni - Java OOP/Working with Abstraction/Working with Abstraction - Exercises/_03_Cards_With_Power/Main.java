package _03_Cards_With_Power;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String rank = scanner.nextLine().toUpperCase();
        String suit = scanner.nextLine().toUpperCase();

        //int power = findPower(CardRank.valueOf(rank), SuitRank.valueOf(suit));
        //System.out.printf("Card name: %s of %s; Card power: %d", rank, suit, power);

        CardRank cardRank = CardRank.valueOf(rank);
        SuitRank suitRank = SuitRank.valueOf(suit);

        Card card = new Card(cardRank, suitRank);

        System.out.println(card);
    }

    /*private static int findPower(CardRank card, SuitRank suit) {
        return card.getRankPowers() + suit.getSuitPower();
    }
     */
}

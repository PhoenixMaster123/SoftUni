import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        double racket = Double.parseDouble(sc.nextLine());
        int countRackets = Integer.parseInt(sc.nextLine());
        int countShoes = Integer.parseInt(sc.nextLine());

        double priceRackets = racket * countRackets;
        double priceShoes = racket/6;
        double theWholePriceShoes = priceShoes * countShoes;

        double anythingElse = (priceRackets + theWholePriceShoes) * 0.2;

        double total = priceRackets + theWholePriceShoes + anythingElse;

        double djokovichPrice = total / 8;
        double sponsorPrice = total * 7/8;


        System.out.printf("Price to be paid by Djokovic %d\n", (int) Math.floor(djokovichPrice));
        System.out.printf("Price to be paid by sponsors %d", (int) Math.ceil(sponsorPrice));

    }
}
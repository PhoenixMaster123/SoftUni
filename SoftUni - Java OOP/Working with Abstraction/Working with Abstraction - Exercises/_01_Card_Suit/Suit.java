package _01_Card_Suit;
import java.util.Arrays;

public enum Suit {
    CLUBS,
    DIAMONDS,
    HEARTS,
    SPADES;

    public String toString() {
        return String.format("Ordinal value: %d; Name value: %s",
                this.ordinal(),
                this.name());

    }
    public static void printValues() {
        Arrays.stream(Suit.values()).forEach(System.out::println);
    }
}

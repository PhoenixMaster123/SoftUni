package _02_Card_Rank;
import java.util.Arrays;

public enum Rank {
    ACE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN,
    JACK,
    QUEEN,
    KING;

    public String toString() {
        return String.format("Ordinal value: %d; Name value: %s",
                this.ordinal(),
                this.name());

    }
    public static void printValues() {
        Arrays.stream(Rank.values()).forEach(System.out::println);
    }

}

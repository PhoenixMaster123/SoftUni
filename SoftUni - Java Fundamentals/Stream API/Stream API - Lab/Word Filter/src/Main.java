import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<String> words = Arrays.stream(scanner.nextLine().split(" "))
                .map(String::valueOf).toList();

        words.stream().filter(len -> len.length() % 2 == 0).forEach(System.out::println);
    }
}
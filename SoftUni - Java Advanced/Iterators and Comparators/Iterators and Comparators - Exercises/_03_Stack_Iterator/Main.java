package _03_Stack_Iterator;
import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        StackIterator stackIterator = new StackIterator();
        String line = scanner.nextLine();

        while (!"END".equals(line)) {
            String[] tokens = line.split("[\\s,]+");
            String command = tokens[0];

            switch (command) {
                case "Push":
                    Arrays.stream(tokens).skip(1).map(Integer::parseInt).forEach(stackIterator::push);
                    break;
                case "Pop":
                    try {
                        stackIterator.pop();
                    }
                    catch (IllegalStateException e) {
                        System.out.println(e.getMessage());
                    }
                    break;
            }

            line = scanner.nextLine();
        }
        stackIterator.forEach(System.out::println);
        stackIterator.forEach(System.out::println);
    }
}

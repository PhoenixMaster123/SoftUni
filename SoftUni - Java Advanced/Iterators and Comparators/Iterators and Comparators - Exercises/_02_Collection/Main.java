package _02_Collection;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

       ListyIterator<String> listyIterator = new ListyIterator<>();

        String line = scanner.nextLine();

        while (!"END".equals(line)) {
            String[] tokens = line.split(" ");
            String command = tokens[0];

            switch (command) {
                case "Create":
                    String[] elements = Arrays.stream(tokens).skip(1).toArray(String[]::new); // we skip the first element (The elements of the elements that we want to skipped)
                    listyIterator = new ListyIterator<>(elements);
                    break;
                case "Move":
                    System.out.println(listyIterator.move());
                    break;
                case "HasNext":
                    System.out.println(listyIterator.hasNext());
                    break;
                case "Print":
                    try {
                        listyIterator.print();
                    } catch (IllegalStateException e) {
                        System.out.println(e.getMessage());
                    }
                    break;
                case "PrintAll":
                    listyIterator.forEach(name -> System.out.print(name + " "));
                    System.out.println();
                    break;
            }

            line = scanner.nextLine();
        }
    }
}

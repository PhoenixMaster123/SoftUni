import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine()
        .split(" ")).map(Integer::parseInt).collect(Collectors.toList());


        String command;
        while (!(command = scanner.nextLine()).equals("End"))
        {
            String[] token = command.split(" ");
            String commandArg = token[0];

            if (commandArg.equals("Add")) {
                int addNumber = Integer.parseInt(token[1]);
                numbers.add(addNumber);
            } else if (commandArg.equals("Insert")) {
                int insertNumber = Integer.parseInt(token[1]);
                int insertIndex = Integer.parseInt(token[2]);

                if (insertIndex < 0 || insertIndex >= numbers.size()) // There are equal
                {
                    System.out.println("Invalid index");
                    continue;
                }

                numbers.add(insertIndex, insertNumber);
            } else if (commandArg.equals("Remove")) {
                int deleteNumber = Integer.parseInt(token[1]);
                if (deleteNumber < 0 || deleteNumber >= numbers.size()) // There are equal
                {
                    System.out.println("Invalid index");
                    continue;
                }
                numbers.remove(deleteNumber);
            } else if (commandArg.equals("Shift")) {
                String direction = token[1];
                int count = Integer.parseInt(token[2]);
                if (direction.equals("left")) {
                    shiftLeft(numbers, count);
                } else if (direction.equals("right")) {
                    shiftRight(numbers, count);
                }
            }
        }

        System.out.println(String.join(" ", numbers.stream().map(Object::toString).toArray(String[]::new)));
    }
    static void shiftLeft(List<Integer> numbers, int count) {
        int realPerformanceCount = count % numbers.size();

        for (int i = 1; i <= realPerformanceCount; i++) {
            int firstElement = numbers.get(0);
            numbers.remove(0);
            numbers.add(firstElement);
        }
    }

    static void shiftRight(List<Integer> numbers, int count) {
        int realPerformanceCount = count % numbers.size();

        for (int i = 1; i <= realPerformanceCount; i++) {
            int lastElement = numbers.get(numbers.size() - 1);
            numbers.remove(numbers.size() - 1);
            numbers.add(0, lastElement);
        }
    }
}

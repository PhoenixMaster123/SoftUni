package exercise._07_Custom_List;

import java.util.Scanner;

public class Main {
    private static<T extends Comparable<T>> void interpretCommand(String input, CustomList<T> customList) {
        String[] tokens = input.split(" ");

        String command = tokens[0];

        switch (command) {
            case "Add":
                customList.add((T) tokens[1]);
                break;
            case "Remove":
                customList.remove(Integer.parseInt(tokens[1]));
                break;
            case "Contains":
                System.out.println(customList.contains((T) tokens[1]));
                break;
            case "Swap":
                customList.swap(Integer.parseInt(tokens[1]), Integer.parseInt(tokens[2]));
                break;
            case "Greater":
                System.out.println(customList.countGreaterThat((T) tokens[1]));
                break;
            case "Max":
                System.out.println(customList.getMax());
                break;
            case "Min":
                System.out.println(customList.getMin());
                break;
            case "Print":
                customList.forEach(System.out::println);
                break;



        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
        CustomList<String> customList = new CustomList<>();
        while (!"END".equals(line)) {

            CommandInterpreter.interpretCommand(line, customList);

            line = scanner.nextLine();
        }
    }
}

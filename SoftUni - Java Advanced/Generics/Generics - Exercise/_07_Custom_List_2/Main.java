package exercise._07_Custom_List_2;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //CommandInterpreter<String> interpreter = new CommandInterpreter<>();

        CustomList<String> customList = new CustomList<>();

        String input = scanner.nextLine();
        while (!input.equals("END")) {

            String command = input.split("\\s+")[0];
            switch (command) {
                case "Add":
                    String elementToAdd = input.split("\\s+")[1];
                    customList.add(elementToAdd);
                    break;
                case "Remove":
                    int index = Integer.parseInt(input.split("\\s+")[1]);
                    customList.remove(index);
                    break;
                case "Contains":
                    String elementToCheck = input.split("\\s+")[1];
                    System.out.println(customList.contains(elementToCheck));
                    break;
                case "Swap":
                    int index1 = Integer.parseInt(input.split("\\s+")[1]);
                    int index2 = Integer.parseInt(input.split("\\s+")[2]);
                    customList.swap(index1, index2);
                    break;
                case "Greater":
                    String elementToCompareWith = input.split("\\s+")[1];
                    System.out.println(customList.countGreaterThan(elementToCompareWith));
                    break;
                case "Max":
                    System.out.println(customList.getMax());
                    break;
                case "Min":
                    System.out.println(customList.getMin());
                    break;
                case "Print":
                    customList.print();
                    break;
            }

            input = scanner.nextLine();
        }
    }
}

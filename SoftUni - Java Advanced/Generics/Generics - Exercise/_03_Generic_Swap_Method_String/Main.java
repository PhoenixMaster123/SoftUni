package exercise._03_Generic_Swap_Method_String;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        List<Box<String>> boxList = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            Box<String> boxStrings = new Box<>(scanner.nextLine());
           boxList.add(boxStrings);
        }
        String[] tokens = scanner.nextLine().split(" ");
        swap(boxList, Integer.parseInt(tokens[0]), Integer.parseInt(tokens[1]));

        boxList.forEach(System.out::println);
    }
    public static <T> void swap(List<T> data, int firstIndex, int secondIndex) {
        T firstElement = data.get(firstIndex);
        T secondElement = data.get(secondIndex);

        data.set(firstIndex, secondElement);
        data.set(secondIndex, firstElement);
    }

}

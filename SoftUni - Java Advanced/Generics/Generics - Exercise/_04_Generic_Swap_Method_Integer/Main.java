package exercise._04_Generic_Swap_Method_Integer;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        List<Box<Integer>> integerList = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            Box<Integer> ele = new Box<>(Integer.parseInt(scanner.nextLine()));
            integerList.add(ele);
        }
        String[] swapIndex = scanner.nextLine().split(" ");

        swap(integerList, Integer.parseInt(swapIndex[0]), Integer.parseInt(swapIndex[1]));

        integerList.forEach(System.out::println);
    }

    private static<T> void swap(List<T> integerList, int firstElement, int secondElement) {
        T first = integerList.get(firstElement);
        T second = integerList.get(secondElement);

        integerList.set(secondElement, first);
        integerList.set(firstElement, second);
    }
}

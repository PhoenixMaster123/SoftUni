package exercise._05_Generic_Count_Method_String;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        List<String> stringList = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            stringList.add(scanner.nextLine());
        }
        String element = scanner.nextLine();
        System.out.println(countGreaterElements(stringList, element));
    }
    private static <T extends Comparable<T>> int countGreaterElements(List<T> data, T element) {
        int count = 0;

        for (T e : data) {
            int res = e.compareTo(element);
            if(res > 0) {
                count++;
            }
        }
        return count;

    }
}

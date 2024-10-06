package exercise._06_Generic_Count_Method_Doubles;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int n = Integer.parseInt(scanner.nextLine());
        List<Double> doubleList = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            doubleList.add(Double.parseDouble(scanner.nextLine()));
        }
        double element = Double.parseDouble(scanner.nextLine());

        System.out.println(countGreaterElements(doubleList, element));
    }

    private static<T extends Comparable<T>> int countGreaterElements(List<T> doubleList, T element) {
        int counter = 0;

        for (T ele : doubleList) {
            if(ele.compareTo(element) >= 1) {
                counter++;
            }
        }
        return counter;
    }
}

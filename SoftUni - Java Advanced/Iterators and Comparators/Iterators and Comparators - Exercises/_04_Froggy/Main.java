package _04_Froggy;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Read input
        String line = scanner.nextLine();
        Integer[] tokens = Arrays.stream(line.split(", "))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        Lake lake = new Lake(tokens);

        // Print the Frog's jumps in the correct order
        String result = "";
        for (int number : lake) {
            result += number + ", ";
        }
        // Remove the trailing comma and space
        if (!result.isEmpty()) {
            result = result.substring(0, result.length() - 2);
        }

        System.out.println(result);
    }
}

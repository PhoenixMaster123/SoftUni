package exercise._01_Consumer_Print;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Consumer;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
       // List<String> names = Arrays.stream(scanner.nextLine().split(" ")).map(String::valueOf).toList();

        Consumer<String> printNames = System.out::println;
        Arrays.stream(scanner.nextLine().split(" ")).forEach(printNames);
        //names.stream().map(String::valueOf).forEach(printNames);
        //names.forEach(System.out::println);
    }
}

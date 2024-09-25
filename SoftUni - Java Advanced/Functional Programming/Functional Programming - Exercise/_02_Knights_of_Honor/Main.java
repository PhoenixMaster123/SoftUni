package exercise._02_Knights_of_Honor;

import java.util.Arrays;
import java.util.Scanner;
import java.util.function.Consumer;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        Consumer<String> printWithHonor = name -> System.out.println("Sir " + name);

        Arrays.stream(scanner.nextLine().split(" ")).forEach(printWithHonor);
    }
}

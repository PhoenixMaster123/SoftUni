package exercise._04_Applied_Arithmetic;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Consumer;
import java.util.function.Function;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine()
                .split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        Function<List<Integer>, List<Integer>> addFunc = listNumbers ->
                listNumbers.stream().map(number -> number + 1).toList();

        Function<List<Integer>, List<Integer>> subtractFunc = listNumbers ->
                listNumbers.stream().map(number -> number - 1).toList();

        Function<List<Integer>, List<Integer>> multiplyFunc = listNumbers ->
                listNumbers.stream().map(number -> number * 2).toList();

        Consumer<List<Integer>> printNumbers =
                listNumbers -> listNumbers.forEach(num -> System.out.print(num + " "));

        String command = scanner.nextLine();

        while (!command.equals("end"))
        {
            switch (command)
            {
                case "add" -> numbers = addFunc.apply(numbers);
                case "subtract" -> numbers = subtractFunc.apply(numbers);
                case "multiply" -> numbers = multiplyFunc.apply(numbers);
                case "print" -> {
                    printNumbers.accept(numbers);
                    System.out.println();
                }
            }
            command = scanner.nextLine();
        }
    }
}

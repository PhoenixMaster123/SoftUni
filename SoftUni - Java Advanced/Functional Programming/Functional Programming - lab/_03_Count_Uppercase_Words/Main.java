package lab._03_Count_Uppercase_Words;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String str = scanner.nextLine();

        // Variant 1:
        /*List<String> words = Arrays.stream(str.split(" "))
                .filter(word -> Character.isUpperCase(word.charAt(0)))
                .toList();
        System.out.println(words.size());
        words.forEach(System.out::println);
         */

        // Variant 2:
        Predicate<String> startWithUpperCase = word -> Character.isUpperCase(word.charAt(0)); //<=> Function<String, Boolean>
        List<String> words = Arrays.stream(str.split(" ")).filter(startWithUpperCase).toList();
        System.out.println(words.size());
        words.forEach(System.out::println);

        // List<String> words = Arrays.stream(str.split(" ")).collect(Collectors.toList()); // -> Variant 3 & 4
       // List<String> wordsToUpper = new ArrayList<>(); // -> Variant 3

        // Variant 3:
        /*Predicate<String> isUpperCase = word -> Character.isUpperCase(word.charAt(0)); <=> Function<String, Boolean>

        int counter = 0;
        for (String word : words)
        {
            if(isUpperCase.test(word))
            {
                wordsToUpper.add(word);
                counter++;
            }
        }
        System.out.println(counter);
        wordsToUpper.forEach(System.out::println);
         */

        // Variant 4:
        /*words.removeIf(word -> !Character.isUpperCase(word.charAt(0)));
        System.out.println(words.size());
        words.forEach(System.out::println);
         */

    }
}

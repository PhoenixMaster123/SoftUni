package lab.BiFunction_Demo;

import java.util.function.BiConsumer;
import java.util.function.BiFunction;
import java.util.function.BiPredicate;

public class Main
{
    public static void main(String[] args) {

        // BiFunction -> take two parameters and return something -> apply
        // BiFunction<argument, argument, return>

        //Example:

        BiFunction<Integer, Integer, String> sum = (x, y) -> "Sum is: " + (x + y);

        BiFunction<String, String, String> greeting = (firstName, secondName) -> "Hi, my name is " + firstName + " " + secondName;
        System.out.println(greeting.apply("Kristian", "Popov"));

        // BiConsumer -> take two arguments but don't return anything -> accept

        BiConsumer<String, String> printGreeting = (firstName, secondName)
                -> System.out.printf("Hi, my name is %s %s\n", firstName, secondName);
        printGreeting.accept("Kristian", "Popov");

        //BiPredicate -> take two arguments and return true or false -> test

        BiPredicate<String, String> sameLength = (firstText, secondText) -> firstText.length() == secondText.length();
        System.out.println(sameLength.test("Kris", "Alex"));


    }
}

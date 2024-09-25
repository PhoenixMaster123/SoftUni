package lab.Predicate_Demo;

import java.util.function.Predicate;

public class Main
{
    public static void main(String[] args) {

        // Predicate evaluates a condition:

        // We use Predicate with .test()

        // Predicate: get(receive) an argument and return boolean result (true or false)
        Predicate<Integer> isEven = number -> number % 2 == 0;
        System.out.println(isEven.test(6));
    }
}

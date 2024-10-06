package exercise.Demo;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        List<Integer> numbers = new ArrayList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);

        multiplyByTwo(numbers);
       // print(numbers);

    }
    // only the child for Numbers can be used → Lower Bound (Integer → child Number)
    private static<T extends Number> void multiplyByTwo(List<? extends Number> numbers) {
        numbers.forEach(n -> System.out.println((int) n * 2));

    }
    // only the parents of the Numbers
   public static void print(List<? super Number> numbers) {
       numbers.forEach(System.out::println);

   }
    //<? extends T> → need to be a child to T (it will with all children) (short, long, double)

    // List<?> -> without boundaries

    // Number (parent) -> Integer (child)
    // Number (parent) -> Double  (child)

    // List<?> =>  List<? extends Object>, works with everything (without boundaries)
    public static void print2(List<?> list) { //

    }

}

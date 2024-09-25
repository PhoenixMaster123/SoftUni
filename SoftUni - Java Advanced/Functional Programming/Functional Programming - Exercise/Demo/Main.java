package exercise.Demo;

import java.util.Arrays;
import java.util.Scanner;
import java.util.function.*;

public class Main
{
    public static void main(String[] args) {

        // Function<InputParam, ReturnType> -> use with apply

        Function<Integer, Integer> powerOfTwoFunc = x -> x * x;
        Integer result = powerOfTwoFunc.apply(5);
        System.out.println(result);

        // if the function need more, then one operation, we open { logic }
        Function<Integer, Integer> power = x ->
        {
            if(x % 2 == 0)
            {
                return 2;
            }
            return 0;
        };

        // Consumer<InputParam> -> void -> use with accept

        Consumer<Integer> printNumber = y -> System.out.println(y); // <=> System.out::println();
        printNumber.accept(100);

        // Supplier<ReturnType> -> no parameters -> use with get

        Supplier<Scanner> getScannerSupplier = () -> new Scanner(System.in); // anonym function
        Scanner scanner = getScannerSupplier.get();

        // Predicate<InputParam> -> return treu / false -> use with test

        Predicate<Integer> isEven = num -> num % 2 == 0;
        boolean s = isEven.test(2);

        //BiFunction<InputParam1, InputParam2, ReturnType> -> use with apply

        // BiFunction we use when we use Map (usually)

        BiFunction<Integer, Integer, Long> multiplyBiFunc = (a, b) -> Long.valueOf(a * b);
        multiplyBiFunc.apply(5, 6);

        // Custom Function
        Calculator calculator = (a,b,c) ->
        {
            Integer[] result2 = new Integer[2];

            return result2;
        };

        Arrays.stream(getScannerSupplier.get().nextLine().split(" "))
                .map(Integer::parseInt)
                .map(powerOfTwoFunc)
                .filter(isEven)
                .forEach(printNumber);
    }
    @FunctionalInterface // Like that we can create our Function
    interface Calculator // {} hardcore
    {
        Integer[] calculate(int a, int b, int c);
    }
}

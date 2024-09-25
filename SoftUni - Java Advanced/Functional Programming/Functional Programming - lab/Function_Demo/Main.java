package lab.Function_Demo;

import java.util.List;
import java.util.function.Function;

public class Main
{
    public static void main(String[] args) {

        // -> lambda expression
        // :: reference expression (not lambda)

        // Function is lambda expression: take an argument and return one result
        // Integer: argument | Integer: action
        // Function<get, return> | .apply()
        Function<Integer, Integer> func = x -> x * x; // create function

        Integer result = func.apply(5);

        // Note: Method can be replaced with function

        // another example:

        List<Integer> listNumbers = List.of(5,6,7,8,9);
        Function<List<Integer>, Integer> sumNumbers = list ->
        {
            int sum = 0;
            for (Integer num : list)
            {
                sum += num;
            }
            return sum;
        };
        System.out.println(sumNumbers.apply(listNumbers));


    }
}

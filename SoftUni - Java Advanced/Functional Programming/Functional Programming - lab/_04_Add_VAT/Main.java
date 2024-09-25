package lab._04_Add_VAT;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Consumer;
import java.util.function.Function;
import java.util.function.UnaryOperator;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        List<Double> numbers = Arrays.stream(scanner.nextLine().split(", "))
                .map(Double::parseDouble).collect(Collectors.toList());

        // Variant 1 with Function  (My first approach) :

        /*Function<List<Double>, List<Double>> funcWithVAT = vat ->
        {
            List<Double> afterVat = new ArrayList<>();

            for (Double num : numbers)
            {
                afterVat.add(num * 1.2);
            }
            return afterVat;
        };
        System.out.println("Prices with VAT:");
        funcWithVAT.apply(numbers).forEach(n -> System.out.printf("%.2f\n", n));
         */

        // Variant 2 (Second approach):

        Function<Double, Double> funcVAT = price -> price * 1.2;

        System.out.println("Prices with VAT:");
        /*for (Double num : numbers) // long version
        {
            double priceWithVat = funcVAT.apply(num);
            System.out.printf("%.2f\n", priceWithVat);
        }
         */
        // Variant 1: (combined without splitting)
        numbers.forEach(price -> System.out.printf("%.2f\n", funcVAT.apply(price))); // short version

        // Variant 2 (version direct with forEach):
        //Consumer<Double> printPrice = price -> System.out.printf("%.2f\n", price);
        //numbers.forEach(price -> printPrice.accept(price));

        // Variant 3 (version with map):
        Consumer<Double> printPrice = price -> System.out.printf("%.2f\n", price);
        numbers.stream().map(funcVAT).forEach(printPrice);

        // Variant 3:

        // Represents an operation on a single operand
        // that produces a result of the same type as its operand.
        // This is a specialization of Function for the case where the operand and
        // result are of the same type.
        // This is a functional interface whose functional method is apply(Object).
        UnaryOperator<Double> addVat = value -> value * 1.2;

        for (Double price : numbers)
        {
            double priceWithVat = addVat.apply(price);
        }

    }
}

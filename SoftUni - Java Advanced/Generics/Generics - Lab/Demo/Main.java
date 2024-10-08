package Demo;

import java.util.List;

public class Main {
    public static void main(String[] args) {

        // 1. Type safety → that means the Generic that I type need to be there

        // Example ArrayList<String> list = new ArrayList<>()
        // I cannot add 1, for example

        // 2. Code reuse:

        // I can use one method for every type of data
        // Wildcard ⇒ unknown type

    }
    // ? ⇒ whatever type of data (WildCard)
    public static void print(List<?> list) { // We are going to thread them like an objects

        for (Object object : list) {
            System.out.println(object);
        }
    }

    // We cannot use in the classes, because is possible to mix the type
    // Examples one class to be with String another with Integer, etc.

    // We can give boundaries:

    // ? extends Number → whatever type, but the type needs to extend(наследник) this class Number (Integer, Double, Short ...)
    // ? extends Number → Upper Bound
    // ? super Number -> whatever type, but the type needs to be super(father class) to this class Number (Integer, Double, Short ...)
    public static void print2(List<? extends Number> list) { // We are going to thread them like an objects

        for (Object object : list) {
            System.out.println(object);
        }
    }
    public static void print3(List<? super Number> list) { // We are going to thread them like an objects

        for (Object object : list) {
            System.out.println(object);
        }
    }

}

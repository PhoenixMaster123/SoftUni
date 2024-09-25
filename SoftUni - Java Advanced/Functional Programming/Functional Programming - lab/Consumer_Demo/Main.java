package lab.Consumer_Demo;

import java.util.function.Consumer;

public class Main
{
    public static void main(String[] args) {
        // Consumer<T> -> void lambda function | .accept

        // We put only the type of the argument | action (void)
        // We have Lambda expression that gets one argument but don't return anything

        // Example:
        Consumer<String> print = message -> System.out.print(message);

        print.accept("Peter"); // We use Consumer with .accept
    }
}

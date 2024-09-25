package lab.Supplier_Demo;

import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.Random;
import java.util.function.Supplier;

public class Main
{
    public static void main(String[] args) {

        // Supplier takes no argument => ()

        // We use Supplier with => .get();

        // Supplier: Don't take arguments but return result

        // Example:

        Supplier<Integer> genRandomInt = () -> new Random().nextInt(51);
        int rnd = genRandomInt.get();
        System.out.println(rnd);

        Supplier<LocalDateTime> getTimeNow = () -> LocalDateTime.now();
        System.out.println(getTimeNow.get());
    }
}

package DemoExercise_Polymorphism.dynamicPolymorphism;

import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        Payable payable = getPayable(line);

    }
    private static Payable getPayable(String payment) {
        Map<String, Payable> payableMap = Map.of("CreditCard", new CreditCardPayment(),
                "RevolutPayment", new Revolut(),
                "PayPal", new PayPalPayment());
        return payableMap.get(payment);
    }
    private static void pay(Payable payable, int amount) {
        payable.pay(amount);
    }
}

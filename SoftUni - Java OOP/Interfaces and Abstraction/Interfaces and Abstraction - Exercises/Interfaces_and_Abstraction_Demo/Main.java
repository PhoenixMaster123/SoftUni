package Interfaces_and_Abstraction_Demo;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // API → Application Programming Interface

        Scanner scanner = new Scanner(System.in);

        String paymentOption = scanner.nextLine();
        String user = scanner.nextLine();
        int price = Integer.parseInt(scanner.nextLine());

        Payable creditCardPayment = new CreditCardPayment(user);
        Payable revolut = new Revolut(user);
        Payable payPalPayment = new PayPalPayment(user);

        Map<String, Payable> payableMap =
                Map.of("CreditCard", creditCardPayment,
                "Revolut", revolut,
                        "PayPal", payPalPayment);

        Payment payment = new CreditCardPayment(user);
        payment.report();

        System.out.println(Payable.calculateVat(100));
    }
}

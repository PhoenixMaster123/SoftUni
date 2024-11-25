package Structural_Pattern.Facade_Pattern;

// Facade design pattern
public class PaymentProcess {

    // When we need to following steps and the user don't know the order
    public static void processPayment() {
        CardPayment cardPayment = new CardPayment();
        cardPayment.getCard();

        CardValidator cardValidator = new CardValidator();
        cardValidator.validateCard();

        cardPayment.payWithCard();

        BalanceReducer balanceReducer = new BalanceReducer();
        balanceReducer.reduceBalance();

        NotificationSender notificationSender = new NotificationSender();
        notificationSender.sendNotification();
    }
}

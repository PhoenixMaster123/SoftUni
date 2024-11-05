package DemoExercise_Polymorphism.dynamicPolymorphism;

public class CreditCardPayment extends Payment implements Payable {
    @Override
    public void report() {

    }

    @Override
    public void pay(int price) {
        System.out.println("Sum " + price + " is payed by card");
    }
}

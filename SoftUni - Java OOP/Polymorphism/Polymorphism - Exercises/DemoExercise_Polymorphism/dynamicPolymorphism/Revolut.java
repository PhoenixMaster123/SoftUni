package DemoExercise_Polymorphism.dynamicPolymorphism;

public class Revolut extends Payment implements Payable {

    @Override
    public void report() {

    }

    @Override
    public void pay(int price) {
        System.out.println("Sum " + price + " is payed by Revolut");
    }
}

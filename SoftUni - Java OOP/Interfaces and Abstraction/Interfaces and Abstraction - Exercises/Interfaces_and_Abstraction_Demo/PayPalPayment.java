package Interfaces_and_Abstraction_Demo;

public class PayPalPayment extends Payment implements Payable{
    public PayPalPayment(String username) {
        super(username);
    }

    @Override
    public void report() {

    }

    @Override
    public void pay(int price) {
        System.out.println("Sum " + price + " is payed by PayPal");
    }
}

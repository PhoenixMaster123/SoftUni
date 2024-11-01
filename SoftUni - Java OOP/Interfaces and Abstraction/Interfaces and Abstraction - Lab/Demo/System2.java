package Demo;

// When one class wants to implement interface, the class need to implement all defined methods from the interface.
public class System2 implements Payable, Discountable{
    @Override
    public boolean payWithCard(int productCost, double cardBalance) {

        if(productCost > cardBalance) {
            return false;
        } else {
            return true;
        }
    }

    @Override
    public void payWithCash() {

    }

    @Override
    public String generateDiscountCode() {
        return null;
    }
}

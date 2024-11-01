package Demo;
import java.lang.System;

// Interface → set of methods without implementation, which our classes can do later.
// We also can define functions
// Definition:
// Implementation:
public interface Payable extends Cashable{
    int BANK_ACCOUNT = 5;
    boolean payWithCard(int productCost, double cardBalance);

    default void done() {
        System.out.println();
    }
}

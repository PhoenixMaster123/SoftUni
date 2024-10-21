package _04_Hotel_Reservation;

import java.util.PrimitiveIterator;

public enum Discount {
    NONE(0),
    SECONDVISIT(0.10),
    VIP(0.20);

    private double percentage;

    Discount(double percentage) {
        this.percentage = percentage;
    }

    public double getPercentage() {
        return percentage;
    }
}

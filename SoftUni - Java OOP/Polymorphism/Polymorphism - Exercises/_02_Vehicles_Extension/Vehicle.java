package _02_Vehicles_Extension;

public interface Vehicle {
    String drive(double distance);
    void refuel(double liters);

    default void setEmpty(boolean b) {

    }
}

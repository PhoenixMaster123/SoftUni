package _02_Vehicles_Extension;

public class Car extends VehicleImpl {

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) {
        super(fuelQuantity, fuelConsumption + 0.9, tankCapacity);
    }

    @Override
    public void refuel(double liters) {
        super.refuel(liters);
    }
}

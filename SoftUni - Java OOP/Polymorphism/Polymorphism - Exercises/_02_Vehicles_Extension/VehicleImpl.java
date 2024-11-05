package _02_Vehicles_Extension;

import java.text.DecimalFormat;

public abstract class VehicleImpl implements Vehicle {
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    public VehicleImpl(double fuelQuantity, double fuelConsumption, double tankCapacity) {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
        this.tankCapacity = tankCapacity;
    }

    @Override
    public String drive(double distance) {
        DecimalFormat decimalFormat = new DecimalFormat("#.##");
        String result = "%s needs refueling".formatted(this.getClass().getSimpleName());

        double neededFuel = this.fuelConsumption * distance;
        if(this.fuelQuantity >= neededFuel) {
            result = "%s travelled %s km".formatted(this.getClass().getSimpleName(), decimalFormat.format(distance));
            this.fuelQuantity -= neededFuel;
        }
        return result;
    }
    @Override
    public void refuel(double liters) {
        if(liters <= 0) {
            throw new IllegalArgumentException("Fuel must be a positive number");
        }
        if(this.fuelQuantity + liters > this.tankCapacity) {
            throw new IllegalArgumentException("Cannot fit fuel in tank");
        }
        this.fuelQuantity += liters;
    }

    public String toString() {
        return "%s: %.2f".formatted(this.getClass().getSimpleName(), this.fuelQuantity);
    }

    public double getFuelConsumption() {
        return fuelConsumption;
    }

    public void setFuelConsumption(double fuelConsumption) {
        this.fuelConsumption = fuelConsumption;
    }
}

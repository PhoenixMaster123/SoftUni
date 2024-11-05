package _01_Vehicles;

import java.text.DecimalFormat;

public abstract class VehicleImpl implements Vehicle {
    private double fuelQuantity;
    private double fuelConsumption;

    public VehicleImpl(double fuelQuantity, double fuelConsumption) {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
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
        this.fuelQuantity += liters;
    }

    public String toString() {
        return "%s: %.2f".formatted(this.getClass().getSimpleName(), this.fuelQuantity);
    }
}

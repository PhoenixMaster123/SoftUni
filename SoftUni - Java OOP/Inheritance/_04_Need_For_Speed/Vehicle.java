package _04_Need_For_Speed;

public abstract class Vehicle {
    private final static double DEFAULT_FUEL_CONSUMPTION = 1.25;
    private double fuelConsumption;
    private double fuel;
    private int horsePower;

    public Vehicle(double fuel, int horsePower) {
        setFuel(fuel);
        setHorsePower(horsePower);
        setFuelConsumption(DEFAULT_FUEL_CONSUMPTION);
    }

    public double getFuel() {
        return fuel;
    }

    private void setFuel(double fuel) {
        this.fuel = fuel;
    }

    public int getHorsePower() {
        return horsePower;
    }

    private void setHorsePower(int horsePower) {
        this.horsePower = horsePower;
    }

    public double getFuelConsumption() {
        return fuelConsumption;
    }

    public void setFuelConsumption(double fuelConsumption) {
        this.fuelConsumption = fuelConsumption;
    }

    public void drive(double kilometers) {
        double neededFuel = this.fuelConsumption * kilometers;

        double remainingFuel = this.fuel - neededFuel;

        if (remainingFuel >= 0) {
            this.setFuel(remainingFuel);
        }
    }

}

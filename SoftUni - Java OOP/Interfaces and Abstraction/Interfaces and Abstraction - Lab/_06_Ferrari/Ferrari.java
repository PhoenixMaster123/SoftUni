package _06_Ferrari;

public class Ferrari implements Car {
    private String driverName;
    private final String model;
    public Ferrari(String driverName) {
        this.setDriverName(driverName);
        model = "488-Spider";
    }
    public String toString() {
        return String.format("%s/%s/%s/%s", this.model, brakes(), gas(), this.driverName);
    }
    @Override
    public String brakes() {
        return "Brakes!";
    }

    @Override
    public String gas() {
        return "brum-brum-brum-brrrrr";
    }

    public String getDriverName() {
        return driverName;
    }
    public void setDriverName(String driverName) {
        this.driverName = driverName;
    }
}

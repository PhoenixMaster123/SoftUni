package exercise._05_Car_Salesman;

public class Engine {
    private String model;
    private int power;
    private String displacement;
    private String efficiency;

    public Engine(String model, int power, String displacement, String efficiency) {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    public String getModel() {
        return model;
    }

    public int getPower() {
        return power;
    }

    public String getDisplacement() {
        return displacement;
    }

    public String getEfficiency() {
        return efficiency;
    }

    @Override
    public String toString() {
        return model + ":\n" +
                "Power: " + power + "\n" +
                "Displacement: " + displacement + "\n" +
                "Efficiency: " + efficiency;
    }
}

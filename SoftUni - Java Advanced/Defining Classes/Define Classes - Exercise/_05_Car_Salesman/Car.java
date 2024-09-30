package exercise._05_Car_Salesman;

public class Car {
    private String model;
    private Engine engine; // Reference to an Engine object
    private String weight;
    private String color;

    public Car(String model, Engine engine, String weight, String color) {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    public Car(String model, Engine engine) {
        this(model, engine, "n/a", "n/a");
    }

    public Car(String model, Engine engine, String weight) {
        this(model, engine, weight, "n/a");
    }

    @Override
    public String toString() {
        return model + ":\n" +
                engine + "\n" + // Calls the Engine's toString method
                "Weight: " + weight + "\n" +
                "Color: " + color;
    }
}

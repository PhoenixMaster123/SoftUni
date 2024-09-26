package lab.Demo;

public class Car_Demo { // PascalCase
    // Class is made of state (characteristics) and behavior (methods)

    // Fields store states:

    // access modifier | type data | name

    // public → can be accessible everywhere
    // private → only in our class
    // default →
    private String brand;
    public String model;
    public int horsePower;

    // Methods describe behavior
    void start() {
        System.out.println("Car is moving");
    }

    // we don't have a constructor with parameters our class generate default constructor
    public Car_Demo(String brand, String model, int horsePower) {
       // without arguments:
        this.brand = brand;  // null
        this.model = model; // null
        this.horsePower = horsePower; // 0
    }
    public Car_Demo()
    {

    }

    // Getter → give access to brand field
    public String getBrand() {
        return this.brand; // Prevent field hiding | Refers to a current object
    }

    // Setter → give access to change brand field
    public void setBrand(String brand) {

        // this → access to this object, that called this method
        this.brand = brand; // this (in our class)
    }
    public static void beep() {
        System.out.println("Beep");
    }
}

package exercise._04_Raw_Data;

public class Tire {
    private double[] tirePressure = new double[4];
    private int[] tireAge = new int[4];

    public Tire(double[] tirePressure, int[] tireAge) {
        this.tirePressure = tirePressure;
        this.tireAge = tireAge;
    }
    public double[] getTirePressure() {
        return tirePressure;
    }
}

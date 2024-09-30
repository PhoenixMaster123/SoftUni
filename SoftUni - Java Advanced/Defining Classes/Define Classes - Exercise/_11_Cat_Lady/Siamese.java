package exercise._11_Cat_Lady;

public class Siamese extends Cat {
    public double earSize;

    public Siamese(String name, String breed, double earSize) {
        super(name, breed);
        this.earSize = earSize;
    }

    public String toString() {
        return String.format("%s %.2f", super.toString(), earSize);
    }
}

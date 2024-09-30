package exercise._11_Cat_Lady;

public class Cymric extends Cat {
    public double furLength;

    public Cymric(String name, String breed, double furLength) {
        super(name, breed);
        this.furLength = furLength;
    }
    public String toString() {
        return String.format("%s %.2f", super.toString(), furLength);
    }
}

package exercise._11_Cat_Lady;

public class StreetExtraordinaire extends Cat {
    double decibelsOfMeows;

    public StreetExtraordinaire(String name, String breed, double decibelsOfMeows) {
        super(name, breed);
        this.decibelsOfMeows = decibelsOfMeows;
    }
    public String toString() {
        return String.format("%s %.2f", super.toString(), decibelsOfMeows);
    }
}

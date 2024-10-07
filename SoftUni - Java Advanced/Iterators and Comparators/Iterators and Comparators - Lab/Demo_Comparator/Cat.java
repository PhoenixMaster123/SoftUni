package Demo_Comparator;

// I want the cats to compare each other
public class Cat implements Comparable<Cat>{
    private String name;
    private int age;
    private double weight;

    public Cat(String name, int age, double weight) {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }

    // We describe the way how two cats compare each other

    // cat1.compareTo(otherCat)
    @Override
    public int compareTo(Cat otherCat) {

        // Result after compareTo
        // Negative number: my cat is less than the other cat by given criteria
        // Zero: The both cats are equal by given criteria
        // Positive number: my cat is grater than the other cat by given criteria
        return Integer.compare(this.age, otherCat.age);
        // return Double.compare(this.weight, otherCat.weight)
    }
}

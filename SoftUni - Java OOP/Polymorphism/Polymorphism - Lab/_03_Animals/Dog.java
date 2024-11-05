package _03_Animals;

public class Dog extends Animal{
    public Dog(String name, String favouriteFood) {
        super(name, favouriteFood);
    }

    @Override
    public String explainSelf() {
        return "%s\nDJAAF".formatted(super.explainSelf());
    }
}

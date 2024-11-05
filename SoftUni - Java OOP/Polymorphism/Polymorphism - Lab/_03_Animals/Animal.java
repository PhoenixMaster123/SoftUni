package _03_Animals;

public abstract class Animal {
    private String name;
    private String favouriteFood;
    public Animal(String name, String favouriteFood) {
        this.name = name;
        this.favouriteFood = favouriteFood;
    }
    public String explainSelf() {
        return "I am %s and my favourite food is %s ".formatted(this.name, this.favouriteFood);
    }

    public String getName() {
        return name;
    }

    public String getFavouriteFood() {
        return favouriteFood;
    }
}

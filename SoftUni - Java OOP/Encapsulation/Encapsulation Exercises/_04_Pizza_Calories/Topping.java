package _04_Pizza_Calories;

public class Topping extends CaloriesCalculator {
    private String toppingType;
    private double weight;

    public Topping(String toppingType, double weight) {
        setToppingType(toppingType);
        setWeight(weight);
    }

    private void setToppingType(String toppingType) {
        if (!toppingType.equals("Meat") && !toppingType.equals("Veggies") &&
                !toppingType.equals("Cheese") && !toppingType.equals("Sauce")) {
            throw new IllegalArgumentException("Cannot place " + toppingType + " on top of your pizza.");
        }
        this.toppingType = toppingType;
    }

    private void setWeight(double weight) {
        if (weight < 1 || weight > 50) {
            throw new IllegalArgumentException(toppingType + " weight should be in the range [1..50].");
        }
        this.weight = weight;
    }

    @Override
    public double calculateCalories() {
        double baseCalories = 2 * weight;
        double toppingModifier = switch (toppingType) {
            case "Meat" -> 1.2;
            case "Veggies" -> 0.8;
            case "Cheese" -> 1.1;
            case "Sauce" -> 0.9;
            default -> 1;
        };
        return baseCalories * toppingModifier;
    }
}

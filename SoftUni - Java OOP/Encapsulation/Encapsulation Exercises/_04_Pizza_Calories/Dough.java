package _04_Pizza_Calories;

public class Dough extends CaloriesCalculator {
    private String flourType;
    private String bakingTechnique;
    private double weight;

    public Dough(String flourType, String bakingTechnique, double weight) {
        setFlourType(flourType);
        setBakingTechnique(bakingTechnique);
        setWeight(weight);
    }

    private void setFlourType(String flourType) {
        if (!flourType.equals("White") && !flourType.equals("Wholegrain")) {
            throw new IllegalArgumentException("Invalid type of dough.");
        }
        this.flourType = flourType;
    }

    private void setBakingTechnique(String bakingTechnique) {
        if (!bakingTechnique.equals("Crispy") && !bakingTechnique.equals("Chewy") && !bakingTechnique.equals("Homemade")) {
            throw new IllegalArgumentException("Invalid type of dough.");
        }
        this.bakingTechnique = bakingTechnique;
    }

    private void setWeight(double weight) {
        if (weight < 1 || weight > 200) {
            throw new IllegalArgumentException("Dough weight should be in the range [1..200].");
        }
        this.weight = weight;
    }

    @Override
    public double calculateCalories() {
        double baseCalories = 2 * weight;
        double flourModifier = flourType.equals("White") ? 1.5 : 1.0;
        double techniqueModifier = switch (bakingTechnique) {
            case "Crispy" -> 0.9;
            case "Chewy" -> 1.1;
            case "Homemade" -> 1.0;
            default -> 0;
        };
        return baseCalories * flourModifier * techniqueModifier;
    }
}

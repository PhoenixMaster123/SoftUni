package Behavioral_Patterns.Template_Pattern;

public abstract class Sandwich {

    // Template method:
    // 1. Concrete methods:
    // 2. Abstract methods
    public void makeSandwich() {
        // Step 1
        cutTheBread();

        //Step 2:
        addIngredients();

        // Step 3:
        packTheSandwich();
    }

    public void cutTheBread() {
        System.out.println("Cut the bread.");
    }
    public void packTheSandwich() {
        System.out.println("Pack the sandwich in a plastic bag.");
    }

    public abstract void addIngredients();

}

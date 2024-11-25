package Behavioral_Patterns.Template_Pattern;

public class HamSandwich extends Sandwich{
    @Override
    public void addIngredients() {
        System.out.println("Adding ham and mozzarella in the bread");
    }
}

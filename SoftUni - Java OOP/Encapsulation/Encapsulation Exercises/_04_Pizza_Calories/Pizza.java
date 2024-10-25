package _04_Pizza_Calories;

import java.util.ArrayList;
import java.util.List;

public class Pizza {
    private String name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(String name, int numberOfToppings) {
        setName(name);
        setToppings(numberOfToppings);
        this.toppings = new ArrayList<>();
    }

    public void addTopping(Topping topping) {
        if (this.toppings.size() >= 10) {
            throw new IllegalArgumentException("Number of toppings should be in range [0..10].");
        }
        this.toppings.add(topping);
    }

    public double getOverallCalories() {
        double totalCalories = dough.calculateCalories();
        for (Topping topping : toppings) {
            totalCalories += topping.calculateCalories();
        }
        return totalCalories;
    }

    public String getName() {
        return name;
    }

    private void setName(String name) {
        if (name == null || name.trim().isEmpty() || name.length() > 15) {
            throw new IllegalArgumentException("Pizza name should be between 1 and 15 symbols.");
        }
        this.name = name;
    }

    private void setToppings(int numberOfToppings) {
        if (numberOfToppings < 0 || numberOfToppings > 10) {
            throw new IllegalArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public void setDough(Dough dough) {
        this.dough = dough;
    }
}

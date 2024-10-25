package _04_Pizza_Calories;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        try {
            String[] pizzaAttributes = scanner.nextLine().split(" ");
            String pizzaName = pizzaAttributes[1];
            int numberOfToppings = Integer.parseInt(pizzaAttributes[2]);

            Pizza pizza = new Pizza(pizzaName, numberOfToppings);

            String[] doughAttributes = scanner.nextLine().split(" ");
            String flourType = doughAttributes[1];
            String bakingTechnique = doughAttributes[2];
            double doughWeight = Double.parseDouble(doughAttributes[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
            pizza.setDough(dough);

            String line;
            while (!(line = scanner.nextLine()).equals("END")) {
                String[] toppingAttributes = line.split(" ");
                String toppingType = toppingAttributes[1];
                double toppingWeight = Double.parseDouble(toppingAttributes[2]);

                Topping topping = new Topping(toppingType, toppingWeight);
                pizza.addTopping(topping);
            }

            System.out.printf("%s - %.2f", pizza.getName(), pizza.getOverallCalories());
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
    }
}

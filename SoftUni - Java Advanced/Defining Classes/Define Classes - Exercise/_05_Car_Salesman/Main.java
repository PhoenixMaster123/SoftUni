package exercise._05_Car_Salesman;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Engine> engines = new LinkedHashMap<>(); // Maps an engine model to engine
        List<Car> cars = new ArrayList<>(); // List to store cars

        int n = Integer.parseInt(scanner.nextLine());

        // Parse engines
        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");
            String model = tokens[0];
            int power = Integer.parseInt(tokens[1]);

            String displacement = "n/a";
            String efficiency = "n/a";

            if (tokens.length == 3) {
                if (Character.isDigit(tokens[2].charAt(0))) {
                    displacement = tokens[2];
                } else {
                    efficiency = tokens[2];
                }
            } else if (tokens.length == 4) {
                displacement = tokens[2];
                efficiency = tokens[3];
            }

            Engine engine = new Engine(model, power, displacement, efficiency);
            engines.put(model, engine); // Store engine by model
        }

        int m = Integer.parseInt(scanner.nextLine());

        // Parse cars
        for (int i = 0; i < m; i++) {
            String[] tokens = scanner.nextLine().split(" ");
            String model = tokens[0];
            String engineModel = tokens[1];
            Engine engine = engines.get(engineModel); // Reference the actual Engine object

            String weight = "n/a";
            String color = "n/a";

            if (tokens.length == 3) {
                if (Character.isDigit(tokens[2].charAt(0))) {
                    weight = tokens[2];
                } else {
                    color = tokens[2];
                }
            } else if (tokens.length == 4) {
                weight = tokens[2];
                color = tokens[3];
            }

            Car car = new Car(model, engine, weight, color);
            cars.add(car);
        }

        // Print all cars
        for (Car car : cars) {
            System.out.println(car);
        }
    }
}

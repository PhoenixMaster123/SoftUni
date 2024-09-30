package exercise._04_Raw_Data_02;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        List<Car> cars = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");

            String model = tokens[0];
            int engineSpeed = Integer.parseInt(tokens[1]);
            int enginePower = Integer.parseInt(tokens[2]);
            int cargoWeight = Integer.parseInt(tokens[3]);
            String cargoType = tokens[4];

            double[] tirePressure = {
                    Double.parseDouble(tokens[5]), Double.parseDouble(tokens[7]),
                    Double.parseDouble(tokens[9]), Double.parseDouble(tokens[11])
            };
            int[] tireAge = {
                    Integer.parseInt(tokens[6]), Integer.parseInt(tokens[8]),
                    Integer.parseInt(tokens[10]), Integer.parseInt(tokens[12])
            };

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire tire = new Tire(tirePressure, tireAge);

            Car car = new Car(model, engine, cargo, tire);
            cars.add(car);
        }

        String command = scanner.nextLine();

        if (command.equals("fragile")) {
            cars.stream()
                    .filter(car -> car.getCargo().getType().equals("fragile"))
                    .filter(car -> car.getTire().hasLowPressure())
                    .forEach(car -> System.out.println(car.getModel()));
        } else if (command.equals("flamable")) {
            cars.stream()
                    .filter(car -> car.getCargo().getType().equals("flamable"))
                    .filter(car -> car.getEngine().getPower() > 250)
                    .forEach(car -> System.out.println(car.getModel()));
        }
    }
}


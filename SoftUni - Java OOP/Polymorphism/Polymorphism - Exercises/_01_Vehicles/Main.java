package _01_Vehicles;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] tokens = scanner.nextLine().split(" ");

        Vehicle car = new Car(Double.parseDouble(tokens[1]),
                              Double.parseDouble(tokens[2]));

        tokens = scanner.nextLine().split(" ");

        Vehicle truck = new Truck(Double.parseDouble(tokens[1]),
                Double.parseDouble(tokens[2]));

        Map<String, Vehicle> vehicleMap = Map.of("Car", car, "Truck", truck);
        
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {

            tokens = scanner.nextLine().split(" ");

            Vehicle vehicle = vehicleMap.get(tokens[1]);
            double parameter = Double.parseDouble(tokens[2]);
            switch (tokens[0]) {
                case "Drive" -> {
                    String result = vehicle.drive(parameter);
                    System.out.println(result);
                }
                case "Refuel" -> vehicle.refuel(parameter);
            }
        }
        System.out.println(car);
        System.out.println(truck);
    }
}

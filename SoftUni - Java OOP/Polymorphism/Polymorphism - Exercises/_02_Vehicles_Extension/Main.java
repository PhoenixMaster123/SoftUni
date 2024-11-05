package _02_Vehicles_Extension;

import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] tokens = scanner.nextLine().split(" ");

       Vehicle car = new Car(Double.parseDouble(tokens[1]),
                              Double.parseDouble(tokens[2]),
                              Double.parseDouble(tokens[3]));

        tokens = scanner.nextLine().split(" ");

        Vehicle truck = new Truck(Double.parseDouble(tokens[1]),
                Double.parseDouble(tokens[2]),
                Double.parseDouble(tokens[3]));

        tokens = scanner.nextLine().split(" ");

        Vehicle bus = new Bus(Double.parseDouble(tokens[1]),
                Double.parseDouble(tokens[2]),
                Double.parseDouble(tokens[3]));

        Map<String, Vehicle> vehicleMap = Map.of("Car", car, "Truck", truck, "Bus", bus);
        
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {

            tokens = scanner.nextLine().split(" ");
            try {
                Vehicle vehicle = vehicleMap.get(tokens[1]);
                double parameter = Double.parseDouble(tokens[2]);
                switch (tokens[0]) {
                    case "Drive" -> {
                        vehicle.setEmpty(false);
                        String result = vehicle.drive(parameter);
                        System.out.println(result);
                    }
                    case "DriveEmpty" -> {
                        vehicle.setEmpty(true);
                        String result = vehicle.drive(parameter);
                        System.out.println(result);
                    }
                    case "Refuel" -> vehicle.refuel(parameter);
                }
            }
            catch (IllegalArgumentException e) {
                System.out.println(e.getMessage());
            }
        }
        System.out.println(car);
        System.out.println(truck);
        System.out.println(bus);
    }
}

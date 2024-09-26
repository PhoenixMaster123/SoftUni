package lab._02_Constructors;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        List<Car> carList = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");

            Car car;
            if(tokens.length == 1) {
                String brand = tokens[0];
                car = new Car(brand);
            } else {
                String brand = tokens[0];
                String model = tokens[1];
                int horsePower = Integer.parseInt(tokens[2]);
                car = new Car(brand,model, horsePower);
            }
            carList.add(car);
        }
        carList.forEach(car -> System.out.println(car.carInfo()));
    }
}
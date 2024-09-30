package exercise._04_Raw_Data;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Map<Car, Engine> carEngineMap = new LinkedHashMap<>();
        Map<Car, Cargo> carCargoMap = new LinkedHashMap<>();
        Map<Car, Tire> carTireMap = new LinkedHashMap<>();
        Set<Car> carList = new LinkedHashSet<>();

        for (int i = 0; i < n; i++) {

            String[] tokens = scanner.nextLine().split(" ");

            String model = tokens[0];
            int engineSpeed = Integer.parseInt(tokens[1]);
            int enginePower = Integer.parseInt(tokens[2]);
            int cargoWeight = Integer.parseInt(tokens[3]);
            String cargoType = tokens[4];
            double[] tirePressure = new double[]
                    {Double.parseDouble(tokens[5]), Double.parseDouble(tokens[7]),
                     Double.parseDouble(tokens[9]), Double.parseDouble(tokens[11])};
            int[] tireAge = new int[] {Integer.parseInt(tokens[6]), Integer.parseInt(tokens[8]),
                                       Integer.parseInt(tokens[10]),Integer.parseInt(tokens[12])};

            Car car = new Car(model);
            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire tire = new Tire(tirePressure, tireAge);

            carEngineMap.putIfAbsent(car, engine);
            carCargoMap.putIfAbsent(car, cargo);
            carTireMap.putIfAbsent(car, tire);
        }
        String searchedType = scanner.nextLine();

       for(Map.Entry<Car, Cargo> entry : carCargoMap.entrySet()) {

           Cargo cargoFilter = entry.getValue();

           if(cargoFilter.getCargoType().equals(searchedType)) {
               carList.add(entry.getKey());
           }
       }
       if(searchedType.equals("fragile")) {
           for(Map.Entry<Car, Tire> entry : carTireMap.entrySet()) {
               Car currentCar = entry.getKey();

               if(carList.contains(currentCar))
               {
                   Tire tire = entry.getValue();
                   if(checkTirePressure(tire.getTirePressure())) {
                       System.out.println(currentCar.getModel());
                   }
                   else {
                       carList.remove(currentCar);
                   }
               }
           }
       }
       else if(searchedType.equals("flamable")) {
           for(Map.Entry<Car,Engine> entry : carEngineMap.entrySet()) {
               Car currentCar = entry.getKey();
               if(carList.contains(currentCar)) {
                   Engine engine = entry.getValue();
                   if(engine.getEnginePower() > 250) {
                       System.out.println(currentCar.getModel());
                   }
                   else {
                       carList.remove(currentCar);
                   }
               }
           }
       }
    }
    public static boolean checkTirePressure(double[] tirePressure) {

        for (double pressure : tirePressure) {

            if(pressure < 1) {
                return true;
            }
        }
        return false;
    }
}

package Demo;

import java.util.Comparator;
import java.util.Iterator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Car opel = new Car("Opel", 105);
        Car tesla = new Car("Tesla", 500, "2023");
        Car teslaCyberTruck = new Car("TeslaCyberTruck", 500, "2023", "WBAN2442515212");
        // We can put an array

        int res = opel.compareTo(tesla); // opel = this.car

        List<Car> carList = List.of(opel, tesla, teslaCyberTruck);

        carList.stream().sorted((car1,car2) -> car2.compareTo(car1)).forEach(System.out::println);

        Comparator<Car> carComparator = CarComparator.carComparator;
        System.out.println(carComparator.compare(opel, tesla));

        Garage garage = new Garage(new Car[]{opel,tesla,teslaCyberTruck});

        Iterator<Car> iterator = garage.iterator();

        while (iterator.hasNext()) {
            System.out.println(iterator.next());
        }
    }
}

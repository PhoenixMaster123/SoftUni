package Demo;

import java.util.Comparator;

public class CarComparator{

    private CarComparator() {}
    static Comparator<Car> carComparator = (car1,car2) -> {
       return Integer.compare(car1.getHorsePower(), car2.getHorsePower());
    };
}
